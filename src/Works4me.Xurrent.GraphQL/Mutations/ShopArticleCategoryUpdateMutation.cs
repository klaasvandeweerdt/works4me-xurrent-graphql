namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing shop article category.
    /// </summary>
    internal sealed class ShopArticleCategoryUpdateMutation : Mutation<ShopArticleCategoryUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCategoryUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ShopArticleCategoryUpdateMutation(ShopArticleCategoryUpdateInput data, ShopArticleCategoryQuery query)
            : base("shopArticleCategoryUpdate", "ShopArticleCategoryUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "shopArticleCategory")))
        {
        }
    }
}
