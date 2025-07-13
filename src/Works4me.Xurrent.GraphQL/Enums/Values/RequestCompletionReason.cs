using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The request completion reason values.
    /// </summary>
    public enum RequestCompletionReason
    {
        /// <summary>
        /// Conflict in conflict with internal standard or policy.
        /// </summary>
        [XurrentEnum("conflict")]
        Conflict,

        /// <summary>
        /// Declined declined by service provider.
        /// </summary>
        [XurrentEnum("declined")]
        Declined,

        /// <summary>
        /// Duplicate same as another request of customer.
        /// </summary>
        [XurrentEnum("duplicate")]
        Duplicate,

        /// <summary>
        /// Gone issue can no longer be found.
        /// </summary>
        [XurrentEnum("gone")]
        Gone,

        /// <summary>
        /// No reply no reply received from customer.
        /// </summary>
        [XurrentEnum("no_reply")]
        NoReply,

        /// <summary>
        /// Rejected rejected by approver.
        /// </summary>
        [XurrentEnum("rejected")]
        Rejected,

        /// <summary>
        /// Solved review not required.
        /// </summary>
        [XurrentEnum("solved")]
        Solved,

        /// <summary>
        /// Unsolvable unable to solve.
        /// </summary>
        [XurrentEnum("unsolvable")]
        Unsolvable,

        /// <summary>
        /// Withdrawn withdrawn by requester.
        /// </summary>
        [XurrentEnum("withdrawn")]
        Withdrawn,

        /// <summary>
        /// Workaround review required.
        /// </summary>
        [XurrentEnum("workaround")]
        Workaround
    }
}
