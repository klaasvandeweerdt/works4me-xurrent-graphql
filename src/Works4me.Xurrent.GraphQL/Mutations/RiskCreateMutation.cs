namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new risk.
    /// </summary>
    internal sealed class RiskCreateMutation : Mutation<RiskCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the risk mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal RiskCreateMutation(RiskCreateInput data, RiskQuery query)
            : base("riskCreate", "RiskCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "risk")))
        {
        }
    }
}
