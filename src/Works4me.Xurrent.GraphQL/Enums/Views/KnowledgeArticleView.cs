using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on KnowledgeArticles.
    /// </summary>
    public enum KnowledgeArticleView
    {
        /// <summary>
        /// All Knowledge Articles.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All KnowledgeArticles which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Knowledge Articles Managed by Me.
        /// </summary>
        [XurrentEnum("managed_by_me")]
        ManagedByMe,

        /// <summary>
        /// Knowledge Articles Managed in This Account.
        /// </summary>
        [XurrentEnum("managed_in_this_account")]
        ManagedInThisAccount,

        /// <summary>
        /// Knowledge Articles for My Team's Services.
        /// </summary>
        [XurrentEnum("my_teams_services")]
        MyTeamsServices
    }
}
