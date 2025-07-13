using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskTemplateRelation"/> query class.
    /// </summary>
    public class ProjectTaskTemplateRelationQuery : Query<ProjectTaskTemplateRelation, ProjectTaskTemplateRelationQuery, DefaultView, ProjectTaskTemplateRelationField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectTaskTemplateRelationQuery"/> instance.
        /// </summary>
        public ProjectTaskTemplateRelationQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateRelationQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public ProjectTaskTemplateRelationQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// The phase of the project template that the project task template is a part of.
        /// </summary>
        /// <param name="query">The phase query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateRelationQuery"/>, updated to include the "Phase" sub-query.</returns>
        public ProjectTaskTemplateRelationQuery SelectPhase(ProjectTemplatePhaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("phase", query, false);
        }

        /// <summary>
        /// The project task template that is related to the project template.
        /// </summary>
        /// <param name="query">The task template query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateRelationQuery"/>, updated to include the "TaskTemplate" sub-query.</returns>
        public ProjectTaskTemplateRelationQuery SelectTaskTemplate(ProjectTaskTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("taskTemplate", query, false);
        }
    }
}
