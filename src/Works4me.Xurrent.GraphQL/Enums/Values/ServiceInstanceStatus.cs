using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The service instance status values.
    /// </summary>
    public enum ServiceInstanceStatus
    {
        /// <summary>
        /// Being prepared.
        /// </summary>
        [XurrentEnum("being_prepared")]
        BeingPrepared,

        /// <summary>
        /// Discontinued.
        /// </summary>
        [XurrentEnum("discontinued")]
        Discontinued,

        /// <summary>
        /// In production.
        /// </summary>
        [XurrentEnum("in_production")]
        InProduction
    }
}
