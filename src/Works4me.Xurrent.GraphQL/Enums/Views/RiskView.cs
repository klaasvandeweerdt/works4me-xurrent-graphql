using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Risks.
    /// </summary>
    public enum RiskView
    {
        /// <summary>
        /// Risks.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived Risks.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// All Risks which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Trashed Risks.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
