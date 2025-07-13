namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing shop order line.
    /// </summary>
    internal sealed class ShopOrderLineUpdateMutation : Mutation<ShopOrderLineUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopOrderLineUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ShopOrderLineUpdateMutation(ShopOrderLineUpdateInput data, ShopOrderLineQuery query)
            : base("shopOrderLineUpdate", "ShopOrderLineUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "shopOrderLine")))
        {
        }
    }
}
