namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new workflow type.
    /// </summary>
    internal sealed class WorkflowTypeCreateMutation : Mutation<WorkflowTypeCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTypeCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WorkflowTypeCreateMutation(WorkflowTypeCreateInput data, WorkflowTypeQuery query)
            : base("workflowTypeCreate", "WorkflowTypeCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "workflowType")))
        {
        }
    }
}
