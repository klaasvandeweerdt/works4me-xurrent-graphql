namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new task.
    /// </summary>
    internal sealed class TaskCreateMutation : Mutation<WorkflowTaskCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TaskCreateMutation(WorkflowTaskCreateInput data, WorkflowTaskQuery query)
            : base("taskCreate", "TaskCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "task")))
        {
        }
    }
}
