namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing project.
    /// </summary>
    internal sealed class ProjectUpdateMutation : Mutation<ProjectUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectUpdateMutation(ProjectUpdateInput data, ProjectQuery query)
            : base("projectUpdate", "ProjectUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "project")))
        {
        }
    }
}
