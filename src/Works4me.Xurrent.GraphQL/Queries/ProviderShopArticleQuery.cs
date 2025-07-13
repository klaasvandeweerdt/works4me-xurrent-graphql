using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProviderShopArticle"/> query class.
    /// </summary>
    public class ProviderShopArticleQuery : Query<ProviderShopArticle, ProviderShopArticleQuery, DefaultView, ProviderShopArticleField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProviderShopArticleQuery"/> instance.
        /// </summary>
        public ProviderShopArticleQuery() : base(string.Empty, false)
        {
        }
    }
}
