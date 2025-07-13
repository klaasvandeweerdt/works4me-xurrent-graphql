using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AutomationRuleAction"/> query class.
    /// </summary>
    public class AutomationRuleActionQuery : Query<AutomationRuleAction, AutomationRuleActionQuery, DefaultView, AutomationRuleActionField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AutomationRuleActionQuery"/> instance.
        /// </summary>
        public AutomationRuleActionQuery() : base(string.Empty, false)
        {
        }
    }
}
