using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/serviceofferingcreatepayload/">ServiceOfferingCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ServiceOfferingCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("serviceOffering", IsDefaultQueryProperty = true)]
        public ServiceOffering? ServiceOffering { get; internal set; }
    }
}
