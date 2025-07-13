using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/serviceinstancecreatepayload/">ServiceInstanceCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ServiceInstanceCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("serviceInstance", IsDefaultQueryProperty = true)]
        public ServiceInstance? ServiceInstance { get; internal set; }
    }
}
