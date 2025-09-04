using System;
using System.Collections.Generic;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Extensions;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Models
{
    public class CustomFieldCollectionSpecs
    {
        [Fact]
        public void Constructor_WithItems_PopulatesCollection()
        {
            List<CustomField> fields = new()
            {
                new CustomField { Id = "a", Value = "test".ToJsonElement() }
            };

            CustomFieldCollection collection = new(fields);

            Assert.True(collection.Contains("a"));
        }

        [Fact]
        public void Indexer_Get_ReturnsValue_WhenExists()
        {
            CustomFieldCollection collection = new()
            {
                { "test", "abc".ToJsonElement() }
            };

            JsonElement? value = collection["test"];

            Assert.True(value.HasValue);
            Assert.Equal("abc", value.GetValue<string>());
        }

        [Fact]
        public void Indexer_Get_ReturnsValue_WhenMissing()
        {
            CustomFieldCollection collection = new();

            JsonElement? value = collection["test"];
            Assert.Null(value);
        }

        [Fact]
        public void Indexer_Set_Updates_WhenExists()
        {
            CustomFieldCollection collection = new()
            {
                { "field1", "old".ToJsonElement() }
            };

            collection["field1"] = "new".ToJsonElement();

            Assert.Equal("new", collection["field1"]!.Value.GetString());
        }

        [Fact]
        public void Indexer_Set_Adds_WhenMissing()
        {
            CustomFieldCollection collection = new()
            {
                ["newField"] = "value".ToJsonElement()
            };

            Assert.True(collection.Contains("newField"));
            Assert.Equal("value", collection["newField"]!.Value.GetString());
        }

        [Fact]
        public void Add_Throws_WhenIdInvalid()
        {
            CustomFieldCollection collection = new();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.Throws<ArgumentException>(() => collection.Add(null, null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.Throws<ArgumentException>(() => collection.Add("", null));
            Assert.Throws<ArgumentException>(() => collection.Add(" ", null));
        }

        [Fact]
        public void TryGetValue_ReturnsCorrectly()
        {
            CustomFieldCollection collection = new()
            {
                { "exists", 123.ToJsonElement() }
            };

            bool found = collection.TryGetValue("exists", out CustomField? field);

            Assert.True(found);
            Assert.NotNull(field);
            Assert.Equal(123, field!.Value!.Value.GetInt32());
        }

        [Fact]
        public void GetKeyForItem_ReturnsId()
        {
            CustomFieldCollection collection = new();

            CustomField field = new() { Id = "myId" };
            string? key = collection.GetType().GetMethod("GetKeyForItem", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
                .Invoke(collection, new object[] { field }) as string;
            Assert.Equal("myId", key);
        }
    }
}
