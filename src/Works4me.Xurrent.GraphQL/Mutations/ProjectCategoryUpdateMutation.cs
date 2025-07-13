namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing project category.
    /// </summary>
    internal sealed class ProjectCategoryUpdateMutation : Mutation<ProjectCategoryUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCategoryUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectCategoryUpdateMutation(ProjectCategoryUpdateInput data, ProjectCategoryQuery query)
            : base("projectCategoryUpdate", "ProjectCategoryUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectCategory")))
        {
        }
    }
}
