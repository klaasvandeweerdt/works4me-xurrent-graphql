using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Serialization
{
    /// <summary>
    /// Provides a factory for creating JSON converters for Xurrent SDK types, including support for enums, interfaces, and fields with <see cref="XurrentFieldAttribute"/>.
    /// </summary>
    internal sealed class XurrentJsonConverterFactory : JsonConverterFactory
    {
        private readonly Dictionary<string, Type> _interfaceTypeMappings = new();
        private readonly Type? _type;
        private readonly ISet<string>? _fields;

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentJsonConverterFactory"/> class with default configuration.
        /// </summary>
        public XurrentJsonConverterFactory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentJsonConverterFactory"/> class with interface type mappings for interface deserialization.
        /// </summary>
        /// <param name="interfaceTypeMappings">A dictionary mapping GraphQL <c>__typename</c> values to CLR types.</param>
        public XurrentJsonConverterFactory(Dictionary<string, Type> interfaceTypeMappings)
        {
            _interfaceTypeMappings = interfaceTypeMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentJsonConverterFactory"/> class for a specific type and set of fields, 
        /// intended for mutation content serialization.
        /// </summary>
        /// <param name="type">The root CLR type to target.</param>
        /// <param name="fields">The set of property names to include in serialization.</param>
        public XurrentJsonConverterFactory(Type type, ISet<string> fields)
        {
            _type = type;
            _fields = fields;
        }

        /// <summary>
        /// Determines whether this factory can create a converter for the specified type.
        /// </summary>
        /// <param name="typeToConvert">The type to evaluate.</param>
        /// <returns><c>true</c> if a converter can be created for <paramref name="typeToConvert"/>; otherwise, <c>false</c>.</returns>
        public override bool CanConvert(Type typeToConvert)
        {
            if (typeToConvert == typeof(DateTime) || typeToConvert == typeof(DateTime?))
                return true;

            if (typeToConvert == typeof(TimeSpan) || typeToConvert == typeof(TimeSpan?))
                return true;

            if (typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                if (Nullable.GetUnderlyingType(typeToConvert) is Type underlying && underlying.IsEnum)
                    return true;
            }

            if (typeToConvert.IsEnum)
                return true;

            if (typeToConvert.IsClass)
            {
                bool hasFields = typeToConvert
                    .GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                    .Any(pi => pi.GetCustomAttribute<XurrentFieldAttribute>() is not null);

                if (hasFields)
                    return true;
            }

            if (typeToConvert.IsInterface && typeToConvert.GetCustomAttribute<XurrentInterfaceAttribute>(inherit: false) is not null)
                return true;

            return false;
        }

        /// <summary>
        /// Creates a JSON converter for the specified type using Xurrent SDK conventions.
        /// </summary>
        /// <param name="typeToConvert">The type to convert.</param>
        /// <param name="options">The <see cref="JsonSerializerOptions"/> in use.</param>
        /// <returns>A <see cref="JsonConverter"/> instance for the specified type.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the factory cannot create a converter for the given type.</exception>
        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert == typeof(DateTime))
                return new ISO8601TimestampConverter();

            if (typeToConvert == typeof(DateTime?))
                return new ISO8601TimestampNullableConverter();

            if (typeToConvert == typeof(TimeSpan))
                return new ISO8601TimeConverter();

            if (typeToConvert == typeof(TimeSpan?))
                return new ISO8601TimeNullableConverter();

            if (typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                if (Nullable.GetUnderlyingType(typeToConvert) is Type underlying && underlying.IsEnum)
                {
                    Type convType = typeof(XurrentEnumNullableConverter<>).MakeGenericType(underlying);
                    return (JsonConverter)Activator.CreateInstance(convType)!;
                }
            }

            if (typeToConvert.IsEnum)
            {
                Type convType = typeof(XurrentEnumConverter<>).MakeGenericType(typeToConvert);
                return (JsonConverter)Activator.CreateInstance(convType)!;
            }

            if (typeToConvert.IsClass)
            {
                if (_fields is not null && typeToConvert == _type)
                {
                    Type convType = typeof(XurrentMutationContentConverter<>).MakeGenericType(typeToConvert);
                    return (JsonConverter)Activator.CreateInstance(convType, _fields)!;
                }
                else
                {
                    Type convType = typeof(XurrentObjectConverter<>).MakeGenericType(typeToConvert);
                    return (JsonConverter)Activator.CreateInstance(convType)!;
                }
            }

            if (typeToConvert.IsInterface && _interfaceTypeMappings.Count > 0 && typeToConvert.GetCustomAttribute<XurrentInterfaceAttribute>(inherit: false) is not null)
            {
                Type convType = typeof(XurrentInterfaceConverter<>).MakeGenericType(typeToConvert);
                return (JsonConverter)Activator.CreateInstance(convType, _interfaceTypeMappings, options)!;
            }

            throw new InvalidOperationException($"{nameof(XurrentJsonConverterFactory)} cannot create a converter for {typeToConvert}.");
        }
    }
}
