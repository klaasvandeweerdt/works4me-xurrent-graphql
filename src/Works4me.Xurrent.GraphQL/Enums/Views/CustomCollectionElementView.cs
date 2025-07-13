using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on CustomCollectionElements.
    /// </summary>
    public enum CustomCollectionElementView
    {
        /// <summary>
        /// Custom Collection Elements.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All CustomCollectionElements which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
