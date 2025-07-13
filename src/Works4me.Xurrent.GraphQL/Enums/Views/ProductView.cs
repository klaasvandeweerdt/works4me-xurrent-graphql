using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Products.
    /// </summary>
    public enum ProductView
    {
        /// <summary>
        /// All Products.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Products which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Products Supported by My Teams.
        /// </summary>
        [XurrentEnum("supported_by_my_teams")]
        SupportedByMyTeams
    }
}
