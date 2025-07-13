using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Sites.
    /// </summary>
    public enum SiteView
    {
        /// <summary>
        /// Sites.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Sites which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
