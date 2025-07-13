using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ServiceLevelAgreements.
    /// </summary>
    public enum ServiceLevelAgreementView
    {
        /// <summary>
        /// Service Level Agreements.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ServiceLevelAgreements which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
