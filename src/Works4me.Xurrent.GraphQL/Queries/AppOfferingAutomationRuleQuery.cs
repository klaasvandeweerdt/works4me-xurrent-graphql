using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AppOfferingAutomationRule"/> query class.
    /// </summary>
    public class AppOfferingAutomationRuleQuery : Query<AppOfferingAutomationRule, AppOfferingAutomationRuleQuery, DefaultView, AppOfferingAutomationRuleField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AppOfferingAutomationRuleQuery"/> instance.
        /// </summary>
        public AppOfferingAutomationRuleQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="AppOfferingAutomationRuleQuery"/>, updated to include the "Account" sub-query.</returns>
        public AppOfferingAutomationRuleQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The Actions field is used to define actions that should be executed when the condition of the automation rule is met.
        /// </summary>
        /// <param name="query">The actions query.</param>
        /// <returns>The same <see cref="AppOfferingAutomationRuleQuery"/>, updated to include the "Actions" sub-query.</returns>
        public AppOfferingAutomationRuleQuery SelectActions(AutomationRuleActionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("actions", query, false);
        }

        /// <summary>
        /// AppOffering this rule belongs to.
        /// </summary>
        /// <param name="query">The app offering query.</param>
        /// <returns>The same <see cref="AppOfferingAutomationRuleQuery"/>, updated to include the "AppOffering" sub-query.</returns>
        public AppOfferingAutomationRuleQuery SelectAppOffering(AppOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("appOffering", query, false);
        }

        /// <summary>
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        /// <param name="query">The expressions query.</param>
        /// <returns>The same <see cref="AppOfferingAutomationRuleQuery"/>, updated to include the "Expressions" sub-query.</returns>
        public AppOfferingAutomationRuleQuery SelectExpressions(AutomationRuleExpressionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("expressions", query, false);
        }
    }
}
