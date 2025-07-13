using System.Collections.Generic;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Works4me.Xurrent.GraphQL.Serialization
{
    /// <summary>
    /// Provides methods for creating and cloning <see cref="JsonSerializerOptions"/> preconfigured with Xurrent SDK converters.
    /// </summary>
    internal static class SerializationConfiguration
    {
        public static readonly JsonSerializerOptions DefaultJsonOption = new();

        /// <summary>
        /// Creates a new <see cref="JsonSerializerOptions"/> instance configured with the Xurrent converter factory.
        /// </summary>
        /// <returns>A new <see cref="JsonSerializerOptions"/> instance with standard Xurrent converters.</returns>
        public static JsonSerializerOptions CreateJsonOptions()
        {
            JsonSerializerOptions options = CloneOptions(DefaultJsonOption);
            options.Converters.Add(new XurrentJsonConverterFactory());
            return options;
        }

        /// <summary>
        /// Creates a new <see cref="JsonSerializerOptions"/> instance with Xurrent converters and explicit interface type mappings.
        /// </summary>
        /// <param name="interfaceTypeMappings">A mapping of GraphQL interface names to CLR types for interface deserialization.</param>
        /// <returns>A new <see cref="JsonSerializerOptions"/> instance with custom interface mappings.</returns>
        public static JsonSerializerOptions CreateJsonOptions(Dictionary<string, Type> interfaceTypeMappings)
        {
            JsonSerializerOptions options = CloneOptions(DefaultJsonOption);
            options.Converters.Add(new XurrentJsonConverterFactory(interfaceTypeMappings));
            return options;
        }

        /// <summary>
        /// Creates a new <see cref="JsonSerializerOptions"/> instance with Xurrent converters for a given type and set of fields.
        /// </summary>
        /// <param name="type">The root CLR type for serialization.</param>
        /// <param name="fields">The set of property names to include during serialization.</param>
        /// <returns>A new <see cref="JsonSerializerOptions"/> instance with type/field-based configuration.</returns>
        public static JsonSerializerOptions CreateJsonOptions(Type type, ISet<string> fields)
        {
            JsonSerializerOptions options = CloneOptions(DefaultJsonOption);
            options.Converters.Add(new XurrentJsonConverterFactory(type, fields));
            return options;
        }

        /// <summary>
        /// Creates a deep copy of the given <see cref="JsonSerializerOptions"/> instance.
        /// </summary>
        /// <param name="source">The <see cref="JsonSerializerOptions"/> to clone.</param>
        /// <returns>A new <see cref="JsonSerializerOptions"/> instance with all settings and converters from the source.</returns>
        private static JsonSerializerOptions CloneOptions(JsonSerializerOptions source)
        {
            JsonSerializerOptions options = new()
            {
                AllowTrailingCommas = source.AllowTrailingCommas,
                DefaultBufferSize = source.DefaultBufferSize,
                DefaultIgnoreCondition = source.DefaultIgnoreCondition,
                DictionaryKeyPolicy = source.DictionaryKeyPolicy,
                Encoder = source.Encoder,
                IgnoreReadOnlyFields = source.IgnoreReadOnlyFields,
                IgnoreReadOnlyProperties = source.IgnoreReadOnlyProperties,
                IncludeFields = source.IncludeFields,
                MaxDepth = source.MaxDepth,
                NumberHandling = source.NumberHandling,
                PropertyNameCaseInsensitive = source.PropertyNameCaseInsensitive,
                PropertyNamingPolicy = source.PropertyNamingPolicy,
                ReadCommentHandling = source.ReadCommentHandling,
                ReferenceHandler = source.ReferenceHandler,
                TypeInfoResolver = source.TypeInfoResolver,
                UnmappedMemberHandling = source.UnmappedMemberHandling,
                UnknownTypeHandling = source.UnknownTypeHandling,
                WriteIndented = source.WriteIndented,
                IndentCharacter = source.IndentCharacter,
                IndentSize = source.IndentSize,
                NewLine = source.NewLine
            };

            foreach (JsonConverter converter in source.Converters)
                options.Converters.Add(converter);

            return options;
        }
    }
}
