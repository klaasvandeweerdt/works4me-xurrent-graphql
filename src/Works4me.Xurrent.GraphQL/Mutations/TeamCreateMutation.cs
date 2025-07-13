namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new team.
    /// </summary>
    internal sealed class TeamCreateMutation : Mutation<TeamCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the team mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TeamCreateMutation(TeamCreateInput data, TeamQuery query)
            : base("teamCreate", "TeamCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "team")))
        {
        }
    }
}
