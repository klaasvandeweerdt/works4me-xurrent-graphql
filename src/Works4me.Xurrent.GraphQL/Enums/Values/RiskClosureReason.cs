using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The risk closure reason values.
    /// </summary>
    public enum RiskClosureReason
    {
        /// <summary>
        /// Accepted risk level accepted.
        /// </summary>
        [XurrentEnum("accepted")]
        Accepted,

        /// <summary>
        /// Eliminated risk completely eliminated.
        /// </summary>
        [XurrentEnum("eliminated")]
        Eliminated,

        /// <summary>
        /// Mitigated risk reduced to acceptable level.
        /// </summary>
        [XurrentEnum("mitigated")]
        Mitigated,

        /// <summary>
        /// No risk assessment found no risk.
        /// </summary>
        [XurrentEnum("no_risk")]
        NoRisk,

        /// <summary>
        /// Transferred risk transferred to another organization.
        /// </summary>
        [XurrentEnum("transferred")]
        Transferred
    }
}
