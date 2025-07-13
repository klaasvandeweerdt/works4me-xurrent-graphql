using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AutomationRuleAction">AutomationRuleAction</see> fields.
    /// </summary>
    public enum AutomationRuleActionField
    {
        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The value field.
        /// </summary>
        [XurrentEnum("value")]
        Value
    }
}
