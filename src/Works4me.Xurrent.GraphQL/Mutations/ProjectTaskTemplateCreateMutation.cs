namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new project task template.
    /// </summary>
    internal sealed class ProjectTaskTemplateCreateMutation : Mutation<ProjectTaskTemplateCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskTemplateCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectTaskTemplateCreateMutation(ProjectTaskTemplateCreateInput data, ProjectTaskTemplateQuery query)
            : base("projectTaskTemplateCreate", "ProjectTaskTemplateCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectTaskTemplate")))
        {
        }
    }
}
