using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/goldensetitem/">GoldenSetItem</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("GoldenSetItem")]
    public sealed class GoldenSetItem : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Text the virtual agent returned during the most recent run.
        /// </summary>
        [XurrentField("aiResponse")]
        public string? AiResponse { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The Knowledge Article or Request Template the agent is expected to surface.
        /// </summary>
        [XurrentField("expectedHit")]
        public IHasGoldenSetExpectedHits? ExpectedHit { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Free-text search prompt sent to the virtual agent during evaluation.
        /// </summary>
        [XurrentField("promptQuery")]
        public string? PromptQuery { get; internal set; }

        /// <summary>
        /// Person whose role and locale the evaluation impersonates.
        /// </summary>
        [XurrentField("runAs")]
        public Person? RunAs { get; internal set; }

        /// <summary>
        /// Score of the most recent run. <c>100</c> when the agent surfaced the expected hit, <c>0</c> when it did not, <c>null</c> if the item has never been evaluated.
        /// </summary>
        [XurrentField("score")]
        public long? Score { get; internal set; }

        /// <summary>
        /// Sera AI Studio that owns this golden set item.
        /// </summary>
        [XurrentField("seraAiStudio")]
        public SeraAiStudio? SeraAiStudio { get; internal set; }

        /// <summary>
        /// Timestamp at which the most recent run began. Null while the item is <c>pending</c>.
        /// </summary>
        [XurrentField("startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// Lifecycle state of the most recent run.
        /// </summary>
        [XurrentField("status")]
        public GoldenSetItemStatus? Status { get; internal set; }

        /// <summary>
        /// Wall-clock duration of the most recent run, in seconds.
        /// </summary>
        [XurrentField("timeTaken")]
        public decimal? TimeTaken { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

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
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
