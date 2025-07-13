using System;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttaskassignmentinput/">ProjectTaskAssignmentInput</see> in Xurrent.
    /// </summary>
    public sealed class ProjectTaskAssignmentInput : PropertyChangeSet
    {
        private string? _id;
        private string? _assigneeId;
        private long? _plannedEffort;
        private ProjectTaskStatus? _status;
        private DateTime? _waitingUntil;

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
        /// Identifier of the person who is selected as the assignee for the assignment.
        /// </summary>
        [XurrentField("assigneeId")]
        public string? AssigneeId
        {
            get => _assigneeId;
            set => _assigneeId = Set("assigneeId", value);
        }

        /// <summary>
        /// The number of minutes the assignee is expected to spend working on the project task to which the assignment belongs.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort
        {
            get => _plannedEffort;
            set => _plannedEffort = Set("plannedEffort", value);
        }

        /// <summary>
        /// The status of the assignment.
        /// </summary>
        [XurrentField("status")]
        public ProjectTaskStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// Used to specify the date and time at which the status of the assignment is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => _waitingUntil;
            set => _waitingUntil = Set("waitingUntil", value);
        }
    }
}
