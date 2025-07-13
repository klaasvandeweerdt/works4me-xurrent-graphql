using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ServiceOfferings.
    /// </summary>
    public enum ServiceOfferingView
    {
        /// <summary>
        /// Service Offerings.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ServiceOfferings which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
