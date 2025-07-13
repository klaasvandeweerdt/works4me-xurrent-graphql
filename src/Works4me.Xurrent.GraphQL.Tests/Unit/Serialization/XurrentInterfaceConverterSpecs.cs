using System;
using System.Collections.Generic;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Serialization;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Serialization
{
    public class XurrentInterfaceConverterSpecs
    {
        private readonly Dictionary<string, Type> _mappings;
        private readonly JsonSerializerOptions _options;

        public XurrentInterfaceConverterSpecs()
        {
            _mappings = new Dictionary<string, Type>
            {
                { "ConfigurationItem", typeof(ConfigurationItem) },
                { "Person", typeof(Person) }
            };

            _options = SerializationConfiguration.CreateJsonOptions(_mappings);
        }

        [Fact]
        public void Read_ResolvesConcreteType_FromTypeName()
        {
            string json = "{ \"__typename\": \"ConfigurationItem\", \"name\": \"test\" }";

            INode? result = JsonSerializer.Deserialize<INode>(json, _options);

            Assert.NotNull(result);
            Assert.IsType<ConfigurationItem>(result);
            Assert.Equal("test", ((ConfigurationItem)result).Name);
        }

        [Fact]
        public void Read_Throws_WhenTypeNameMissing()
        {
            string json = "{ \"name\": \"test\" }";

            JsonException ex = Assert.Throws<JsonException>(() =>
                JsonSerializer.Deserialize<INode>(json, _options));

            Assert.Contains("__typename", ex.Message);
        }

        [Fact]
        public void Read_ReturnsNull_ForUnknownTypeName()
        {
            string json = "{ \"__typename\": \"UnknownType\", \"name\": \"test\" }";

            INode? result = JsonSerializer.Deserialize<INode>(json, _options);

            Assert.Null(result);
        }

        [Fact]
        public void Write_Serializes_ConcreteObject()
        {
            INode obj = new ConfigurationItem { NrOfCores = 24 };

            string json = JsonSerializer.Serialize(obj, _options);

            Assert.Contains("\"nrOfCores\":24", json);
        }

        [Fact]
        public void Write_Serializes_NullAsNull()
        {
            INode? obj = null;

            string json = JsonSerializer.Serialize(obj, _options);

            Assert.Equal("null", json);
        }
    }
}
