using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Team"/> query class.
    /// </summary>
    public class TeamQuery : Query<Team, TeamQuery, TeamView, TeamField, TeamFilterField, TeamOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TeamQuery"/> instance.
        /// </summary>
        public TeamQuery() : base("teams", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "Account" sub-query.</returns>
        public TeamQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Used to automatically link records to the agile board when they are assigned to the team.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "AgileBoard" sub-query.</returns>
        public TeamQuery SelectAgileBoard(AgileBoardQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoard", query, false);
        }

        /// <summary>
        /// The person who maintains the information about the configuration items that the team supports.
        /// </summary>
        /// <param name="query">The configuration manager query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "ConfigurationManager" sub-query.</returns>
        public TeamQuery SelectConfigurationManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("configurationManager", query, false);
        }

        /// <summary>
        /// The current team coordinator for the team. Only members of the team can be selected in this field.
        /// </summary>
        /// <param name="query">The coordinator query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "Coordinator" sub-query.</returns>
        public TeamQuery SelectCoordinator(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("coordinator", query, false);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public TeamQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public TeamQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// The manager or supervisor of the team. This person is able to maintain the information about the team. The manager of a team does not need to be a member of the team.
        /// </summary>
        /// <param name="query">The manager query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "Manager" sub-query.</returns>
        public TeamQuery SelectManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("manager", query, false);
        }

        /// <summary>
        /// People linked as a member to the team.
        /// </summary>
        /// <param name="query">The members query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "Members" sub-query.</returns>
        public TeamQuery SelectMembers(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("members", query, true);
        }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public TeamQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// Scrum workspace used by this team to plan their work.
        /// </summary>
        /// <param name="query">The scrum workspace query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "ScrumWorkspace" sub-query.</returns>
        public TeamQuery SelectScrumWorkspace(ScrumWorkspaceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("scrumWorkspace", query, false);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public TeamQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// The calendar that defines the work hours during which the team is available for work on all types of assignments.
        /// </summary>
        /// <param name="query">The work hours query.</param>
        /// <returns>The same <see cref="TeamQuery"/>, updated to include the "WorkHours" sub-query.</returns>
        public TeamQuery SelectWorkHours(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workHours", query, false);
        }

        /// <summary>
        /// <br>Filter the <see cref="Team">Team</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/teamcustomfilter/">Xurrent developer site</see>.</br>
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
        public TeamQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="TeamQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="TeamQuery">TeamQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public TeamQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
