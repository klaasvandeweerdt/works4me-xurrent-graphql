namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new task template.
    /// </summary>
    internal sealed class WorkflowTaskTemplateCreateMutation : Mutation<WorkflowTaskTemplateCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTaskTemplateCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the task template mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal WorkflowTaskTemplateCreateMutation(WorkflowTaskTemplateCreateInput data, WorkflowTaskTemplateQuery query)
            : base("taskTemplateCreate", "TaskTemplateCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "taskTemplate")))
        {
        }
    }
}
