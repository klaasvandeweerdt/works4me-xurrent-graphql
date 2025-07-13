using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The request status values.
    /// </summary>
    public enum RequestStatus
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [XurrentEnum("accepted")]
        Accepted,

        /// <summary>
        /// Assigned.
        /// </summary>
        [XurrentEnum("assigned")]
        Assigned,

        /// <summary>
        /// Completed.
        /// </summary>
        [XurrentEnum("completed")]
        Completed,

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
        /// Project pending.
        /// </summary>
        [XurrentEnum("project_pending")]
        ProjectPending,

        /// <summary>
        /// Reservation pending.
        /// </summary>
        [XurrentEnum("reservation_pending")]
        ReservationPending,

        /// <summary>
        /// Waiting for.
        /// </summary>
        [XurrentEnum("waiting_for")]
        WaitingFor,

        /// <summary>
        /// Waiting for customer.
        /// </summary>
        [XurrentEnum("waiting_for_customer")]
        WaitingForCustomer,

        /// <summary>
        /// Workflow pending.
        /// </summary>
        [XurrentEnum("workflow_pending")]
        WorkflowPending
    }
}
