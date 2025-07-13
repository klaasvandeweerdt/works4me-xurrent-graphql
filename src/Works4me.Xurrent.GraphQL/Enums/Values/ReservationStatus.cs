using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The reservation status values.
    /// </summary>
    public enum ReservationStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [XurrentEnum("active")]
        Active,

        /// <summary>
        /// Being prepared.
        /// </summary>
        [XurrentEnum("being_prepared")]
        BeingPrepared,

        /// <summary>
        /// Canceled.
        /// </summary>
        [XurrentEnum("canceled")]
        Canceled,

        /// <summary>
        /// Confirmed.
        /// </summary>
        [XurrentEnum("confirmed")]
        Confirmed,

        /// <summary>
        /// Conflicting.
        /// </summary>
        [XurrentEnum("conflicting")]
        Conflicting,

        /// <summary>
        /// Ended.
        /// </summary>
        [XurrentEnum("ended")]
        Ended,

        /// <summary>
        /// Pending.
        /// </summary>
        [XurrentEnum("pending")]
        Pending,

        /// <summary>
        /// Prototype.
        /// </summary>
        [XurrentEnum("prototype")]
        Prototype,

        /// <summary>
        /// Provisional.
        /// </summary>
        [XurrentEnum("provisional")]
        Provisional
    }
}
