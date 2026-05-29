using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/seraaistudio/">SeraAiStudio</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("SeraAiStudio")]
    public sealed class SeraAiStudio : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Instructions for the virtual agent in markdown format.
        /// </summary>
        [XurrentField("agentInstructions")]
        public string? AgentInstructions { get; internal set; }

        /// <summary>
        /// The most recently submitted agent instructions awaiting validation. Present only while a verdict is pending or after a non-approved verdict.
        /// </summary>
        [XurrentField("agentInstructionsDraft")]
        public string? AgentInstructionsDraft { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        [XurrentField("goldenSetItems")]
        internal PagedResponse<GoldenSetItem>? GoldenSetItemsCollection { get; set; }
        /// <summary>
        /// Golden set test cases that benchmark the studio's search quality.
        /// </summary>
        public ReadOnlyDataCollection<GoldenSetItem>? GoldenSetItems { get => GoldenSetItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<GoldenSetItem>(GoldenSetItemsCollection.Data); }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Default "Run as" user pre-filled in the user column when adding new golden set rows.
        /// </summary>
        [XurrentField("runAs")]
        public Person? RunAs { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The reasoning provided by the validation service when instructions are partially applied or rejected.
        /// </summary>
        [XurrentField("validationReasoning")]
        public string? ValidationReasoning { get; internal set; }

        /// <summary>
        /// The validation status of the agent instructions. Valid values are: <c>pending</c>, <c>approved</c>, <c>partially_applied</c>, <c>rejected</c>, <c>error</c>.
        /// </summary>
        [XurrentField("validationStatus")]
        public string? ValidationStatus { get; internal set; }

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
            if (data is SeraAiStudio seraAiStudio)
            {
                GoldenSetItemsCollection?.Data?.AddRange(seraAiStudio.GoldenSetItems);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (GoldenSetItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in GoldenSetItemsCollection.GetPageInfo("goldenSetItems", depth))
                    yield return pageInfo;
        }
    }
}
