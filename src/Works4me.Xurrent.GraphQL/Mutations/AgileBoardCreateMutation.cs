namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new agile board.
    /// </summary>
    internal sealed class AgileBoardCreateMutation : Mutation<AgileBoardCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgileBoardCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the agile board mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AgileBoardCreateMutation(AgileBoardCreateInput data, AgileBoardQuery query)
            : base("agileBoardCreate", "AgileBoardCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "agileBoard")))
        {
        }
    }
}
