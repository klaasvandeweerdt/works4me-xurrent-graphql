using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Request"/> query class.
    /// </summary>
    public class RequestQuery : Query<Request, RequestQuery, RequestView, RequestField, RequestFilterField, RequestOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="RequestQuery"/> instance.
        /// </summary>
        public RequestQuery() : base("requests", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Account" sub-query.</returns>
        public RequestQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Affected SLAs of the request.
        /// </summary>
        /// <param name="query">The affected slas query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "AffectedSlas" sub-query.</returns>
        public RequestQuery SelectAffectedSlas(AffectedSlaQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("affectedSlas", query, true);
        }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "AgileBoard" sub-query.</returns>
        public RequestQuery SelectAgileBoard(AgileBoardQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoard", query, false);
        }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        /// <param name="query">The agile board column query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "AgileBoardColumn" sub-query.</returns>
        public RequestQuery SelectAgileBoardColumn(AgileBoardColumnQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoardColumn", query, false);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public RequestQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// Configuration items of the request. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        /// <param name="query">The configuration items query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "ConfigurationItems" sub-query.</returns>
        public RequestQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationItems", query, true);
        }

        /// <summary>
        /// Automatically set to the person who submitted the request.
        /// </summary>
        /// <param name="query">The created by query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "CreatedBy" sub-query.</returns>
        public RequestQuery SelectCreatedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("createdBy", query, false);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public RequestQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public RequestQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// The <c>satisfiedUrl</c> and the <c>dissatisfiedUrl</c> of the <c>requestedFor</c>. In case the <c>requestedBy</c> is different form the <c>requestedFor</c>, the satisfaction link of the <c>requestedBy</c> are also included. Feedback is <c>null</c> in case no feedback for the request can be provided at this time.
        /// </summary>
        /// <param name="query">The feedback query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Feedback" sub-query.</returns>
        public RequestQuery SelectFeedback(FeedbackQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("feedback", query, false);
        }

        /// <summary>
        /// The knowledge article that this request provides feedback on.
        /// </summary>
        /// <param name="query">The feedback on knowledge article query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "FeedbackOnKnowledgeArticle" sub-query.</returns>
        public RequestQuery SelectFeedbackOnKnowledgeArticle(KnowledgeArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("feedbackOnKnowledgeArticle", query, false);
        }

        /// <summary>
        /// The request group that is used to group the requests that have been submitted for the resolution of exactly the same incident, for the implementation of exactly the same change, for the provision of exactly the same information, etc.
        /// </summary>
        /// <param name="query">The grouped into query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "GroupedInto" sub-query.</returns>
        public RequestQuery SelectGroupedInto(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("groupedInto", query, false);
        }

        /// <summary>
        /// Requests that are grouped into this request group.
        /// </summary>
        /// <param name="query">The grouped requests query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "GroupedRequests" sub-query.</returns>
        public RequestQuery SelectGroupedRequests(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("groupedRequests", query, true);
        }

        /// <summary>
        /// Knowledge articles of the current request account.
        /// </summary>
        /// <param name="query">The knowledge articles query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "KnowledgeArticles" sub-query.</returns>
        public RequestQuery SelectKnowledgeArticles(KnowledgeArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("knowledgeArticles", query, true);
        }

        /// <summary>
        /// The person to whom the request is to be assigned. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        /// <param name="query">The member query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Member" sub-query.</returns>
        public RequestQuery SelectMember(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("member", query, false);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        /// <param name="query">The notes query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Notes" sub-query.</returns>
        public RequestQuery SelectNotes(NoteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("notes", query, true);
        }

        /// <summary>
        /// Automatically set when the request is saved for the first time to the organization that the person, who is selected in the Requested for field, belongs.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Organization" sub-query.</returns>
        public RequestQuery SelectOrganization(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("organization", query, false);
        }

        /// <summary>
        /// Used to link the request to a problem.
        /// </summary>
        /// <param name="query">The problem query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Problem" sub-query.</returns>
        public RequestQuery SelectProblem(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("problem", query, false);
        }

        /// <summary>
        /// Product backlog this item is placed on.
        /// </summary>
        /// <param name="query">The product backlog query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "ProductBacklog" sub-query.</returns>
        public RequestQuery SelectProductBacklog(ProductBacklogQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("productBacklog", query, false);
        }

        /// <summary>
        /// Used to link the request to a project.
        /// </summary>
        /// <param name="query">The project query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Project" sub-query.</returns>
        public RequestQuery SelectProject(ProjectQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("project", query, false);
        }

        /// <summary>
        /// The person who submitted the request.
        /// </summary>
        /// <param name="query">The requested by query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "RequestedBy" sub-query.</returns>
        public RequestQuery SelectRequestedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestedBy", query, false);
        }

        /// <summary>
        /// The person for whom the request was submitted. The person selected in the Requested by field is automatically selected in this field, but another person can be selected if the request is submitted for another person.
        /// </summary>
        /// <param name="query">The requested for query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "RequestedFor" sub-query.</returns>
        public RequestQuery SelectRequestedFor(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestedFor", query, false);
        }

        /// <summary>
        /// The service instance in which the cause of the incident resides, for which the change is requested, or about which information is needed.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "ServiceInstance" sub-query.</returns>
        public RequestQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstance", query, false);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        /// <param name="query">The sprint backlog items query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "SprintBacklogItems" sub-query.</returns>
        public RequestQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sprintBacklogItems", query, true);
        }

        /// <summary>
        /// The supplier organization that has been asked to assist with the request. The supplier organization is automatically selected in this field after a service instance has been selected that is provided by an external service provider organization. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public RequestQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// Tags applied to the current request account.
        /// </summary>
        /// <param name="query">The tags query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Tags" sub-query.</returns>
        public RequestQuery SelectTags(TagQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("tags", query, true);
        }

        /// <summary>
        /// The task that caused the request to be automatically generated.
        /// </summary>
        /// <param name="query">The task query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Task" sub-query.</returns>
        public RequestQuery SelectTask(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("task", query, false);
        }

        /// <summary>
        /// The team to which the request is to be assigned. By default, the first line team of the service instance that is related to the request will be selected. If a first line team has not been specified for the service instance, the support team of the service instance will be selected instead. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Team" sub-query.</returns>
        public RequestQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }

        /// <summary>
        /// The link to the request template that was last applied to the request.
        /// </summary>
        /// <param name="query">The template query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Template" sub-query.</returns>
        public RequestQuery SelectTemplate(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("template", query, false);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        /// <param name="query">The time entries query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "TimeEntries" sub-query.</returns>
        public RequestQuery SelectTimeEntries(TimeEntryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("timeEntries", query, true);
        }

        /// <summary>
        /// List of all people watching the request.
        /// </summary>
        /// <param name="query">The watches query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Watches" sub-query.</returns>
        public RequestQuery SelectWatches(WatchQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("watches", query, true);
        }

        /// <summary>
        /// Used to link the request to a workflow.
        /// </summary>
        /// <param name="query">The workflow query.</param>
        /// <returns>The same <see cref="RequestQuery"/>, updated to include the "Workflow" sub-query.</returns>
        public RequestQuery SelectWorkflow(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflow", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="Request">Request</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/requestcustomfilter/">Xurrent developer site</see>.</br>
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
        public RequestQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="RequestQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="RequestQuery">RequestQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public RequestQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
