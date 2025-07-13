using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The request major incident status values.
    /// </summary>
    public enum RequestMajorIncidentStatus
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [XurrentEnum("accepted")]
        Accepted,

        /// <summary>
        /// Canceled.
        /// </summary>
        [XurrentEnum("canceled")]
        Canceled,

        /// <summary>
        /// Proposed.
        /// </summary>
        [XurrentEnum("proposed")]
        Proposed,

        /// <summary>
        /// Rejected.
        /// </summary>
        [XurrentEnum("rejected")]
        Rejected,

        /// <summary>
        /// Resolved.
        /// </summary>
        [XurrentEnum("resolved")]
        Resolved
    }
}
