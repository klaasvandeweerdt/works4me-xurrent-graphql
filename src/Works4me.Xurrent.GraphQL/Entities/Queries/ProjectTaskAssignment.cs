using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttaskassignment/">ProjectTaskAssignment</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ProjectTaskAssignment")]
    public sealed class ProjectTaskAssignment : IDataItem, INode
    {
        /// <summary>
        /// The person who is selected as the assignee for the assignment.
        /// </summary>
        [XurrentField("assignee")]
        public Person? Assignee { get; internal set; }

        /// <summary>
        /// <b>link to Project Summary</b> - The hyperlink to the Project Summary PDF file that was generated for the assignee when the assignment was last set to the status <c>assigned</c> (for project tasks of the category <c>approval</c> only).
        /// </summary>
        [XurrentField("attachment")]
        public string? Attachment { get; internal set; }

        /// <summary>
        /// The date and time at which the assignment was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The number of minutes the assignee is expected to spend working on the project task to which the assignment belongs.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// The status of the assignment.
        /// </summary>
        [XurrentField("status")]
        public ProjectTaskStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the assignment. If the assignment has had no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Used to specify the date and time at which the status of the assignment is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

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
