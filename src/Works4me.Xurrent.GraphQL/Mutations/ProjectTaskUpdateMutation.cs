namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing project task.
    /// </summary>
    internal sealed class ProjectTaskUpdateMutation : Mutation<ProjectTaskUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectTaskUpdateMutation(ProjectTaskUpdateInput data, ProjectTaskQuery query)
            : base("projectTaskUpdate", "ProjectTaskUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectTask")))
        {
        }
    }
}
