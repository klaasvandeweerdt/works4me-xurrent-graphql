namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new project category.
    /// </summary>
    internal sealed class ProjectCategoryCreateMutation : Mutation<ProjectCategoryCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCategoryCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectCategoryCreateMutation(ProjectCategoryCreateInput data, ProjectCategoryQuery query)
            : base("projectCategoryCreate", "ProjectCategoryCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectCategory")))
        {
        }
    }
}
