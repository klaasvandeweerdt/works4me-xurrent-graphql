namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing SLA coverage group.
    /// </summary>
    internal sealed class SlaCoverageGroupUpdateMutation : Mutation<SlaCoverageGroupUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlaCoverageGroupUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the sla coverage group mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SlaCoverageGroupUpdateMutation(SlaCoverageGroupUpdateInput data, SlaCoverageGroupQuery query)
            : base("slaCoverageGroupUpdate", "SlaCoverageGroupUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "slaCoverageGroup")))
        {
        }
    }
}
