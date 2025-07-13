using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AutomationRuleExpression"/> query class.
    /// </summary>
    public class AutomationRuleExpressionQuery : Query<AutomationRuleExpression, AutomationRuleExpressionQuery, DefaultView, AutomationRuleExpressionField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AutomationRuleExpressionQuery"/> instance.
        /// </summary>
        public AutomationRuleExpressionQuery() : base(string.Empty, false)
        {
        }
    }
}
