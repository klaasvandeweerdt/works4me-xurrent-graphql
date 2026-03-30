namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing CI staged change (approve or reject).
    /// </summary>
    internal sealed class CiStagedChangeUpdateMutation : Mutation<CiStagedChangeUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CiStagedChangeUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the ci staged change mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal CiStagedChangeUpdateMutation(CiStagedChangeUpdateInput data, CiStagedChangeQuery query)
            : base("ciStagedChangeUpdate", "CiStagedChangeUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "ciStagedChange")))
        {
        }
    }
}
