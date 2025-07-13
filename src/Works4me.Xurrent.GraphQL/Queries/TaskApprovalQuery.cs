using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TaskApproval"/> query class.
    /// </summary>
    public class TaskApprovalQuery : Query<TaskApproval, TaskApprovalQuery, DefaultView, TaskApprovalField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TaskApprovalQuery"/> instance.
        /// </summary>
        public TaskApprovalQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The person who is selected as the approver for the approval.
        /// </summary>
        /// <param name="query">The approver query.</param>
        /// <returns>The same <see cref="TaskApprovalQuery"/>, updated to include the "Approver" sub-query.</returns>
        public TaskApprovalQuery SelectApprover(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("approver", query, false);
        }

        /// <summary>
        /// The summary PDF file that was generated for the approver when the approval was last set to the status <c>assigned</c>.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>The same <see cref="TaskApprovalQuery"/>, updated to include the "Attachment" sub-query.</returns>
        public TaskApprovalQuery SelectAttachment(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("attachment", query, false);
        }
    }
}
