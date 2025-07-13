namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing workflow.
    /// </summary>
    internal sealed class WorkflowUpdateMutation : Mutation<WorkflowUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WorkflowUpdateMutation(WorkflowUpdateInput data, WorkflowQuery query)
            : base("workflowUpdate", "WorkflowUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "workflow")))
        {
        }
    }
}
