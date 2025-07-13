using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Organizations.
    /// </summary>
    public enum OrganizationView
    {
        /// <summary>
        /// All Organizations.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Organizations which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// My Organizations.
        /// </summary>
        [XurrentEnum("managed_by_me")]
        ManagedByMe
    }
}
