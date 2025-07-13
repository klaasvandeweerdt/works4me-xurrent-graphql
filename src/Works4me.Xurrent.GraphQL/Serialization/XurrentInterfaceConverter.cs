using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Works4me.Xurrent.GraphQL.Serialization
{
    /// <summary>
    /// Provides JSON serialization and deserialization for GraphQL interface types, resolving concrete types using <c>__typename</c> and a provided type mapping.
    /// </summary>
    /// <typeparam name="TInterface">The interface type to convert.</typeparam>
    internal sealed class XurrentInterfaceConverter<TInterface> : JsonConverter<TInterface> where TInterface : class
    {
        private readonly Dictionary<string, Type> _interfaceTypeMappings;
        private readonly JsonSerializerOptions _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentInterfaceConverter{TInterface}"/> class with specified interface type mappings and serializer options.
        /// </summary>
        /// <param name="interfaceTypeMappings">A dictionary mapping GraphQL <c>__typename</c> values to CLR types.</param>
        /// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization and deserialization.</param>
        public XurrentInterfaceConverter(Dictionary<string, Type> interfaceTypeMappings, JsonSerializerOptions options)
        {
            _interfaceTypeMappings = interfaceTypeMappings;
            _options = options;
        }

        /// <summary>
        /// Reads an instance of <typeparamref name="TInterface"/> from JSON, using <c>__typename</c> to determine the concrete type.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">The interface type being converted.</param>
        /// <param name="options">The <see cref="JsonSerializerOptions"/> in use.</param>
        /// <returns>The deserialized instance of <typeparamref name="TInterface"/>, or <c>null</c> if the token is null.</returns>
        public override TInterface? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            using (JsonDocument document = JsonDocument.ParseValue(ref reader))
            {
                JsonElement root = document.RootElement;

                if (root.TryGetProperty("__typename", out JsonElement typeNameElement) && typeNameElement.ValueKind == JsonValueKind.String)
                {
                    string? typeName = typeNameElement.GetString();
                    if (typeName is not null && _interfaceTypeMappings.TryGetValue(typeName, out Type? concreteType) && concreteType is not null)
                    {
                        string rawJson = root.GetRawText();
                        object? result = JsonSerializer.Deserialize(rawJson, concreteType, _options);
                        return (TInterface?)result;
                    }
                }
                else
                {
                    throw new JsonException($"The GraphQL __typename value for interface '{typeToConvert.Name}' is missing or not a string.");
                }
            }
            return null;
        }

        /// <summary>
        /// Writes an instance of <typeparamref name="TInterface"/> to JSON, using its actual CLR type for serialization.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The <typeparamref name="TInterface"/> value to write.</param>
        /// <param name="options">The <see cref="JsonSerializerOptions"/> in use.</param>
        public override void Write(Utf8JsonWriter writer, TInterface value, JsonSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }

            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
