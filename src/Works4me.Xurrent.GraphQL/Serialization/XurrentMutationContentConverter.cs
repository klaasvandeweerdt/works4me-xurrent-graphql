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
    /// Provides JSON serialization and deserialization for Xurrent mutation content, restricting output to a specified set of fields.
    /// </summary>
    /// <typeparam name="T">The type of the mutation content object.</typeparam>
    internal sealed class XurrentMutationContentConverter<T> : JsonConverter<T>
        where T : class, new()
    {
        private readonly ISet<string> _fields;
        private readonly Dictionary<string, PropertyInfo> _propertyMapping;

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentMutationContentConverter{T}"/> class, restricting serialization to the specified fields.
        /// </summary>
        /// <param name="fields">The set of property names (JSON field names) to include in serialization.</param>
        public XurrentMutationContentConverter(ISet<string> fields)
        {
            _fields = fields;
            _propertyMapping = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .Select(p => (Property: p, Attribute: p.GetCustomAttribute<XurrentFieldAttribute>()))
                .Where(x => x.Attribute is not null)
                .ToDictionary(
                    x => x.Attribute!.FieldName,
                    x => x.Property,
                    StringComparer.Ordinal);
        }

        /// <summary>
        /// Reads an instance of <typeparamref name="T"/> from JSON, mapping fields to properties using Xurrent field metadata.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">The type being converted.</param>
        /// <param name="options">The <see cref="JsonSerializerOptions"/> in use.</param>
        /// <returns>The deserialized <typeparamref name="T"/> instance.</returns>
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            T retval = new();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                    return retval;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string propName = reader.GetString()!;
                    reader.Read();

                    if (_propertyMapping.TryGetValue(propName, out PropertyInfo? propInfo))
                    {
                        object? value = JsonSerializer.Deserialize(ref reader, propInfo.PropertyType, options);
                        propInfo.SetValue(retval, value);
                    }
                    else
                    {
                        reader.Skip();
                    }
                }
            }

            return retval;
        }

        /// <summary>
        /// Writes an instance of <typeparamref name="T"/> to JSON, including only the specified fields.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="options">The <see cref="JsonSerializerOptions"/> in use.</param>
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            foreach (KeyValuePair<string, PropertyInfo> kv in _propertyMapping)
            {
                string jsonName = kv.Key;
                if (_fields.Contains(jsonName))
                {
                    PropertyInfo prop = kv.Value;
                    object? propValue = prop.GetValue(value);

                    writer.WritePropertyName(jsonName);
                    JsonSerializer.Serialize(writer, propValue, prop.PropertyType, options);
                }
            }

            writer.WriteEndObject();
        }
    }
}
