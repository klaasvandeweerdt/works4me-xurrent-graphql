namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing product.
    /// </summary>
    internal sealed class ProductUpdateMutation : Mutation<ProductUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProductUpdateMutation(ProductUpdateInput data, ProductQuery query)
            : base("productUpdate", "ProductUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "product")))
        {
        }
    }
}
