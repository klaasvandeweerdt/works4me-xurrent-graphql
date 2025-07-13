using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Contracts.
    /// </summary>
    public enum ContractView
    {
        /// <summary>
        /// Contracts.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Contracts which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
