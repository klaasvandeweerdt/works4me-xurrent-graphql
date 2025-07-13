using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AutomationRule"/> query class.
    /// </summary>
    public class AutomationRuleQuery : Query<AutomationRule, AutomationRuleQuery, AutomationRuleView, AutomationRuleField, AutomationRuleFilterField, AutomationRuleOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AutomationRuleQuery"/> instance.
        /// </summary>
        public AutomationRuleQuery() : base("automationRules", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Account" sub-query.</returns>
        public AutomationRuleQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The Actions field is used to define actions that should be executed when the condition of the automation rule is met.
        /// </summary>
        /// <param name="query">The actions query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Actions" sub-query.</returns>
        public AutomationRuleQuery SelectActions(AutomationRuleActionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("actions", query, false);
        }

        /// <summary>
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        /// <param name="query">The expressions query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Expressions" sub-query.</returns>
        public AutomationRuleQuery SelectExpressions(AutomationRuleExpressionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("expressions", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="projectTaskTemplateQuery">The project task template query.</param>
        /// <param name="projectTaskTemplateRelationQuery">The project task template relation query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="requestTemplateQuery">The request template query.</param>
        /// <param name="workflowTaskQuery">The workflow task query.</param>
        /// <param name="workflowTaskTemplateQuery">The workflow task template query.</param>
        /// <param name="workflowQuery">The workflow query.</param>
        /// <param name="workflowTaskTemplateRelationQuery">The workflow task template relation query.</param>
        /// <param name="workflowTemplateQuery">The workflow template query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the sub-queries.</returns>
        public AutomationRuleQuery SelectOwnerAll(
            ProjectTaskQuery? projectTaskQuery = null,
            ProjectTaskTemplateQuery? projectTaskTemplateQuery = null,
            ProjectTaskTemplateRelationQuery? projectTaskTemplateRelationQuery = null,
            RequestQuery? requestQuery = null,
            RequestTemplateQuery? requestTemplateQuery = null,
            WorkflowTaskQuery? workflowTaskQuery = null,
            WorkflowTaskTemplateQuery? workflowTaskTemplateQuery = null,
            WorkflowQuery? workflowQuery = null,
            WorkflowTaskTemplateRelationQuery? workflowTaskTemplateRelationQuery = null,
            WorkflowTemplateQuery? workflowTemplateQuery = null)
        {
            AutomationRuleQuery query = SelectOnType("owner", projectTaskQuery ?? new(), false);
            query = query.SelectOnType("owner", projectTaskTemplateQuery ?? new(), false);
            query = query.SelectOnType("owner", projectTaskTemplateRelationQuery ?? new(), false);
            query = query.SelectOnType("owner", requestQuery ?? new(), false);
            query = query.SelectOnType("owner", requestTemplateQuery ?? new(), false);
            query = query.SelectOnType("owner", workflowTaskQuery ?? new(), false);
            query = query.SelectOnType("owner", workflowTaskTemplateQuery ?? new(), false);
            query = query.SelectOnType("owner", workflowQuery ?? new(), false);
            query = query.SelectOnType("owner", workflowTaskTemplateRelationQuery ?? new(), false);
            query = query.SelectOnType("owner", workflowTemplateQuery ?? new(), false);
            return query;
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(ProjectTaskTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(ProjectTaskTemplateRelationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(WorkflowTaskTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(WorkflowTaskTemplateRelationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// The record that the automation rule is linked to.<br />
        /// Use this method along with other <c>SelectOwner()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectOwner()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The owner query.</param>
        /// <returns>The same <see cref="AutomationRuleQuery"/>, updated to include the "Owner" sub-query.</returns>
        public AutomationRuleQuery SelectOwner(WorkflowTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("owner", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="AutomationRuleQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="AutomationRuleQuery">AutomationRuleQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public AutomationRuleQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
