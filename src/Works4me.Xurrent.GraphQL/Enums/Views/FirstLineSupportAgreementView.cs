using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on FirstLineSupportAgreements.
    /// </summary>
    public enum FirstLineSupportAgreementView
    {
        /// <summary>
        /// First Line Support Agreements.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All FirstLineSupportAgreements which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
