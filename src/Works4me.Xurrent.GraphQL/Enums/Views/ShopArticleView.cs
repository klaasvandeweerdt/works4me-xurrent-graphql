using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ShopArticles.
    /// </summary>
    public enum ShopArticleView
    {
        /// <summary>
        /// Shop Articles.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ShopArticles which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
