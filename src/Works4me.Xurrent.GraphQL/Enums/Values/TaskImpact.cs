using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The task impact values.
    /// </summary>
    public enum TaskImpact
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
        /// None service not degraded.
        /// </summary>
        [XurrentEnum("none")]
        None,

        /// <summary>
        /// Top service down for several users.
        /// </summary>
        [XurrentEnum("top")]
        Top
    }
}
