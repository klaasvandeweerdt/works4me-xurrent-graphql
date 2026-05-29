namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new golden set item.
    /// </summary>
    internal sealed class GoldenSetItemCreateMutation : Mutation<GoldenSetItemCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldenSetItemCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the golden set item mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal GoldenSetItemCreateMutation(GoldenSetItemCreateInput data, GoldenSetItemQuery query)
            : base("goldenSetItemCreate", "GoldenSetItemCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "goldenSetItem")))
        {
        }
    }
}
