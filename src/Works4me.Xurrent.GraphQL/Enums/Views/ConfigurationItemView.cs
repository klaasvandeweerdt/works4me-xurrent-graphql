using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ConfigurationItems.
    /// </summary>
    public enum ConfigurationItemView
    {
        /// <summary>
        /// All Configuration Items.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived CIs.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// All ConfigurationItems which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Spare CIs.
        /// </summary>
        [XurrentEnum("spare_cis")]
        SpareCis,

        /// <summary>
        /// CIs Supported by My Teams.
        /// </summary>
        [XurrentEnum("supported_by_my_teams")]
        SupportedByMyTeams,

        /// <summary>
        /// Trashed CIs.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
