namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new shop article category.
    /// </summary>
    internal sealed class ShopArticleCategoryCreateMutation : Mutation<ShopArticleCategoryCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCategoryCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the shop article category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ShopArticleCategoryCreateMutation(ShopArticleCategoryCreateInput data, ShopArticleCategoryQuery query)
            : base("shopArticleCategoryCreate", "ShopArticleCategoryCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "shopArticleCategory")))
        {
        }
    }
}
