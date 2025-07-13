namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing project risk level.
    /// </summary>
    internal sealed class ProjectRiskLevelUpdateMutation : Mutation<ProjectRiskLevelUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRiskLevelUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectRiskLevelUpdateMutation(ProjectRiskLevelUpdateInput data, ProjectRiskLevelQuery query)
            : base("projectRiskLevelUpdate", "ProjectRiskLevelUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectRiskLevel")))
        {
        }
    }
}
