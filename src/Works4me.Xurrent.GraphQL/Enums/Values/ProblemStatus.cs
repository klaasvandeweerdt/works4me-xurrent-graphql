using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The problem status values.
    /// </summary>
    public enum ProblemStatus
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [XurrentEnum("accepted")]
        Accepted,

        /// <summary>
        /// Analyzed.
        /// </summary>
        [XurrentEnum("analyzed")]
        Analyzed,

        /// <summary>
        /// Assigned.
        /// </summary>
        [XurrentEnum("assigned")]
        Assigned,

        /// <summary>
        /// Change requested.
        /// </summary>
        [XurrentEnum("change_requested")]
        ChangeRequested,

        /// <summary>
        /// Declined.
        /// </summary>
        [XurrentEnum("declined")]
        Declined,

        /// <summary>
        /// In progress.
        /// </summary>
        [XurrentEnum("in_progress")]
        InProgress,

        /// <summary>
        /// On backlog.
        /// </summary>
        [XurrentEnum("on_backlog")]
        OnBacklog,

        /// <summary>
        /// Progress halted.
        /// </summary>
        [XurrentEnum("progress_halted")]
        ProgressHalted,

        /// <summary>
        /// Project pending.
        /// </summary>
        [XurrentEnum("project_pending")]
        ProjectPending,

        /// <summary>
        /// Solved.
        /// </summary>
        [XurrentEnum("solved")]
        Solved,

        /// <summary>
        /// Waiting for.
        /// </summary>
        [XurrentEnum("waiting_for")]
        WaitingFor,

        /// <summary>
        /// Workflow pending.
        /// </summary>
        [XurrentEnum("workflow_pending")]
        WorkflowPending
    }
}
