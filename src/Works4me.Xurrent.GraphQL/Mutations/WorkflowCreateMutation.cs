namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new workflow.
    /// </summary>
    internal sealed class WorkflowCreateMutation : Mutation<WorkflowCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the workflow mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WorkflowCreateMutation(WorkflowCreateInput data, WorkflowQuery query)
            : base("workflowCreate", "WorkflowCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "workflow")))
        {
        }
    }
}
