namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing task template.
    /// </summary>
    internal sealed class WorkflowTaskTemplateUpdateMutation : Mutation<WorkflowTaskTemplateUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTaskTemplateUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WorkflowTaskTemplateUpdateMutation(WorkflowTaskTemplateUpdateInput data, WorkflowTaskTemplateQuery query)
            : base("taskTemplateUpdate", "TaskTemplateUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "taskTemplate")))
        {
        }
    }
}
