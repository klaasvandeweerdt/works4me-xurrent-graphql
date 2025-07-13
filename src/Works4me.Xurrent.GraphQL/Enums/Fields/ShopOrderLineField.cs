using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ShopOrderLine">ShopOrderLine</see> fields.
    /// </summary>
    public enum ShopOrderLineField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The completed at field.
        /// </summary>
        [XurrentEnum("completedAt")]
        CompletedAt,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The custom fields field.
        /// </summary>
        [XurrentEnum("customFields")]
        CustomFields,

        /// <summary>
        /// The fulfillment request field.
        /// </summary>
        [XurrentEnum("fulfillmentRequest")]
        FulfillmentRequest,

        /// <summary>
        /// The fulfillment task field.
        /// </summary>
        [XurrentEnum("fulfillmentTask")]
        FulfillmentTask,

        /// <summary>
        /// The fulfillment template field.
        /// </summary>
        [XurrentEnum("fulfillmentTemplate")]
        FulfillmentTemplate,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [XurrentEnum("lifeCycleState")]
        LifeCycleState,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The order field.
        /// </summary>
        [XurrentEnum("order")]
        Order,

        /// <summary>
        /// The ordered at field.
        /// </summary>
        [XurrentEnum("orderedAt")]
        OrderedAt,

        /// <summary>
        /// The price field.
        /// </summary>
        [XurrentEnum("price")]
        Price,

        /// <summary>
        /// The price currency field.
        /// </summary>
        [XurrentEnum("priceCurrency")]
        PriceCurrency,

        /// <summary>
        /// The provider order line field.
        /// </summary>
        [XurrentEnum("providerOrderLine")]
        ProviderOrderLine,

        /// <summary>
        /// The quantity field.
        /// </summary>
        [XurrentEnum("quantity")]
        Quantity,

        /// <summary>
        /// The recurring period field.
        /// </summary>
        [XurrentEnum("recurringPeriod")]
        RecurringPeriod,

        /// <summary>
        /// The recurring price field.
        /// </summary>
        [XurrentEnum("recurringPrice")]
        RecurringPrice,

        /// <summary>
        /// The recurring price currency field.
        /// </summary>
        [XurrentEnum("recurringPriceCurrency")]
        RecurringPriceCurrency,

        /// <summary>
        /// The requested by field.
        /// </summary>
        [XurrentEnum("requestedBy")]
        RequestedBy,

        /// <summary>
        /// The requested for field.
        /// </summary>
        [XurrentEnum("requestedFor")]
        RequestedFor,

        /// <summary>
        /// The shop article field.
        /// </summary>
        [XurrentEnum("shopArticle")]
        ShopArticle,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The status field.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// The total price field.
        /// </summary>
        [XurrentEnum("totalPrice")]
        TotalPrice,

        /// <summary>
        /// The total recurring price field.
        /// </summary>
        [XurrentEnum("totalRecurringPrice")]
        TotalRecurringPrice,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
