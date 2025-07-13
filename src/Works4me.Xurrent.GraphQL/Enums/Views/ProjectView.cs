using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Projects.
    /// </summary>
    public enum ProjectView
    {
        /// <summary>
        /// All Projects.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived Projects.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// All Projects which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Projects Managed by Me.
        /// </summary>
        [XurrentEnum("managed_by_me")]
        ManagedByMe,

        /// <summary>
        /// Projects for My Team's Services.
        /// </summary>
        [XurrentEnum("my_teams_services")]
        MyTeamsServices,

        /// <summary>
        /// Portfolio Insight.
        /// </summary>
        [XurrentEnum("portfolio_insight")]
        PortfolioInsight,

        /// <summary>
        /// Trashed Projects.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
