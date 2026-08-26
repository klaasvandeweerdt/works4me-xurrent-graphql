using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTaskApproval"/> query class.
    /// </summary>
    public class WorkflowTaskApprovalQuery : Query<WorkflowTaskApproval, WorkflowTaskApprovalQuery, DefaultView, WorkflowTaskApprovalField, TaskApprovalFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WorkflowTaskApprovalQuery"/> instance.
        /// </summary>
        public WorkflowTaskApprovalQuery() : base("taskApprovals", true)
        {
        }

        /// <summary>
        /// The person who is selected as the approver for the approval.
        /// </summary>
        /// <param name="query">The approver query.</param>
        /// <returns>The same <see cref="WorkflowTaskApprovalQuery"/>, updated to include the "Approver" sub-query.</returns>
        public WorkflowTaskApprovalQuery SelectApprover(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("approver", query, false);
        }

        /// <summary>
        /// The summary PDF file that was generated for the approver when the approval was last set to the status <c>assigned</c>.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>The same <see cref="WorkflowTaskApprovalQuery"/>, updated to include the "Attachment" sub-query.</returns>
        public WorkflowTaskApprovalQuery SelectAttachment(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("attachment", query, false);
        }

        /// <summary>
        /// The task to which the approval belongs.
        /// </summary>
        /// <param name="query">The task query.</param>
        /// <returns>The same <see cref="WorkflowTaskApprovalQuery"/>, updated to include the "Task" sub-query.</returns>
        public WorkflowTaskApprovalQuery SelectTask(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("task", query, false);
        }
    }
}
