namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new project risk level.
    /// </summary>
    internal sealed class ProjectRiskLevelCreateMutation : Mutation<ProjectRiskLevelCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRiskLevelCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the project risk level mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProjectRiskLevelCreateMutation(ProjectRiskLevelCreateInput data, ProjectRiskLevelQuery query)
            : base("projectRiskLevelCreate", "ProjectRiskLevelCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "projectRiskLevel")))
        {
        }
    }
}
