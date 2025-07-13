using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on AppOfferings.
    /// </summary>
    public enum AppOfferingView
    {
        /// <summary>
        /// App Offerings.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All AppOfferings which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
