namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing project task template.
    /// </summary>
    internal sealed class ProjectTaskTemplateUpdateMutation : Mutation<ProjectTaskTemplateUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskTemplateUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectTaskTemplateUpdateMutation(ProjectTaskTemplateUpdateInput data, ProjectTaskTemplateQuery query)
            : base("projectTaskTemplateUpdate", "ProjectTaskTemplateUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectTaskTemplate")))
        {
        }
    }
}
