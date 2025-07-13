namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new project.
    /// </summary>
    internal sealed class ProjectCreateMutation : Mutation<ProjectCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectCreateMutation(ProjectCreateInput data, ProjectQuery query)
            : base("projectCreate", "ProjectCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "project")))
        {
        }
    }
}
