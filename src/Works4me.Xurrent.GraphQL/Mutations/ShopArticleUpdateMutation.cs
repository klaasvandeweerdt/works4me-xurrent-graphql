namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing shop article.
    /// </summary>
    internal sealed class ShopArticleUpdateMutation : Mutation<ShopArticleUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the shop article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ShopArticleUpdateMutation(ShopArticleUpdateInput data, ShopArticleQuery query)
            : base("shopArticleUpdate", "ShopArticleUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "shopArticle")))
        {
        }
    }
}
