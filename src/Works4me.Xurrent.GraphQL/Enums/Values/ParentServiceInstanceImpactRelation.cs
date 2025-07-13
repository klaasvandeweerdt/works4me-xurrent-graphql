using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The parent service instance impact relation values.
    /// </summary>
    public enum ParentServiceInstanceImpactRelation
    {
        /// <summary>
        /// Degraded if service instance of sla is down or degraded.
        /// </summary>
        [XurrentEnum("degraded")]
        Degraded,

        /// <summary>
        /// Down if service instance of sla is down.
        /// </summary>
        [XurrentEnum("down")]
        Down
    }
}
