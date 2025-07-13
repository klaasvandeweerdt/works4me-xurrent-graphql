using System;
using System.Collections.Generic;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Serialization;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Serialization
{
    public class XurrentMutationContentConverterSpecs
    {
        private readonly JsonSerializerOptions _options;

        public XurrentMutationContentConverterSpecs()
        {
            HashSet<string> fields = new() { "name", "nrOfCores" };
            _options = new JsonSerializerOptions();
            _options.Converters.Add(new XurrentMutationContentConverter<MockConfigurationItem>(fields));
        }

        [Fact]
        public void Read_MapsFields_ToProperties()
        {
            string json = "{ \"name\": \"test\", \"nrOfCores\": 24 }";

            MockConfigurationItem? result = JsonSerializer.Deserialize<MockConfigurationItem>(json, _options);

            Assert.Equal("test", result?.Name);
            Assert.Equal(24, result?.NrOfCores);
        }

        [Fact]
        public void Read_Ignores_UnknownProperties()
        {
            string json = "{ \"name\": \"test\", \"unknown\": 123 }";

            MockConfigurationItem? result = JsonSerializer.Deserialize<MockConfigurationItem>(json, _options);

            Assert.Equal("test", result?.Name);
            Assert.Null(result?.NrOfCores);
        }

        [Fact]
        public void Write_Serializes_OnlyAllowedFields()
        {
            MockConfigurationItem obj = new()
            {
                Name = "hello",
                NrOfCores = 24,
                CreatedAt = DateTime.Now
            };

            string json = JsonSerializer.Serialize(obj, _options);

            Assert.Contains("\"name\":\"hello\"", json);
            Assert.Contains("\"nrOfCores\":24", json);
            Assert.DoesNotContain("createdAt", json);
        }
    }
}
