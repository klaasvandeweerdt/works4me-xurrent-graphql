using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/tasktemplateapprovalinput/">TaskTemplateApprovalInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class TaskTemplateApprovalInput : PropertyChangeSet
    {
        private string? _id;
        private string? _approverId;
        private long? _plannedEffort;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [XurrentField("id")]
        public string? Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Identifier of the person who is selected as the approver for the approval.
        /// </summary>
        [XurrentField("approverId")]
        public string? ApproverId
        {
            get => _approverId;
            set => _approverId = Set("approverId", value);
        }

        /// <summary>
        /// The number of minutes the approver is expected to spend working on the task.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort
        {
            get => _plannedEffort;
            set => _plannedEffort = Set("plannedEffort", value);
        }
    }
}
