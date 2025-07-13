using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/productcategoryupdatepayload/">ProductCategoryUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ProductCategoryUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("productCategory", IsDefaultQueryProperty = true)]
        public ProductCategory? ProductCategory { get; internal set; }
    }
}
