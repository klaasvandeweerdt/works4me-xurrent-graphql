using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ProductCategories.
    /// </summary>
    public enum ProductCategoryView
    {
        /// <summary>
        /// Product Categories.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ProductCategories which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
