using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ShopOrderLines.
    /// </summary>
    public enum ShopOrderLineView
    {
        /// <summary>
        /// All Shop Order Lines.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived Shop Order Lines.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// All ShopOrderLines which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// My Shop Order Lines.
        /// </summary>
        [XurrentEnum("personal")]
        Personal,

        /// <summary>
        /// Trashed Shop Order Lines.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
