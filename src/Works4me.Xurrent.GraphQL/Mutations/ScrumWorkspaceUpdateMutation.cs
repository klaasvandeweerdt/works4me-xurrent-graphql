namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing scrum workspace.
    /// </summary>
    internal sealed class ScrumWorkspaceUpdateMutation : Mutation<ScrumWorkspaceUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrumWorkspaceUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ScrumWorkspaceUpdateMutation(ScrumWorkspaceUpdateInput data, ScrumWorkspaceQuery query)
            : base("scrumWorkspaceUpdate", "ScrumWorkspaceUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "scrumWorkspace")))
        {
        }
    }
}
