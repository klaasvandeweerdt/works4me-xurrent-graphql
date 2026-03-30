using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/cistagedchange/">CiStagedChange</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("CiStagedChange")]
    public sealed class CiStagedChange : IDataItem, IHasLifeCycleState, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The automation rule that triggered this staged change.
        /// </summary>
        [XurrentField("automationRule")]
        public AutomationRule? AutomationRule { get; internal set; }

        /// <summary>
        /// The configuration item this staged change proposes to modify.
        /// </summary>
        [XurrentField("ci")]
        public ConfigurationItem? Ci { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The person who initiated the change that was intercepted.
        /// </summary>
        [XurrentField("createdBy")]
        public Person? CreatedBy { get; internal set; }

        /// <summary>
        /// JSON object containing the original values of the configuration item fields at the time the change was staged.
        /// </summary>
        [XurrentField("currentValues")]
        public JsonElement? CurrentValues { get; internal set; }

        /// <summary>
        /// Indicates whether there are differences between the current and proposed values.
        /// </summary>
        [XurrentField("delta")]
        public bool? Delta { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// JSON object containing the proposed changes to the configuration item fields.
        /// </summary>
        [XurrentField("proposedValues")]
        public JsonElement? ProposedValues { get; internal set; }

        /// <summary>
        /// The date and time at which the staged change was reviewed.
        /// </summary>
        [XurrentField("reviewedAt")]
        public DateTime? ReviewedAt { get; internal set; }

        /// <summary>
        /// The person who reviewed this staged change.
        /// </summary>
        [XurrentField("reviewedBy")]
        public Person? ReviewedBy { get; internal set; }

        /// <summary>
        /// Note from the reviewer explaining the approval or rejection decision.
        /// </summary>
        [XurrentField("reviewerNote")]
        public string? ReviewerNote { get; internal set; }

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
        /// The current status of the staged change (pending, approved, or rejected).
        /// </summary>
        [XurrentField("status")]
        public CiStagedChangeStatus? Status { get; internal set; }

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
