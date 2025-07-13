namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing project template.
    /// </summary>
    internal sealed class ProjectTemplateUpdateMutation : Mutation<ProjectTemplateUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplateUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectTemplateUpdateMutation(ProjectTemplateUpdateInput data, ProjectTemplateQuery query)
            : base("projectTemplateUpdate", "ProjectTemplateUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectTemplate")))
        {
        }
    }
}
