namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new SLA coverage group.
    /// </summary>
    internal sealed class SlaCoverageGroupCreateMutation : Mutation<SlaCoverageGroupCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlaCoverageGroupCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SlaCoverageGroupCreateMutation(SlaCoverageGroupCreateInput data, SlaCoverageGroupQuery query)
            : base("slaCoverageGroupCreate", "SlaCoverageGroupCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "slaCoverageGroup")))
        {
        }
    }
}
