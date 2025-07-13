namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing team.
    /// </summary>
    internal sealed class TeamUpdateMutation : Mutation<TeamUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TeamUpdateMutation(TeamUpdateInput data, TeamQuery query)
            : base("teamUpdate", "TeamUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "team")))
        {
        }
    }
}
