using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The request impact values.
    /// </summary>
    public enum RequestImpact
    {
        /// <summary>
        /// High service degraded for several users.
        /// </summary>
        [XurrentEnum("high")]
        High,

        /// <summary>
        /// Low service degraded for one user.
        /// </summary>
        [XurrentEnum("low")]
        Low,

        /// <summary>
        /// Medium service down for one user.
        /// </summary>
        [XurrentEnum("medium")]
        Medium,

        /// <summary>
        /// Top service down for several users.
        /// </summary>
        [XurrentEnum("top")]
        Top
    }
}
