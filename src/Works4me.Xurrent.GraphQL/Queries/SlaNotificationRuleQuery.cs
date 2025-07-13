using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SlaNotificationRule"/> query class.
    /// </summary>
    public class SlaNotificationRuleQuery : Query<SlaNotificationRule, SlaNotificationRuleQuery, DefaultView, SlaNotificationRuleField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SlaNotificationRuleQuery"/> instance.
        /// </summary>
        public SlaNotificationRuleQuery() : base(string.Empty, true)
        {
        }
    }
}
