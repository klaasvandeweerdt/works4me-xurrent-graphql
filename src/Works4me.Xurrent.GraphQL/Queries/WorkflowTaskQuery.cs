using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTask"/> query class.
    /// </summary>
    public class WorkflowTaskQuery : Query<WorkflowTask, WorkflowTaskQuery, WorkflowTaskView, WorkflowTaskField, WorkflowTaskFilterField, WorkflowTaskOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WorkflowTaskQuery"/> instance.
        /// </summary>
        public WorkflowTaskQuery() : base("tasks", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Account" sub-query.</returns>
        public WorkflowTaskQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "AgileBoard" sub-query.</returns>
        public WorkflowTaskQuery SelectAgileBoard(AgileBoardQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoard", query, false);
        }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        /// <param name="query">The agile board column query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "AgileBoardColumn" sub-query.</returns>
        public WorkflowTaskQuery SelectAgileBoardColumn(AgileBoardColumnQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoardColumn", query, false);
        }

        /// <summary>
        /// Approvals of the task.
        /// </summary>
        /// <param name="query">The approvals query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Approvals" sub-query.</returns>
        public WorkflowTaskQuery SelectApprovals(TaskApprovalQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("approvals", query, true);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public WorkflowTaskQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// Configuration items of the task.
        /// </summary>
        /// <param name="query">The configuration items query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "ConfigurationItems" sub-query.</returns>
        public WorkflowTaskQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItems", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public WorkflowTaskQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public WorkflowTaskQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// The task that will be assigned in case this task is failed or rejected.
        /// </summary>
        /// <param name="query">The failure task query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "FailureTask" sub-query.</returns>
        public WorkflowTaskQuery SelectFailureTask(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("failureTask", query, false);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The instructions attachments query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "InstructionsAttachments" sub-query.</returns>
        public WorkflowTaskQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("instructionsAttachments", query, true);
        }

        /// <summary>
        /// The person to whom the task is to be assigned. This field's value is <c>null</c> in case of an approval task with multiple approvers.
        /// </summary>
        /// <param name="query">The member query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Member" sub-query.</returns>
        public WorkflowTaskQuery SelectMember(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("member", query, false);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        /// <param name="query">The notes query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Notes" sub-query.</returns>
        public WorkflowTaskQuery SelectNotes(NoteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("notes", query, true);
        }

        /// <summary>
        /// The order line related to the fulfillment task.
        /// </summary>
        /// <param name="query">The order line query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "OrderLine" sub-query.</returns>
        public WorkflowTaskQuery SelectOrderLine(ShopOrderLineQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("orderLine", query, false);
        }

        /// <summary>
        /// The PDF design associated with the task.
        /// </summary>
        /// <param name="query">The pdf design query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "PdfDesign" sub-query.</returns>
        public WorkflowTaskQuery SelectPdfDesign(PdfDesignQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("pdfDesign", query, false);
        }

        /// <summary>
        /// The phase of the workflow to which the task belongs.
        /// </summary>
        /// <param name="query">The phase query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Phase" sub-query.</returns>
        public WorkflowTaskQuery SelectPhase(WorkflowPhaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("phase", query, false);
        }

        /// <summary>
        /// The request related to this task. When this request is solved the task will be completed.
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Request" sub-query.</returns>
        public WorkflowTaskQuery SelectRequest(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("request", query, false);
        }

        /// <summary>
        /// The service instance that should be used to create the request for this task.
        /// </summary>
        /// <param name="query">The request service instance query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "RequestServiceInstance" sub-query.</returns>
        public WorkflowTaskQuery SelectRequestServiceInstance(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestServiceInstance", query, false);
        }

        /// <summary>
        /// The request template that should be used to create the request for this task.
        /// </summary>
        /// <param name="query">The request template query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "RequestTemplate" sub-query.</returns>
        public WorkflowTaskQuery SelectRequestTemplate(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestTemplate", query, false);
        }

        /// <summary>
        /// Service instances of the task.
        /// </summary>
        /// <param name="query">The service instances query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "ServiceInstances" sub-query.</returns>
        public WorkflowTaskQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstances", query, true);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        /// <param name="query">The sprint backlog items query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "SprintBacklogItems" sub-query.</returns>
        public WorkflowTaskQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sprintBacklogItems", query, true);
        }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the task.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public WorkflowTaskQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// The team to which the task is to be assigned.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Team" sub-query.</returns>
        public WorkflowTaskQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }

        /// <summary>
        /// The task template that was used to register the task.
        /// </summary>
        /// <param name="query">The template query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Template" sub-query.</returns>
        public WorkflowTaskQuery SelectTemplate(WorkflowTaskTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("template", query, false);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        /// <param name="query">The time entries query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "TimeEntries" sub-query.</returns>
        public WorkflowTaskQuery SelectTimeEntries(TimeEntryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("timeEntries", query, true);
        }

        /// <summary>
        /// The workflow to which the task belongs.
        /// </summary>
        /// <param name="query">The workflow query.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery"/>, updated to include the "Workflow" sub-query.</returns>
        public WorkflowTaskQuery SelectWorkflow(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflow", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="WorkflowTask">WorkflowTask</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/workflowtaskcustomfilter/">Xurrent developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="op">The filter operator.</param>
        /// <param name="values">
        /// Use value <c>null</c> to indicate "None".
        /// 
        /// For "text" fields:
        /// • One can start the value with <c>~</c> to get partial matches (start with <c>'~</c> to match on a value starting with <c>~</c>).
        /// 
        /// For "number" and "time" fields:
        /// • One can start the value with <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c> to get relative matches.
        /// • Times should be formatted as HH:mm:ss (e.g. <c>16:00:00</c>). The seconds part, <c>:ss</c>, is optional so <c>16:00</c> is also valid.
        /// • <c>&gt;{lower}&lt;{upper}</c> can be used to get matches where the value is more than '{lower}' and less than '{upper}'.
        /// • <c>&gt;={lower}&lt;={upper}</c> can be used to get matches where the value is between '{lower}' and '{upper}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and less than '{upper}'.
        /// 
        /// For "date" and "date-time" fields:
        /// • One must supply a single value (and <c>null</c> is not supported).
        /// • Matches are always relative with an optional upper bound.
        /// • Dates should be formatted as <c>yyyy-MM-dd</c> (e.g. <c>2020-05-20</c>).
        /// • Date and time should be formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c> (e.g. <c>2020-05-20T16:00:00Z</c>).
        /// • <c>&gt;={lower}</c> should be used to get matches where the value is at least '{lower}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and before '{upper}'.
        /// 
        /// For "select" fields:
        /// • One must supply labels to match in the language of the account (i.e. not the value attributes of the HTML options).
        /// • Matches are case-sensitive.
        /// </param>
        public WorkflowTaskQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="WorkflowTaskQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="WorkflowTaskQuery">WorkflowTaskQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public WorkflowTaskQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
