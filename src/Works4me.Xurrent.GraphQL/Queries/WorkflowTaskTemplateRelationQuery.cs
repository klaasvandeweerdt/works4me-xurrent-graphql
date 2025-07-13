using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTaskTemplateRelation"/> query class.
    /// </summary>
    public class WorkflowTaskTemplateRelationQuery : Query<WorkflowTaskTemplateRelation, WorkflowTaskTemplateRelationQuery, DefaultView, WorkflowTaskTemplateRelationField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WorkflowTaskTemplateRelationQuery"/> instance.
        /// </summary>
        public WorkflowTaskTemplateRelationQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rules query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateRelationQuery"/>, updated to include the "AutomationRules" sub-query.</returns>
        public WorkflowTaskTemplateRelationQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("automationRules", query, true);
        }

        /// <summary>
        /// The template of the task that will be assigned in case this task is failed or rejected.
        /// </summary>
        /// <param name="query">The failure task template query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateRelationQuery"/>, updated to include the "FailureTaskTemplate" sub-query.</returns>
        public WorkflowTaskTemplateRelationQuery SelectFailureTaskTemplate(WorkflowTaskTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("failureTaskTemplate", query, false);
        }

        /// <summary>
        /// The phase of the workflow template that the workflow task template is a part of.
        /// </summary>
        /// <param name="query">The phase query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateRelationQuery"/>, updated to include the "Phase" sub-query.</returns>
        public WorkflowTaskTemplateRelationQuery SelectPhase(WorkflowTemplatePhaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("phase", query, false);
        }

        /// <summary>
        /// Task template related to the workflow template.
        /// </summary>
        /// <param name="query">The task template query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateRelationQuery"/>, updated to include the "TaskTemplate" sub-query.</returns>
        public WorkflowTaskTemplateRelationQuery SelectTaskTemplate(WorkflowTaskTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("taskTemplate", query, false);
        }

        /// <summary>
        /// Workflow template related to the task template.
        /// </summary>
        /// <param name="query">The workflow template query.</param>
        /// <returns>The same <see cref="WorkflowTaskTemplateRelationQuery"/>, updated to include the "WorkflowTemplate" sub-query.</returns>
        public WorkflowTaskTemplateRelationQuery SelectWorkflowTemplate(WorkflowTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("workflowTemplate", query, false);
        }
    }
}
