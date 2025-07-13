using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskTemplate"/> query class.
    /// </summary>
    public class ProjectTaskTemplateQuery : Query<ProjectTaskTemplate, ProjectTaskTemplateQuery, ProjectTaskTemplateView, ProjectTaskTemplateField, ProjectTaskTemplateFilterField, ProjectTaskTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectTaskTemplateQuery"/> instance.
        /// </summary>
        public ProjectTaskTemplateQuery() : base("projectTaskTemplates", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "Account" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Agile board the project task will be placed on.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "AgileBoard" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectAgileBoard(AgileBoardQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoard", query, false);
        }

        /// <summary>
        /// Agile board column the project task will be placed in.
        /// </summary>
        /// <param name="query">The agile board column query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "AgileBoardColumn" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectAgileBoardColumn(AgileBoardColumnQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoardColumn", query, false);
        }

        /// <summary>
        /// Assignments of the project task template.
        /// </summary>
        /// <param name="query">The assignments query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "Assignments" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectAssignments(ProjectTaskTemplateAssignmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("assignments", query, true);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a project task created based on the template.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "EffortClass" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClass", query, false);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The instructions attachments query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "InstructionsAttachments" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("instructionsAttachments", query, true);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        /// <param name="query">The note attachments query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "NoteAttachments" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("noteAttachments", query, true);
        }

        /// <summary>
        /// The PDF design that needs to be copied to the PDF design field of a new project task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The pdf design query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "PdfDesign" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectPdfDesign(PdfDesignQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("pdfDesign", query, false);
        }

        /// <summary>
        /// Project templates that include the project task template.
        /// </summary>
        /// <param name="query">The project templates query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "ProjectTemplates" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectProjectTemplates(ProjectTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("projectTemplates", query, true);
        }

        /// <summary>
        /// The skill pool that should be selected in the Skill pool field of a new project task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The skill pool query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "SkillPool" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectSkillPool(SkillPoolQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("skillPool", query, false);
        }

        /// <summary>
        /// The supplier organization that should be selected in the Supplier field of a new project task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The supplier query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "Supplier" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectSupplier(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("supplier", query, false);
        }

        /// <summary>
        /// Project tasks created using the project task template.
        /// </summary>
        /// <param name="query">The tasks query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "Tasks" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectTasks(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("tasks", query, true);
        }

        /// <summary>
        /// The Team that should be selected in the Team field of a new project task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "Team" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }

        /// <summary>
        /// UI extension that is to be added to a new project task when it is being created based on the template.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public ProjectTaskTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ProjectTaskTemplateQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateQuery">ProjectTaskTemplateQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public ProjectTaskTemplateQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
