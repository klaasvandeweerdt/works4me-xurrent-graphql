namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing workflow type.
    /// </summary>
    internal sealed class WorkflowTypeUpdateMutation : Mutation<WorkflowTypeUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTypeUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the workflow type mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WorkflowTypeUpdateMutation(WorkflowTypeUpdateInput data, WorkflowTypeQuery query)
            : base("workflowTypeUpdate", "WorkflowTypeUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "workflowType")))
        {
        }
    }
}
