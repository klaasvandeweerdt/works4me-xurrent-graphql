using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowType"/> query class.
    /// </summary>
    public class WorkflowTypeQuery : Query<WorkflowType, WorkflowTypeQuery, DefaultView, WorkflowTypeField, WorkflowTypeFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WorkflowTypeQuery"/> instance.
        /// </summary>
        public WorkflowTypeQuery() : base("workflowTypes", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="WorkflowTypeQuery"/>, updated to include the "Account" sub-query.</returns>
        public WorkflowTypeQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        /// <param name="query">The information attachments query.</param>
        /// <returns>The same <see cref="WorkflowTypeQuery"/>, updated to include the "InformationAttachments" sub-query.</returns>
        public WorkflowTypeQuery SelectInformationAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("informationAttachments", query, true);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="WorkflowTypeQuery"/>, updated to include the "Translations" sub-query.</returns>
        public WorkflowTypeQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }
    }
}
