using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/productbacklogupdatepayload/">ProductBacklogUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProductBacklogUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("productBacklog", IsDefaultQueryProperty = true)]
        public ProductBacklog? ProductBacklog { get; internal set; }
    }
}
