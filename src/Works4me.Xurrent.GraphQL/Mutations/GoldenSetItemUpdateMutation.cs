namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing golden set item.
    /// </summary>
    internal sealed class GoldenSetItemUpdateMutation : Mutation<GoldenSetItemUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldenSetItemUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal GoldenSetItemUpdateMutation(GoldenSetItemUpdateInput data, GoldenSetItemQuery query)
            : base("goldenSetItemUpdate", "GoldenSetItemUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "goldenSetItem")))
        {
        }
    }
}
