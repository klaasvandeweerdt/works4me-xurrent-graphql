using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which ShopArticle records are returned.
    /// </summary>
    public enum ShopArticleFilterField
    {
        /// <summary>
        /// Filter on Category.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Filter on Delivery duration.
        /// </summary>
        [XurrentEnum("deliveryDuration")]
        DeliveryDuration,

        /// <summary>
        /// Include only if Disabled matches supplied value.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// End in supplied range.
        /// </summary>
        [XurrentEnum("endAt")]
        EndAt,

        /// <summary>
        /// Filter on Fulfillment Template.
        /// </summary>
        [XurrentEnum("fulfillmentTemplate")]
        FulfillmentTemplate,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Max. quantity.
        /// </summary>
        [XurrentEnum("maxQuantity")]
        MaxQuantity,

        /// <summary>
        /// Filter on Min. quantity.
        /// </summary>
        [XurrentEnum("minQuantity")]
        MinQuantity,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Filter on Price.
        /// </summary>
        [XurrentEnum("price")]
        Price,

        /// <summary>
        /// Filter on Product.
        /// </summary>
        [XurrentEnum("product")]
        Product,

        /// <summary>
        /// Filter on Provider account.
        /// </summary>
        [XurrentEnum("providerAccount")]
        ProviderAccount,

        /// <summary>
        /// Filter on Recurring period.
        /// </summary>
        [XurrentEnum("recurringPeriod")]
        RecurringPeriod,

        /// <summary>
        /// Filter on Recurring price.
        /// </summary>
        [XurrentEnum("recurringPrice")]
        RecurringPrice,

        /// <summary>
        /// Filter on Reference.
        /// </summary>
        [XurrentEnum("reference")]
        Reference,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Filter on Source ID.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Start in supplied range.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
