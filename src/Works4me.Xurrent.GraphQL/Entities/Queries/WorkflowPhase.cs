using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflowphase/">WorkflowPhase</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("WorkflowPhase")]
    public sealed class WorkflowPhase : IDataItem, INode
    {
        /// <summary>
        /// The date and time at which the workflow phase was set to the status "Completed".
        /// </summary>
        [XurrentField("completedAt")]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the workflow phase was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The name of the workflow phase.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the workflow phase takes when it is presented in the workflow's Gantt chart.
        /// </summary>
        [XurrentField("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// Indicates the date and time at which the first workflow task of the phase was set to a status other than <c>registered</c> or <c>canceled</c>.
        /// </summary>
        [XurrentField("startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// The current status of the workflow phase.
        /// </summary>
        [XurrentField("status")]
        public WorkflowPhaseStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the workflow phase. If the phase has no updates it contains the <c>createdAt</c> value.
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
