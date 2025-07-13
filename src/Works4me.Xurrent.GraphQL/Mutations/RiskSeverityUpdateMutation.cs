namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing risk severity.
    /// </summary>
    internal sealed class RiskSeverityUpdateMutation : Mutation<RiskSeverityUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskSeverityUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal RiskSeverityUpdateMutation(RiskSeverityUpdateInput data, RiskSeverityQuery query)
            : base("riskSeverityUpdate", "RiskSeverityUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "riskSeverity")))
        {
        }
    }
}
