namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing risk.
    /// </summary>
    internal sealed class RiskUpdateMutation : Mutation<RiskUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal RiskUpdateMutation(RiskUpdateInput data, RiskQuery query)
            : base("riskUpdate", "RiskUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "risk")))
        {
        }
    }
}
