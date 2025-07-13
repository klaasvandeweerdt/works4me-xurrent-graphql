namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new product backlog.
    /// </summary>
    internal sealed class ProductBacklogCreateMutation : Mutation<ProductBacklogCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBacklogCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProductBacklogCreateMutation(ProductBacklogCreateInput data, ProductBacklogQuery query)
            : base("productBacklogCreate", "ProductBacklogCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "productBacklog")))
        {
        }
    }
}
