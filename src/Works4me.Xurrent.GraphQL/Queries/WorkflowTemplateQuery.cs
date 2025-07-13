using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTemplate"/> query class.
    /// </summary>
    public class WorkflowTemplateQuery : Query<WorkflowTemplate, WorkflowTemplateQuery, WorkflowTemplateView, WorkflowTemplateField, WorkflowTemplateFilterField, WorkflowTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WorkflowTemplateQuery"/> instance.
        /// </summary>
        public WorkflowTemplateQuery() : base("workflowTemplates", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "Account" sub-query.</returns>
        public WorkflowTemplateQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public WorkflowTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The instructions attachments query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "InstructionsAttachments" sub-query.</returns>
        public WorkflowTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("instructionsAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        /// <param name="query">The note attachments query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "NoteAttachments" sub-query.</returns>
        public WorkflowTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("noteAttachments", query, true);
        }

        /// <summary>
        /// Phases of the workflow template.
        /// </summary>
        /// <param name="query">The phases query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "Phases" sub-query.</returns>
        public WorkflowTemplateQuery SelectPhases(WorkflowTemplatePhaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("phases", query, true);
        }

        /// <summary>
        /// Recurrency for the workflow template.
        /// </summary>
        /// <param name="query">The recurrence query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "Recurrence" sub-query.</returns>
        public WorkflowTemplateQuery SelectRecurrence(RecurrenceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("recurrence", query, false);
        }

        /// <summary>
        /// The service that should be selected in the Service field of a new workflow when it is being created based on the template.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "Service" sub-query.</returns>
        public WorkflowTemplateQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// Task template relations of the workflow template.
        /// </summary>
        /// <param name="query">The task template relations query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "TaskTemplateRelations" sub-query.</returns>
        public WorkflowTemplateQuery SelectTaskTemplateRelations(WorkflowTaskTemplateRelationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("taskTemplateRelations", query, true);
        }

        /// <summary>
        /// UI extension that is to be added to a new workflow when it is being created based on the template.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public WorkflowTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        /// <param name="query">The workflow manager query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "WorkflowManager" sub-query.</returns>
        public WorkflowTemplateQuery SelectWorkflowManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowManager", query, false);
        }

        /// <summary>
        /// The type that needs to be selected in the Type field of a new workflow when it is being created based on the template.
        /// </summary>
        /// <param name="query">The workflow type query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "WorkflowType" sub-query.</returns>
        public WorkflowTemplateQuery SelectWorkflowType(WorkflowTypeQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowType", query, false);
        }

        /// <summary>
        /// Workflows of the workflow template.
        /// </summary>
        /// <param name="query">The workflows query.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery"/>, updated to include the "Workflows" sub-query.</returns>
        public WorkflowTemplateQuery SelectWorkflows(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflows", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="WorkflowTemplateQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="WorkflowTemplateQuery">WorkflowTemplateQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public WorkflowTemplateQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
