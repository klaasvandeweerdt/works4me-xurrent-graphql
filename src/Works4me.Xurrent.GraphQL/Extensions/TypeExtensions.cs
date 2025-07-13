using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    /// <summary>
    /// Provides extension methods for <see cref="Type"/> to assist with Xurrent entity and collection metadata discovery.
    /// </summary>
    internal static class TypeExtensions
    {
        private static readonly ConcurrentDictionary<Type, (XurrentEntityAttribute? Attribute, Type? ElementType)> _xurrentEntityCollectionCache = new();

        /// <summary>
        /// Determines whether the specified type is a node collection of <see cref="PagedResponse{T}"/>.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to evaluate.</param>
        /// <returns><c>true</c> if the type is a <see cref="PagedResponse{T}"/>; otherwise, <c>false</c>.</returns>
        public static bool IsNodeCollection(this Type type)
        {
            if (type is null)
                throw new ArgumentNullException(nameof(type));

            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(PagedResponse<>);
        }

        /// <summary>
        /// Attempts to extract the <see cref="XurrentEntityAttribute"/> and element type for the specified collection type.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to evaluate.</param>
        /// <param name="attribute">When this method returns, contains the <see cref="XurrentEntityAttribute"/> if found; otherwise, <c>null</c>.</param>
        /// <param name="elementType">When this method returns, contains the element type if found; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the type is a supported collection with an associated <see cref="XurrentEntityAttribute"/>; otherwise, <c>false</c>.</returns>
        public static bool TryGetXurrentEntityCollection(this Type type, out XurrentEntityAttribute? attribute, out Type? elementType)
        {
            if (type is null)
                throw new ArgumentNullException(nameof(type));

            (XurrentEntityAttribute? Attribute, Type? ElementType) cached = _xurrentEntityCollectionCache.GetOrAdd(type, t =>
            {
                Type type = Nullable.GetUnderlyingType(t) ?? t;

                if (type.IsArray)
                {
                    Type? elem = type.GetElementType();
                    if (elem is not null)
                    {
                        elem = Nullable.GetUnderlyingType(elem) ?? elem;
                        return (elem.GetCustomAttribute<XurrentEntityAttribute>(), elem);
                    }
                    return (null, null);
                }

                Type? IEnumerableType = type.GetInterfaces().FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>));
                if (IEnumerableType is not null)
                {
                    Type elem = IEnumerableType.GetGenericArguments()[0];
                    elem = Nullable.GetUnderlyingType(elem) ?? elem;
                    return (elem.GetCustomAttribute<XurrentEntityAttribute>(), elem);
                }

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                {
                    Type elem = type.GetGenericArguments()[0];
                    elem = Nullable.GetUnderlyingType(elem) ?? elem;
                    return (elem.GetCustomAttribute<XurrentEntityAttribute>(), elem);
                }

                return (null, null);
            });

            attribute = cached.Attribute;
            elementType = cached.ElementType;
            return attribute is not null;
        }
    }
}
