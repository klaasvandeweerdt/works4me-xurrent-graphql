using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ProductBacklogs.
    /// </summary>
    public enum ProductBacklogView
    {
        /// <summary>
        /// Product Backlogs.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ProductBacklogs which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
