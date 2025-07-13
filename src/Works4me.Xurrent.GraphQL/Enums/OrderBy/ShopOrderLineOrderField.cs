using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields ShopOrderLine can be ordered on.
    /// </summary>
    public enum ShopOrderLineOrderField
    {
        /// <summary>
        /// Order by <c>CompletedAt</c>.
        /// </summary>
        [XurrentEnum("completedAt")]
        CompletedAt,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Name</c>.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Order by <c>OrderedAt</c>.
        /// </summary>
        [XurrentEnum("orderedAt")]
        OrderedAt,

        /// <summary>
        /// Order by <c>Price</c>.
        /// </summary>
        [XurrentEnum("price")]
        Price,

        /// <summary>
        /// Order by <c>Quantity</c>.
        /// </summary>
        [XurrentEnum("quantity")]
        Quantity,

        /// <summary>
        /// Order by <c>RecurringPrice</c>.
        /// </summary>
        [XurrentEnum("recurringPrice")]
        RecurringPrice,

        /// <summary>
        /// Order by <c>ShopOrderLineId</c>.
        /// </summary>
        [XurrentEnum("shopOrderLineId")]
        ShopOrderLineId,

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
        /// Order by <c>Status</c>.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
