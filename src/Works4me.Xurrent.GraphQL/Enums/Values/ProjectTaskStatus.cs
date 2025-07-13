using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The project task status values.
    /// </summary>
    public enum ProjectTaskStatus
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [XurrentEnum("accepted")]
        Accepted,

        /// <summary>
        /// Approved.
        /// </summary>
        [XurrentEnum("approved")]
        Approved,

        /// <summary>
        /// Assigned.
        /// </summary>
        [XurrentEnum("assigned")]
        Assigned,

        /// <summary>
        /// Canceled.
        /// </summary>
        [XurrentEnum("canceled")]
        Canceled,

        /// <summary>
        /// Completed.
        /// </summary>
        [XurrentEnum("completed")]
        Completed,

        /// <summary>
        /// Failed.
        /// </summary>
        [XurrentEnum("failed")]
        Failed,

        /// <summary>
        /// In progress.
        /// </summary>
        [XurrentEnum("in_progress")]
        InProgress,

        /// <summary>
        /// Registered.
        /// </summary>
        [XurrentEnum("registered")]
        Registered,

        /// <summary>
        /// Rejected.
        /// </summary>
        [XurrentEnum("rejected")]
        Rejected,

        /// <summary>
        /// Waiting for.
        /// </summary>
        [XurrentEnum("waiting_for")]
        WaitingFor
    }
}
