using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Problem"/> query class.
    /// </summary>
    public class ProblemQuery : Query<Problem, ProblemQuery, ProblemView, ProblemField, ProblemFilterField, ProblemOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProblemQuery"/> instance.
        /// </summary>
        public ProblemQuery() : base("problems", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Account" sub-query.</returns>
        public ProblemQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "AgileBoard" sub-query.</returns>
        public ProblemQuery SelectAgileBoard(AgileBoardQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoard", query, false);
        }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        /// <param name="query">The agile board column query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "AgileBoardColumn" sub-query.</returns>
        public ProblemQuery SelectAgileBoardColumn(AgileBoardColumnQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoardColumn", query, false);
        }

        /// <summary>
        /// Configuration items of this problem.
        /// </summary>
        /// <param name="query">The configuration items query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "ConfigurationItems" sub-query.</returns>
        public ProblemQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItems", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public ProblemQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public ProblemQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// The knowledge article which instructions should be followed to resolve incidents caused by this problem until a structural solution has been implemented.
        /// </summary>
        /// <param name="query">The knowledge article query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "KnowledgeArticle" sub-query.</returns>
        public ProblemQuery SelectKnowledgeArticle(KnowledgeArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("knowledgeArticle", query, false);
        }

        /// <summary>
        /// Person who is responsible for coordinating the problem through root cause analysis, the proposal of a structural solution and ultimately its closure.
        /// </summary>
        /// <param name="query">The manager query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Manager" sub-query.</returns>
        public ProblemQuery SelectManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("manager", query, false);
        }

        /// <summary>
        /// The person to whom the problem is to be assigned.
        /// </summary>
        /// <param name="query">The member query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Member" sub-query.</returns>
        public ProblemQuery SelectMember(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("member", query, false);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        /// <param name="query">The notes query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Notes" sub-query.</returns>
        public ProblemQuery SelectNotes(NoteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("notes", query, true);
        }

        /// <summary>
        /// Product backlog this item is placed on.
        /// </summary>
        /// <param name="query">The product backlog query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "ProductBacklog" sub-query.</returns>
        public ProblemQuery SelectProductBacklog(ProductBacklogQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("productBacklog", query, false);
        }

        /// <summary>
        /// Used to link the problem to a project.
        /// </summary>
        /// <param name="query">The project query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Project" sub-query.</returns>
        public ProblemQuery SelectProject(ProjectQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("project", query, false);
        }

        /// <summary>
        /// Requests of this problem.
        /// </summary>
        /// <param name="query">The requests query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Requests" sub-query.</returns>
        public ProblemQuery SelectRequests(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requests", query, true);
        }

        /// <summary>
        /// The service in which instance(s) the problem resides.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Service" sub-query.</returns>
        public ProblemQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// Service instances of this problem.
        /// </summary>
        /// <param name="query">The service instances query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "ServiceInstances" sub-query.</returns>
        public ProblemQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstances", query, true);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        /// <param name="query">The sprint backlog items query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "SprintBacklogItems" sub-query.</returns>
        public ProblemQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sprintBacklogItems", query, true);
        }

        /// <summary>
        /// The supplier organization that has been asked for a solution to the problem.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public ProblemQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// The team to which the problem is to be assigned. After a service has been selected in the Service field, the support team of the service is automatically selected in this field.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Team" sub-query.</returns>
        public ProblemQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        /// <param name="query">The time entries query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "TimeEntries" sub-query.</returns>
        public ProblemQuery SelectTimeEntries(TimeEntryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("timeEntries", query, true);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public ProblemQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// Inline images linked to the Workaround field.
        /// </summary>
        /// <param name="query">The workaround attachments query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "WorkaroundAttachments" sub-query.</returns>
        public ProblemQuery SelectWorkaroundAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workaroundAttachments", query, true);
        }

        /// <summary>
        /// The workflow that will implement the proposed permanent solution for the problem.
        /// </summary>
        /// <param name="query">The workflow query.</param>
        /// <returns>The same <see cref="ProblemQuery"/>, updated to include the "Workflow" sub-query.</returns>
        public ProblemQuery SelectWorkflow(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflow", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="Problem">Problem</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/problemcustomfilter/">Xurrent developer site</see>.</br>
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
        public ProblemQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ProblemQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ProblemQuery">ProblemQuery</see>, updated to include the "Search" sub-query.</returns>
        public ProblemQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
