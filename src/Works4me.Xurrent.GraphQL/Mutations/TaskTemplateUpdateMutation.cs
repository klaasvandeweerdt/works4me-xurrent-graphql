namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing task template.
    /// </summary>
    internal sealed class TaskTemplateUpdateMutation : Mutation<WorkflowTaskTemplateUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskTemplateUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TaskTemplateUpdateMutation(WorkflowTaskTemplateUpdateInput data, WorkflowTaskTemplateQuery query)
            : base("taskTemplateUpdate", "TaskTemplateUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "taskTemplate")))
        {
        }
    }
}
