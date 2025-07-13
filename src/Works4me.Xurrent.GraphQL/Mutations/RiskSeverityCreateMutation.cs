namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new risk severity.
    /// </summary>
    internal sealed class RiskSeverityCreateMutation : Mutation<RiskSeverityCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskSeverityCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the risk severity mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal RiskSeverityCreateMutation(RiskSeverityCreateInput data, RiskSeverityQuery query)
            : base("riskSeverityCreate", "RiskSeverityCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "riskSeverity")))
        {
        }
    }
}
