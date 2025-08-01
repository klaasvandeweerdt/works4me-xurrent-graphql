﻿namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing task.
    /// </summary>
    internal sealed class TaskUpdateMutation : Mutation<WorkflowTaskUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the task mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TaskUpdateMutation(WorkflowTaskUpdateInput data, WorkflowTaskQuery query)
            : base("taskUpdate", "TaskUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "task")))
        {
        }
    }
}
