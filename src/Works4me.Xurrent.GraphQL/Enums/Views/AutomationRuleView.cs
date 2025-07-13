using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on AutomationRules.
    /// </summary>
    public enum AutomationRuleView
    {
        /// <summary>
        /// Automation Rules.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All AutomationRules which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// SCIM Group Automation Rules.
        /// </summary>
        [XurrentEnum("scim_group")]
        ScimGroup,

        /// <summary>
        /// SCIM User Automation Rules.
        /// </summary>
        [XurrentEnum("scim_user")]
        ScimUser
    }
}
