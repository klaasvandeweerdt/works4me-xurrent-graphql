using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ShortUrls.
    /// </summary>
    public enum ShortUrlView
    {
        /// <summary>
        /// Short URLs.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ShortUrls which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
