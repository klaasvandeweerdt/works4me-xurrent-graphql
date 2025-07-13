namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new product.
    /// </summary>
    internal sealed class ProductCreateMutation : Mutation<ProductCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the product mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProductCreateMutation(ProductCreateInput data, ProductQuery query)
            : base("productCreate", "ProductCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "product")))
        {
        }
    }
}
