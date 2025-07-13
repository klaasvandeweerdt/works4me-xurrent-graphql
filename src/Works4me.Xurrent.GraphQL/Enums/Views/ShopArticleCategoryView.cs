using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ShopArticleCategories.
    /// </summary>
    public enum ShopArticleCategoryView
    {
        /// <summary>
        /// Shop Article Categories.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ShopArticleCategories which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
