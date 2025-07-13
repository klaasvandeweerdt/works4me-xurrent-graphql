using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TaskTemplateApproval"/> query class.
    /// </summary>
    public class TaskTemplateApprovalQuery : Query<TaskTemplateApproval, TaskTemplateApprovalQuery, DefaultView, TaskTemplateApprovalField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TaskTemplateApprovalQuery"/> instance.
        /// </summary>
        public TaskTemplateApprovalQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The person who is selected as the approver for the task template approval.
        /// </summary>
        /// <param name="query">The approver query.</param>
        /// <returns>The same <see cref="TaskTemplateApprovalQuery"/>, updated to include the "Approver" sub-query.</returns>
        public TaskTemplateApprovalQuery SelectApprover(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("approver", query, false);
        }
    }
}
