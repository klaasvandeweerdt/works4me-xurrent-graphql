using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Archives.
    /// </summary>
    public enum ArchiveView
    {
        /// <summary>
        /// Archive.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Archives which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
