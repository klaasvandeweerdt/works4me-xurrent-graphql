namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new product category.
    /// </summary>
    internal sealed class ProductCategoryCreateMutation : Mutation<ProductCategoryCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategoryCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the product category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProductCategoryCreateMutation(ProductCategoryCreateInput data, ProductCategoryQuery query)
            : base("productCategoryCreate", "ProductCategoryCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "productCategory")))
        {
        }
    }
}
