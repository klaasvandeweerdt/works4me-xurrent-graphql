using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Workflow"/> query class.
    /// </summary>
    public class WorkflowQuery : Query<Workflow, WorkflowQuery, WorkflowView, WorkflowField, WorkflowFilterField, WorkflowOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WorkflowQuery"/> instance.
        /// </summary>
        public WorkflowQuery() : base("workflows", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Account" sub-query.</returns>
        public WorkflowQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public WorkflowQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public WorkflowQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public WorkflowQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        /// <param name="query">The invoices query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Invoices" sub-query.</returns>
        public WorkflowQuery SelectInvoices(InvoiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("invoices", query, true);
        }

        /// <summary>
        /// Who is responsible for coordinating the implementation of the workflow. If a manager is not specified for a new workflow, the API user is selected in the Manager field by default.
        /// </summary>
        /// <param name="query">The manager query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Manager" sub-query.</returns>
        public WorkflowQuery SelectManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("manager", query, false);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        /// <param name="query">The notes query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Notes" sub-query.</returns>
        public WorkflowQuery SelectNotes(NoteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("notes", query, true);
        }

        /// <summary>
        /// Phases of the workflow.
        /// </summary>
        /// <param name="query">The phases query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Phases" sub-query.</returns>
        public WorkflowQuery SelectPhases(WorkflowPhaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("phases", query, true);
        }

        /// <summary>
        /// All problems of this workflow.
        /// </summary>
        /// <param name="query">The problems query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Problems" sub-query.</returns>
        public WorkflowQuery SelectProblems(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("problems", query, true);
        }

        /// <summary>
        /// Linked project.
        /// </summary>
        /// <param name="query">The project query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Project" sub-query.</returns>
        public WorkflowQuery SelectProject(ProjectQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("project", query, false);
        }

        /// <summary>
        /// The release that the workflow is a part of.
        /// </summary>
        /// <param name="query">The release query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Release" sub-query.</returns>
        public WorkflowQuery SelectRelease(ReleaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("release", query, false);
        }

        /// <summary>
        /// All requests of this workflow.
        /// </summary>
        /// <param name="query">The requests query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Requests" sub-query.</returns>
        public WorkflowQuery SelectRequests(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requests", query, true);
        }

        /// <summary>
        /// The service that will directly be affected by the workflow implementation, or in case of an emergency change, the service that was directly affected by the workflow implementation.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Service" sub-query.</returns>
        public WorkflowQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// All tasks of this workflow.
        /// </summary>
        /// <param name="query">The tasks query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Tasks" sub-query.</returns>
        public WorkflowQuery SelectTasks(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("tasks", query, true);
        }

        /// <summary>
        /// The workflow template that was used to register the workflow.
        /// </summary>
        /// <param name="query">The template query.</param>
        /// <returns>The same <see cref="WorkflowQuery"/>, updated to include the "Template" sub-query.</returns>
        public WorkflowQuery SelectTemplate(WorkflowTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("template", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="Workflow">Workflow</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/workflowcustomfilter/">Xurrent developer site</see>.</br>
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
        public WorkflowQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="WorkflowQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="WorkflowQuery">WorkflowQuery</see>, updated to include the "Search" sub-query.</returns>
        public WorkflowQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
