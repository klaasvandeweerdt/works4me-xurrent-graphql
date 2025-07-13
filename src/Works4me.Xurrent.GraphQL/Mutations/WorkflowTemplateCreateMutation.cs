namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new workflow template.
    /// </summary>
    internal sealed class WorkflowTemplateCreateMutation : Mutation<WorkflowTemplateCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTemplateCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the workflow template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WorkflowTemplateCreateMutation(WorkflowTemplateCreateInput data, WorkflowTemplateQuery query)
            : base("workflowTemplateCreate", "WorkflowTemplateCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "workflowTemplate")))
        {
        }
    }
}
