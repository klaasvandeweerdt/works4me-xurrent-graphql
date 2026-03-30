using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The ci staged change status values.
    /// </summary>
    public enum CiStagedChangeStatus
    {
        /// <summary>
        /// Approved.
        /// </summary>
        [XurrentEnum("approved")]
        Approved,

        /// <summary>
        /// Pending.
        /// </summary>
        [XurrentEnum("pending")]
        Pending,

        /// <summary>
        /// Rejected.
        /// </summary>
        [XurrentEnum("rejected")]
        Rejected,

        /// <summary>
        /// Superseded.
        /// </summary>
        [XurrentEnum("superseded")]
        Superseded
    }
}
