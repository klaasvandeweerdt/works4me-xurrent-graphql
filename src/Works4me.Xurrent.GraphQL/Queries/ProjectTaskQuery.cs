using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTask"/> query class.
    /// </summary>
    public class ProjectTaskQuery : Query<ProjectTask, ProjectTaskQuery, ProjectTaskView, ProjectTaskField, ProjectTaskFilterField, ProjectTaskOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectTaskQuery"/> instance.
        /// </summary>
        public ProjectTaskQuery() : base("projectTasks", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Account" sub-query.</returns>
        public ProjectTaskQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "AgileBoard" sub-query.</returns>
        public ProjectTaskQuery SelectAgileBoard(AgileBoardQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoard", query, false);
        }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        /// <param name="query">The agile board column query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "AgileBoardColumn" sub-query.</returns>
        public ProjectTaskQuery SelectAgileBoardColumn(AgileBoardColumnQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoardColumn", query, false);
        }

        /// <summary>
        /// Assignments of the project task.
        /// </summary>
        /// <param name="query">The assignments query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Assignments" sub-query.</returns>
        public ProjectTaskQuery SelectAssignments(ProjectTaskAssignmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("assignments", query, true);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public ProjectTaskQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public ProjectTaskQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public ProjectTaskQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The instructions attachments query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "InstructionsAttachments" sub-query.</returns>
        public ProjectTaskQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("instructionsAttachments", query, true);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        /// <param name="query">The notes query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Notes" sub-query.</returns>
        public ProjectTaskQuery SelectNotes(NoteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("notes", query, true);
        }

        /// <summary>
        /// The PDF design associated with the task.
        /// </summary>
        /// <param name="query">The pdf design query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "PdfDesign" sub-query.</returns>
        public ProjectTaskQuery SelectPdfDesign(PdfDesignQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("pdfDesign", query, false);
        }

        /// <summary>
        /// The phase of the project to which the project task belongs.
        /// </summary>
        /// <param name="query">The phase query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Phase" sub-query.</returns>
        public ProjectTaskQuery SelectPhase(ProjectPhaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("phase", query, false);
        }

        /// <summary>
        /// Predecessors of the project task.
        /// </summary>
        /// <param name="query">The predecessors query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Predecessors" sub-query.</returns>
        public ProjectTaskQuery SelectPredecessors(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("predecessors", query, true);
        }

        /// <summary>
        /// The project to which the project task belongs.
        /// </summary>
        /// <param name="query">The project query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Project" sub-query.</returns>
        public ProjectTaskQuery SelectProject(ProjectQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("project", query, false);
        }

        /// <summary>
        /// Skill pool that represents the specific expertise needed to complete the task.
        /// </summary>
        /// <param name="query">The skill pool query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "SkillPool" sub-query.</returns>
        public ProjectTaskQuery SelectSkillPool(SkillPoolQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("skillPool", query, false);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        /// <param name="query">The sprint backlog items query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "SprintBacklogItems" sub-query.</returns>
        public ProjectTaskQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sprintBacklogItems", query, true);
        }

        /// <summary>
        /// Successors of the project task.
        /// </summary>
        /// <param name="query">The successors query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Successors" sub-query.</returns>
        public ProjectTaskQuery SelectSuccessors(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("successors", query, true);
        }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the project task.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public ProjectTaskQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// The team to which the project task is to be assigned.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Team" sub-query.</returns>
        public ProjectTaskQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }

        /// <summary>
        /// The project task template that was used to register the project task.
        /// </summary>
        /// <param name="query">The template query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "Template" sub-query.</returns>
        public ProjectTaskQuery SelectTemplate(ProjectTaskTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("template", query, false);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        /// <param name="query">The time entries query.</param>
        /// <returns>The same <see cref="ProjectTaskQuery"/>, updated to include the "TimeEntries" sub-query.</returns>
        public ProjectTaskQuery SelectTimeEntries(TimeEntryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("timeEntries", query, true);
        }

        /// <summary>
        /// <br>Filter the <see cref="ProjectTask">ProjectTask</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/projecttaskcustomfilter/">Xurrent developer site</see>.</br>
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
        public ProjectTaskQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ProjectTaskQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ProjectTaskQuery">ProjectTaskQuery</see>, updated to include the "Search" sub-query.</returns>
        public ProjectTaskQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
