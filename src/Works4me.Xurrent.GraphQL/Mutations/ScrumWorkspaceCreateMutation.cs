namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new scrum workspace.
    /// </summary>
    internal sealed class ScrumWorkspaceCreateMutation : Mutation<ScrumWorkspaceCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrumWorkspaceCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the scrum workspace mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ScrumWorkspaceCreateMutation(ScrumWorkspaceCreateInput data, ScrumWorkspaceQuery query)
            : base("scrumWorkspaceCreate", "ScrumWorkspaceCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "scrumWorkspace")))
        {
        }
    }
}
