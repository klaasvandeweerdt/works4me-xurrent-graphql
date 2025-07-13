namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing agile board.
    /// </summary>
    internal sealed class AgileBoardUpdateMutation : Mutation<AgileBoardUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgileBoardUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AgileBoardUpdateMutation(AgileBoardUpdateInput data, AgileBoardQuery query)
            : base("agileBoardUpdate", "AgileBoardUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "agileBoard")))
        {
        }
    }
}
