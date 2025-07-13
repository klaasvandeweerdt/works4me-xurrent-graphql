using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ParentServiceInstance">ParentServiceInstance</see> fields.
    /// </summary>
    public enum ParentServiceInstanceField
    {
        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The impact relation field.
        /// </summary>
        [XurrentEnum("impactRelation")]
        ImpactRelation,

        /// <summary>
        /// The service instance field.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance
    }
}
