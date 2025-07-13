using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Trashes.
    /// </summary>
    public enum TrashView
    {
        /// <summary>
        /// Trash.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Trashes which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
