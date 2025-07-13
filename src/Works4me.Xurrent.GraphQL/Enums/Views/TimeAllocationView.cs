using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on TimeAllocations.
    /// </summary>
    public enum TimeAllocationView
    {
        /// <summary>
        /// Time Allocations.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All TimeAllocations which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
