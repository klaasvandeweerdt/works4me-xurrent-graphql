namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new shop order line.
    /// </summary>
    internal sealed class ShopOrderLineCreateMutation : Mutation<ShopOrderLineCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopOrderLineCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the shop order line mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ShopOrderLineCreateMutation(ShopOrderLineCreateInput data, ShopOrderLineQuery query)
            : base("shopOrderLineCreate", "ShopOrderLineCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "shopOrderLine")))
        {
        }
    }
}
