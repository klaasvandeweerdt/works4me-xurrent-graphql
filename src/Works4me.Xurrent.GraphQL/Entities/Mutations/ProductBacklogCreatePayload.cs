using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/productbacklogcreatepayload/">ProductBacklogCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProductBacklogCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("productBacklog", IsDefaultQueryProperty = true)]
        public ProductBacklog? ProductBacklog { get; internal set; }
    }
}
