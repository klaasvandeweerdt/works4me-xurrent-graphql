namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing workflow template.
    /// </summary>
    internal sealed class WorkflowTemplateUpdateMutation : Mutation<WorkflowTemplateUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTemplateUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WorkflowTemplateUpdateMutation(WorkflowTemplateUpdateInput data, WorkflowTemplateQuery query)
            : base("workflowTemplateUpdate", "WorkflowTemplateUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "workflowTemplate")))
        {
        }
    }
}
