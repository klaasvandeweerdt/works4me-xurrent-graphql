namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing product category.
    /// </summary>
    internal sealed class ProductCategoryUpdateMutation : Mutation<ProductCategoryUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategoryUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProductCategoryUpdateMutation(ProductCategoryUpdateInput data, ProductCategoryQuery query)
            : base("productCategoryUpdate", "ProductCategoryUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "productCategory")))
        {
        }
    }
}
