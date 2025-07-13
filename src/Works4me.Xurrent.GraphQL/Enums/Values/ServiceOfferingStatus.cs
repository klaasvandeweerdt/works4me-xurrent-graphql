using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The service offering status values.
    /// </summary>
    public enum ServiceOfferingStatus
    {
        /// <summary>
        /// Available.
        /// </summary>
        [XurrentEnum("available")]
        Available,

        /// <summary>
        /// Discontinued.
        /// </summary>
        [XurrentEnum("discontinued")]
        Discontinued,

        /// <summary>
        /// Planned.
        /// </summary>
        [XurrentEnum("planned")]
        Planned,

        /// <summary>
        /// Temporarily unavailable.
        /// </summary>
        [XurrentEnum("temporarily_unavailable")]
        TemporarilyUnavailable,

        /// <summary>
        /// Unpublished.
        /// </summary>
        [XurrentEnum("unpublished")]
        Unpublished
    }
}
