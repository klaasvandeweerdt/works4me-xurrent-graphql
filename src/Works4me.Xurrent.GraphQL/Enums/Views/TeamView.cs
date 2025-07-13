using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Teams.
    /// </summary>
    public enum TeamView
    {
        /// <summary>
        /// All Teams.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Teams Coordinated by Me.
        /// </summary>
        [XurrentEnum("coordinated_by_me")]
        CoordinatedByMe,

        /// <summary>
        /// All Teams which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Teams Managed by Me.
        /// </summary>
        [XurrentEnum("managed_by_me")]
        ManagedByMe
    }
}
