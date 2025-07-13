using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Works4me.Xurrent.GraphQL.Serialization;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Serialization
{
    public class XurrentJsonConverterFactorySpecs
    {
        [Fact]
        public void CanConvert_ReturnsTrue_ForDateTimeAndTimeSpan()
        {
            XurrentJsonConverterFactory factory = new();

            Assert.True(factory.CanConvert(typeof(DateTime)));
            Assert.True(factory.CanConvert(typeof(DateTime?)));
            Assert.True(factory.CanConvert(typeof(TimeSpan)));
            Assert.True(factory.CanConvert(typeof(TimeSpan?)));
        }

        [Fact]
        public void CanConvert_ReturnsTrue_ForEnums()
        {
            XurrentJsonConverterFactory factory = new();

            Assert.True(factory.CanConvert(typeof(MockCiStatus)));
            Assert.True(factory.CanConvert(typeof(MockCiStatus?)));
        }

        [Fact]
        public void CanConvert_ReturnsTrue_ForClassesWithXurrentFields()
        {
            XurrentJsonConverterFactory factory = new();

            Assert.True(factory.CanConvert(typeof(MockConfigurationItem)));
        }

        [Fact]
        public void CanConvert_ReturnsTrue_ForInterfacesWithAttribute()
        {
            XurrentJsonConverterFactory factory = new();

            Assert.True(factory.CanConvert(typeof(INode)));
        }

        [Fact]
        public void CanConvert_ReturnsFalse_ForInterfacesWithoutAttribute()
        {
            XurrentJsonConverterFactory factory = new();

            Assert.False(factory.CanConvert(typeof(HashCode)));
        }

        [Fact]
        public void CanConvert_ReturnsFalse_ForOtherTypes()
        {
            XurrentJsonConverterFactory factory = new();

            Assert.False(factory.CanConvert(typeof(string)));
            Assert.False(factory.CanConvert(typeof(int)));
        }

        [Fact]
        public void CreateConverter_ReturnsExpectedConverters()
        {
            Dictionary<string, Type> mappings = new()
            {
                { "MockMutation", typeof(MockConfigurationItem) }
            };

            HashSet<string> fields = new() { "field_a" };

            XurrentJsonConverterFactory defaultFactory = new();
            XurrentJsonConverterFactory interfaceFactory = new(mappings);
            XurrentJsonConverterFactory mutationFactory = new(typeof(MockConfigurationItem), fields);

            Assert.IsType<ISO8601TimestampConverter>(defaultFactory.CreateConverter(typeof(DateTime), new JsonSerializerOptions()));
            Assert.IsType<ISO8601TimestampNullableConverter>(defaultFactory.CreateConverter(typeof(DateTime?), new JsonSerializerOptions()));
            Assert.IsType<ISO8601TimeConverter>(defaultFactory.CreateConverter(typeof(TimeSpan), new JsonSerializerOptions()));
            Assert.IsType<ISO8601TimeNullableConverter>(defaultFactory.CreateConverter(typeof(TimeSpan?), new JsonSerializerOptions()));

            JsonConverter enumConv = defaultFactory.CreateConverter(typeof(MockCiStatus), new JsonSerializerOptions());
            Assert.Equal(typeof(XurrentEnumConverter<MockCiStatus>), enumConv.GetType());

            JsonConverter nullableEnumConv = defaultFactory.CreateConverter(typeof(MockCiStatus?), new JsonSerializerOptions());
            Assert.Equal(typeof(XurrentEnumNullableConverter<MockCiStatus>), nullableEnumConv.GetType());

            JsonConverter objectConv = defaultFactory.CreateConverter(typeof(MockConfigurationItem), new JsonSerializerOptions());
            Assert.Equal(typeof(XurrentObjectConverter<MockConfigurationItem>), objectConv.GetType());

            JsonConverter mutationConv = mutationFactory.CreateConverter(typeof(MockConfigurationItem), new JsonSerializerOptions());
            Assert.Equal(typeof(XurrentMutationContentConverter<MockConfigurationItem>), mutationConv.GetType());

            JsonConverter interfaceConv = interfaceFactory.CreateConverter(typeof(INode), new JsonSerializerOptions());
            Assert.Equal(typeof(XurrentInterfaceConverter<INode>), interfaceConv.GetType());
        }

        [Fact]
        public void CreateConverter_Throws_ForUnsupportedType()
        {
            XurrentJsonConverterFactory factory = new();

            ArgumentException ex = Assert.Throws<ArgumentException>(() =>
                factory.CreateConverter(typeof(string), new JsonSerializerOptions()));

            Assert.Contains("violates the constraint", ex.Message);
        }
    }
}
