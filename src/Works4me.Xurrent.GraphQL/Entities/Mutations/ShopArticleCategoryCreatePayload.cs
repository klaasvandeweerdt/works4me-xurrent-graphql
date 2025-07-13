using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shoparticlecategorycreatepayload/">ShopArticleCategoryCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ShopArticleCategoryCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("shopArticleCategory", IsDefaultQueryProperty = true)]
        public ShopArticleCategory? ShopArticleCategory { get; internal set; }
    }
}
