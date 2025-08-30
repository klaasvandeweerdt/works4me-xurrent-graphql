using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTaskTemplate"/> query class.
    /// </summary>
    public class WorkflowTaskTemplateQuery : Query<WorkflowTaskTemplate, WorkflowTaskTemplateQuery, WorkflowTaskTemplateView, WorkflowTaskTemplateField, WorkflowTaskTemplateFilterField, WorkflowTaskTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WorkflowTaskTemplateQuery"/> instance.
        /// </summary>
        public WorkflowTaskTemplateQuery() : base("taskTemplates", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "Account" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Approvals of the task template.
        /// </summary>
        /// <param name="query">The approvals query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "Approvals" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectApprovals(TaskTemplateApprovalQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("approvals", query, true);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// Configuration items of the task template.
        /// </summary>
        /// <param name="query">The configuration items query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "ConfigurationItems" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItems", query, true);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a task created based on the template.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "EffortClass" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClass", query, false);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The instructions attachments query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "InstructionsAttachments" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("instructionsAttachments", query, true);
        }

        /// <summary>
        /// The person who should be selected in the Member field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The member query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "Member" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectMember(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("member", query, false);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        /// <param name="query">The note attachments query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "NoteAttachments" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("noteAttachments", query, true);
        }

        /// <summary>
        /// The PDF design that needs to be copied to the PDF design field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The pdf design query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "PdfDesign" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectPdfDesign(PdfDesignQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("pdfDesign", query, false);
        }

        /// <summary>
        /// The service instance that should be selected in the Request service instance field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The request service instance query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "RequestServiceInstance" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectRequestServiceInstance(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestServiceInstance", query, false);
        }

        /// <summary>
        /// The request template that should be selected in the Request template field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The request template query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "RequestTemplate" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectRequestTemplate(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestTemplate", query, false);
        }

        /// <summary>
        /// Service instances of the task template.
        /// </summary>
        /// <param name="query">The service instances query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "ServiceInstances" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstances", query, true);
        }

        /// <summary>
        /// The skill pool that should be selected in the Skill pool field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The skill pool query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "SkillPool" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectSkillPool(SkillPoolQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("skillPool", query, false);
        }

        /// <summary>
        /// The supplier organization that should be selected in the Supplier field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// Tasks created using the task template.
        /// </summary>
        /// <param name="query">The tasks query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "Tasks" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectTasks(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("tasks", query, true);
        }

        /// <summary>
        /// The team that should be selected in the Team field of a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "Team" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }

        /// <summary>
        /// UI extension that is to be added to a new task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// Workflow templates that include the task template.
        /// </summary>
        /// <param name="query">The workflow templates query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery"/>, updated to include the "WorkflowTemplates" sub-query.</returns>
        public WorkflowTaskTemplateQuery SelectWorkflowTemplates(WorkflowTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowTemplates", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="WorkflowTaskTemplateQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateQuery">WorkflowTaskTemplateQuery</see>, updated to include the "Search" sub-query.</returns>
        public WorkflowTaskTemplateQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
