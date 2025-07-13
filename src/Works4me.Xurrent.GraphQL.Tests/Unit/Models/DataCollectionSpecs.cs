using System.Collections.Generic;
using Xunit;

namespace Works4me.Xurrent.GraphQL.Tests.Unit.Models
{
    public class DataCollectionSpecs
    {
        [Fact]
        public void Add_AddsItem_WhenKeyIsUnique()
        {
            DataCollection<MockConfigurationItem> collection = new();

            MockConfigurationItem item = new("key1");

            collection.Add(item);

            Assert.Contains(item, collection);
        }

        [Fact]
        public void Add_MergesItem_WhenKeyExists()
        {
            DataCollection<MockConfigurationItem> collection = new();

            MockConfigurationItem original = new("key1");
            collection.Add(original);

            MockConfigurationItem duplicate = new("key1");
            collection.Add(duplicate);

            Assert.Single(collection);
            Assert.True(original.MergeCalled);
        }

        [Fact]
        public void InsertItem_AddsItem_WhenKeyIsUnique()
        {
            DataCollection<MockConfigurationItem> collection = new();

            MockConfigurationItem item = new("key1");

            collection.Insert(0, item);

            Assert.Contains(item, collection);
        }

        [Fact]
        public void InsertItem_MergesItem_WhenKeyExists()
        {
            DataCollection<MockConfigurationItem> collection = new();

            MockConfigurationItem original = new("key1");
            collection.Add(original);

            MockConfigurationItem duplicate = new("key1");
            collection.Insert(0, duplicate);

            Assert.Single(collection);
            Assert.True(original.MergeCalled);
        }

        [Fact]
        public void AddRange_AddsAndMergesCorrectly()
        {
            DataCollection<MockConfigurationItem> collection = new();

            MockConfigurationItem original = new("key1");
            collection.Add(original);

            List<MockConfigurationItem> items = new()
            {
                new MockConfigurationItem("key2"),
                new MockConfigurationItem("key1"),
                new MockConfigurationItem("key3")
            };

            collection.AddRange(items);

            Assert.Equal(3, collection.Count);
            Assert.True(original.MergeCalled);
        }
    }
}
