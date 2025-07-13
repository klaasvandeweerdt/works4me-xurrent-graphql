using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/productupdatepayload/">ProductUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProductUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("product", IsDefaultQueryProperty = true)]
        public Product? Product { get; internal set; }
    }
}
