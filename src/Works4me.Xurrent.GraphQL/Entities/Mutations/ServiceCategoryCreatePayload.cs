using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/servicecategorycreatepayload/">ServiceCategoryCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ServiceCategoryCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("serviceCategory", IsDefaultQueryProperty = true)]
        public ServiceCategory? ServiceCategory { get; internal set; }
    }
}
