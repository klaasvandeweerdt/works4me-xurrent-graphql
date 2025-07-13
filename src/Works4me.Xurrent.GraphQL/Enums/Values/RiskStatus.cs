using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The risk status values.
    /// </summary>
    public enum RiskStatus
    {
        /// <summary>
        /// Anticipated.
        /// </summary>
        [XurrentEnum("anticipated")]
        Anticipated,

        /// <summary>
        /// Closed.
        /// </summary>
        [XurrentEnum("closed")]
        Closed,

        /// <summary>
        /// Materialized.
        /// </summary>
        [XurrentEnum("materialized")]
        Materialized
    }
}
