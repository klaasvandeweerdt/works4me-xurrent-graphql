using System;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Serialization;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Serialization
{
    public class XurrentObjectConverterSpecs
    {
        private readonly JsonSerializerOptions _options;

        public XurrentObjectConverterSpecs()
        {
            _options = new JsonSerializerOptions();
            _options.Converters.Add(new XurrentObjectConverter<MockConfigurationItem>());
        }

        [Fact]
        public void Read_MapsJson_ToProperties()
        {
            string json = "{ \"name\": \"test\", \"nrOfCores\": 24 }";

            MockConfigurationItem? result = JsonSerializer.Deserialize<MockConfigurationItem>(json, _options);

            Assert.Equal("test", result?.Name);
            Assert.Equal(24, result?.NrOfCores);
        }

        [Fact]
        public void Read_Ignores_UnmappedProperties()
        {
            string json = "{ \"name\": \"test\", \"unknown\": true }";

            MockConfigurationItem? result = JsonSerializer.Deserialize<MockConfigurationItem>(json, _options);

            Assert.Equal("test", result?.Name);
            Assert.Null(result?.NrOfCores);
        }

        [Fact]
        public void Write_Serializes_MappedProperties()
        {
            MockConfigurationItem obj = new()
            {
                Name = "hello",
                NrOfCores = 24
            };

            string json = JsonSerializer.Serialize(obj, _options);

            Assert.Contains("\"name\":\"hello\"", json);
            Assert.Contains("\"nrOfCores\":24", json);
        }

        [Fact]
        public void Constructor_Throws_WhenNoMappedProperties()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
                new XurrentObjectConverter<MockInvalidEntity>());

            Assert.Contains("[XurrentField]", ex.Message);
        }
    }
}
