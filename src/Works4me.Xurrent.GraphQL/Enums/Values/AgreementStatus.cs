using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The agreement status values.
    /// </summary>
    public enum AgreementStatus
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
        /// Expired.
        /// </summary>
        [XurrentEnum("expired")]
        Expired,

        /// <summary>
        /// Scheduled for activation.
        /// </summary>
        [XurrentEnum("scheduled_for_activation")]
        ScheduledForActivation
    }
}
