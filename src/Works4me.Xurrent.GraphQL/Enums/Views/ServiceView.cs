using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Services.
    /// </summary>
    public enum ServiceView
    {
        /// <summary>
        /// Services.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Services which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
