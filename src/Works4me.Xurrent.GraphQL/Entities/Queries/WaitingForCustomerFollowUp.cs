using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/waitingforcustomerfollowup/">WaitingForCustomerFollowUp</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("WaitingForCustomerFollowUp")]
    public sealed class WaitingForCustomerFollowUp : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Auto-complete when the final waiting for customer follow-up notification is sent.
        /// </summary>
        [XurrentField("autoComplete")]
        public bool? AutoComplete { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the waiting for customer follow-up may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The name of the waiting for customer follow-up.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        [XurrentField("waitingForCustomerRules")]
        internal PagedResponse<WaitingForCustomerRule>? WaitingForCustomerRulesCollection { get; set; }
        /// <summary>
        /// Rules of the waiting for customer follow-up.
        /// </summary>
        public ReadOnlyDataCollection<WaitingForCustomerRule>? WaitingForCustomerRules { get => WaitingForCustomerRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<WaitingForCustomerRule>(WaitingForCustomerRulesCollection.Data); }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is WaitingForCustomerFollowUp waitingForCustomerFollowUp)
            {
                WaitingForCustomerRulesCollection?.Data?.AddRange(waitingForCustomerFollowUp.WaitingForCustomerRules);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (WaitingForCustomerRulesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in WaitingForCustomerRulesCollection.GetPageInfo("waitingForCustomerRules", depth))
                    yield return pageInfo;
        }
    }
}
