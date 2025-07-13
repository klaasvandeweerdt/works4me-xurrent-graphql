namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new project template.
    /// </summary>
    internal sealed class ProjectTemplateCreateMutation : Mutation<ProjectTemplateCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplateCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectTemplateCreateMutation(ProjectTemplateCreateInput data, ProjectTemplateQuery query)
            : base("projectTemplateCreate", "ProjectTemplateCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectTemplate")))
        {
        }
    }
}
