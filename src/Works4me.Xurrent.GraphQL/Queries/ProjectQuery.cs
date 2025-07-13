using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Project"/> query class.
    /// </summary>
    public class ProjectQuery : Query<Project, ProjectQuery, ProjectView, ProjectField, ProjectFilterField, ProjectOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectQuery"/> instance.
        /// </summary>
        public ProjectQuery() : base("projects", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Account" sub-query.</returns>
        public ProjectQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public ProjectQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public ProjectQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// Used to select the organization for which the project is to be implemented.
        /// </summary>
        /// <param name="query">The customer query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Customer" sub-query.</returns>
        public ProjectQuery SelectCustomer(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customer", query, false);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        /// <param name="query">The invoices query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Invoices" sub-query.</returns>
        public ProjectQuery SelectInvoices(InvoiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("invoices", query, true);
        }

        /// <summary>
        /// The person who is responsible for coordinating the implementation of the project.
        /// </summary>
        /// <param name="query">The manager query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Manager" sub-query.</returns>
        public ProjectQuery SelectManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("manager", query, false);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        /// <param name="query">The notes query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Notes" sub-query.</returns>
        public ProjectQuery SelectNotes(NoteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("notes", query, true);
        }

        /// <summary>
        /// Phases of the project.
        /// </summary>
        /// <param name="query">The phases query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Phases" sub-query.</returns>
        public ProjectQuery SelectPhases(ProjectPhaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("phases", query, true);
        }

        /// <summary>
        /// Problems of the project.
        /// </summary>
        /// <param name="query">The problems query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Problems" sub-query.</returns>
        public ProjectQuery SelectProblems(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("problems", query, true);
        }

        /// <summary>
        /// Requests of the project.
        /// </summary>
        /// <param name="query">The requests query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Requests" sub-query.</returns>
        public ProjectQuery SelectRequests(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requests", query, true);
        }

        /// <summary>
        /// Risks of the project.
        /// </summary>
        /// <param name="query">The risks query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Risks" sub-query.</returns>
        public ProjectQuery SelectRisks(RiskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("risks", query, true);
        }

        /// <summary>
        /// The service for which the project will be implemented.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Service" sub-query.</returns>
        public ProjectQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// Tasks of the project.
        /// </summary>
        /// <param name="query">The tasks query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Tasks" sub-query.</returns>
        public ProjectQuery SelectTasks(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("tasks", query, true);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public ProjectQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// The calendar that defines the work hours that are to be used to calculate the anticipated assignment and completion target for the tasks of the project.
        /// </summary>
        /// <param name="query">The work hours query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "WorkHours" sub-query.</returns>
        public ProjectQuery SelectWorkHours(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workHours", query, false);
        }

        /// <summary>
        /// Workflows of the project.
        /// </summary>
        /// <param name="query">The workflows query.</param>
        /// <returns>The same <see cref="ProjectQuery"/>, updated to include the "Workflows" sub-query.</returns>
        public ProjectQuery SelectWorkflows(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflows", query, true);
        }

        /// <summary>
        /// <br>Filter the <see cref="Project">Project</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/projectcustomfilter/">Xurrent developer site</see>.</br>
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
        public ProjectQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ProjectQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ProjectQuery">ProjectQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public ProjectQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
