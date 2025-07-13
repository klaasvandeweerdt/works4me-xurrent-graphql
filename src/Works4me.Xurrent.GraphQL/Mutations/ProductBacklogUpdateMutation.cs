namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing product backlog.
    /// </summary>
    internal sealed class ProductBacklogUpdateMutation : Mutation<ProductBacklogUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBacklogUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the product backlog mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProductBacklogUpdateMutation(ProductBacklogUpdateInput data, ProductBacklogQuery query)
            : base("productBacklogUpdate", "ProductBacklogUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "productBacklog")))
        {
        }
    }
}
