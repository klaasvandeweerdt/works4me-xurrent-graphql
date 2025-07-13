using System;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Serialization;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Serialization
{
    public class XurrentEnumNullableConverterSpecs
    {
        private readonly JsonSerializerOptions _options;

        public XurrentEnumNullableConverterSpecs()
        {
            _options = new JsonSerializerOptions();
            _options.Converters.Add(new XurrentEnumNullableConverter<MockCiStatus>());
        }

        [Fact]
        public void Read_ReturnsNull_WhenEnumIsNull()
        {
            string json = "null";

            MockCiStatus? result = JsonSerializer.Deserialize<MockCiStatus?>(json, _options);

            Assert.Null(result);
        }

        [Theory]
        [InlineData("\"in_stock\"", MockCiStatus.InStock)]
        [InlineData("\"in_production\"", MockCiStatus.InProduction)]
        [InlineData("null", null)]
        public void Read_Parses_ValidEnumStrings(string json, MockCiStatus? expected)
        {
            MockCiStatus? result = JsonSerializer.Deserialize<MockCiStatus?>(json, _options);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(MockCiStatus.InStock, "\"in_stock\"")]
        [InlineData(MockCiStatus.InProduction, "\"in_production\"")]
        [InlineData(null, "null")]
        public void Write_Serializes_EnumToString(MockCiStatus? value, string expectedJson)
        {
            string json = JsonSerializer.Serialize(value, _options);

            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void Read_Throws_OnUnknownString()
        {
            Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<MockCiStatus>("\"unknown_value\"", _options));
        }

        [Fact]
        public void Write_WritesNull_WhenEnumIsNull()
        {
            MockCiStatus? @enum = null;

            string json = JsonSerializer.Serialize(@enum, _options);

            Assert.Equal("null", json);
        }
    }
}
