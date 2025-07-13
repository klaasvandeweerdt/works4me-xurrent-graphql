using System;
using System.Collections.Concurrent;
using System.Reflection;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Extensions
{
    /// <summary>
    /// A set of <see cref="Enum"/> extension methods.
    /// </summary>
    public static class EnumExtension
    {
        private static readonly ConcurrentDictionary<(Type enumType, object value), string?> _enumValueCache = new();

        /// <summary>
        /// Returns the <see cref="XurrentEnumAttribute"/> EnumName of an enumerator.
        /// Returns null if EnumName is not defined.
        /// </summary>
        /// <param name="value">The enumerator value.</param>
        /// <returns>The serialized name, or null.</returns>
        public static string? GetXurrentEnumValue(this Enum value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

            return _enumValueCache.GetOrAdd((value.GetType(), value), key =>
            {
                (Type enumType, object enumValue) = key;
                FieldInfo? field = enumType.GetField(enumValue.ToString()!);
                XurrentEnumAttribute? attribute = field?.GetCustomAttribute<XurrentEnumAttribute>();

                return attribute?.EnumName;
            });
        }
    }
}
