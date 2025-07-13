namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new project task.
    /// </summary>
    internal sealed class ProjectTaskCreateMutation : Mutation<ProjectTaskCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectTaskCreateMutation(ProjectTaskCreateInput data, ProjectTaskQuery query)
            : base("projectTaskCreate", "ProjectTaskCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectTask")))
        {
        }
    }
}
