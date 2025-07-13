using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The project completion reason values.
    /// </summary>
    public enum ProjectCompletionReason
    {
        /// <summary>
        /// Abandoned not implemented.
        /// </summary>
        [XurrentEnum("abandoned")]
        Abandoned,

        /// <summary>
        /// Complete fully implemented.
        /// </summary>
        [XurrentEnum("complete")]
        Complete,

        /// <summary>
        /// Partial not entirely implemented.
        /// </summary>
        [XurrentEnum("partial")]
        Partial,

        /// <summary>
        /// Rejected rejected by approver.
        /// </summary>
        [XurrentEnum("rejected")]
        Rejected,

        /// <summary>
        /// Withdrawn withdrawn by requester.
        /// </summary>
        [XurrentEnum("withdrawn")]
        Withdrawn
    }
}
