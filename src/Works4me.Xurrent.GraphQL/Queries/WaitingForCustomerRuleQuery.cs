using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WaitingForCustomerRule"/> query class.
    /// </summary>
    public class WaitingForCustomerRuleQuery : Query<WaitingForCustomerRule, WaitingForCustomerRuleQuery, DefaultView, WaitingForCustomerRuleField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WaitingForCustomerRuleQuery"/> instance.
        /// </summary>
        public WaitingForCustomerRuleQuery() : base(string.Empty, true)
        {
        }
    }
}
