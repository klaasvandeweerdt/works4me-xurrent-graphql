using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The workflow completion reason values.
    /// </summary>
    public enum WorkflowCompletionReason
    {
        /// <summary>
        /// Complete all requirements met.
        /// </summary>
        [XurrentEnum("complete")]
        Complete,

        /// <summary>
        /// Disruptive caused service disruption.
        /// </summary>
        [XurrentEnum("disruptive")]
        Disruptive,

        /// <summary>
        /// Failed no requirements met.
        /// </summary>
        [XurrentEnum("failed")]
        Failed,

        /// <summary>
        /// Partial not all requirements met.
        /// </summary>
        [XurrentEnum("partial")]
        Partial,

        /// <summary>
        /// Rejected rejected by approver.
        /// </summary>
        [XurrentEnum("rejected")]
        Rejected,

        /// <summary>
        /// Rolled back original environment restored.
        /// </summary>
        [XurrentEnum("rolled_back")]
        RolledBack,

        /// <summary>
        /// Withdrawn withdrawn by requester.
        /// </summary>
        [XurrentEnum("withdrawn")]
        Withdrawn
    }
}
