using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The affected sla accountability values.
    /// </summary>
    public enum AffectedSlaAccountability
    {
        /// <summary>
        /// Provider.
        /// </summary>
        [XurrentEnum("provider")]
        Provider,

        /// <summary>
        /// Sla not affected.
        /// </summary>
        [XurrentEnum("sla_not_affected")]
        SlaNotAffected,

        /// <summary>
        /// Supplier.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier
    }
}
