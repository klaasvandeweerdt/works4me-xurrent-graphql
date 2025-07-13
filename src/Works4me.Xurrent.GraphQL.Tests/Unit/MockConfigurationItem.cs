using System;
using System.Collections.Generic;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL.Tests.Unit
{
    [XurrentEntity("mockConfigurationItem")]
    internal class MockConfigurationItem : IDataItem
    {
        public bool MergeCalled { get; private set; }

        [XurrentField("id")]
        public string Id { get; set; }

        [XurrentField("name")]
        public string? Name { get; set; }

        [XurrentField("nrOfCores")]
        public long? NrOfCores { get; set; }

        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; set; }

        public string? UnknownField { get; set; }

        public MockConfigurationItem()
        {
            Id = string.Empty;
        }

        public MockConfigurationItem(string id)
        {
            Id = id;
        }


        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        void IDataItem.MergeConnectionData(IDataItem data)
        {
            MergeCalled = true;
        }

        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return new List<ExecutionPageInfo>
            {
                new("field", depth, "cursor", true)
            };
        }

        public string GetMergeKey()
        {
            return ((IDataItem)this).GetMergeKey();
        }

        public void MergeConnectionData(IDataItem data)
        {
            ((IDataItem)this).MergeConnectionData(data);
        }

        public IEnumerable<ExecutionPageInfo> GetPageInfo(int depth)
        {
            return ((IDataItem)this).GetPageInfo(depth);
        }
    }
}
