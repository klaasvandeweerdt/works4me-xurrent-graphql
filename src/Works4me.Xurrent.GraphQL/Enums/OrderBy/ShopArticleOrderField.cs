using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields ShopArticle can be ordered on.
    /// </summary>
    public enum ShopArticleOrderField
    {
        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>DeliveryDuration</c>.
        /// </summary>
        [XurrentEnum("deliveryDuration")]
        DeliveryDuration,

        /// <summary>
        /// Order by <c>Price</c>.
        /// </summary>
        [XurrentEnum("price")]
        Price,

        /// <summary>
        /// Order by <c>RecurringPrice</c>.
        /// </summary>
        [XurrentEnum("recurringPrice")]
        RecurringPrice,

        /// <summary>
        /// Order by <c>Reference</c>.
        /// </summary>
        [XurrentEnum("reference")]
        Reference,

        /// <summary>
        /// Order by <c>ShopArticleId</c>.
        /// </summary>
        [XurrentEnum("shopArticleId")]
        ShopArticleId,

        /// <summary>
        /// Order by <c>Source</c>.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Order by <c>SourceID</c>.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
