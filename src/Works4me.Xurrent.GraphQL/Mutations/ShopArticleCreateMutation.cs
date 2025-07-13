namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new shop article.
    /// </summary>
    internal sealed class ShopArticleCreateMutation : Mutation<ShopArticleCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ShopArticleCreateMutation(ShopArticleCreateInput data, ShopArticleQuery query)
            : base("shopArticleCreate", "ShopArticleCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "shopArticle")))
        {
        }
    }
}
