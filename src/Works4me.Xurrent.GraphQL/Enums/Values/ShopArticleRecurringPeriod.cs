using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The shop article recurring period values.
    /// </summary>
    public enum ShopArticleRecurringPeriod
    {
        /// <summary>
        /// Monthly.
        /// </summary>
        [XurrentEnum("monthly")]
        Monthly,

        /// <summary>
        /// Yearly.
        /// </summary>
        [XurrentEnum("yearly")]
        Yearly
    }
}
