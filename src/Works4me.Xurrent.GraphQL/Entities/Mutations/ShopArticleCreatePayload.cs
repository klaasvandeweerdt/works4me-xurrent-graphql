using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shoparticlecreatepayload/">ShopArticleCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ShopArticleCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("shopArticle", IsDefaultQueryProperty = true)]
        public ShopArticle? ShopArticle { get; internal set; }
    }
}
