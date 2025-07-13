using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which ShopOrderLine records are returned.
    /// </summary>
    public enum ShopOrderLineFilterField
    {
        /// <summary>
        /// Completed in supplied range.
        /// </summary>
        [XurrentEnum("completedAt")]
        CompletedAt,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Filter on Order account.
        /// </summary>
        [XurrentEnum("orderAccount")]
        OrderAccount,

        /// <summary>
        /// Ordered in supplied range.
        /// </summary>
        [XurrentEnum("orderedAt")]
        OrderedAt,

        /// <summary>
        /// Filter on Price.
        /// </summary>
        [XurrentEnum("price")]
        Price,

        /// <summary>
        /// Filter on Provider account.
        /// </summary>
        [XurrentEnum("providerAccount")]
        ProviderAccount,

        /// <summary>
        /// Filter on Provider price.
        /// </summary>
        [XurrentEnum("providerPrice")]
        ProviderPrice,

        /// <summary>
        /// Filter on Provider recurring period.
        /// </summary>
        [XurrentEnum("providerRecurringPeriod")]
        ProviderRecurringPeriod,

        /// <summary>
        /// Filter on Provider recurring price.
        /// </summary>
        [XurrentEnum("providerRecurringPrice")]
        ProviderRecurringPrice,

        /// <summary>
        /// Filter on Quantity.
        /// </summary>
        [XurrentEnum("quantity")]
        Quantity,

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
        /// Filter on Requester.
        /// </summary>
        [XurrentEnum("requestedFor")]
        RequestedFor,

        /// <summary>
        /// Filter on Requester account.
        /// </summary>
        [XurrentEnum("requesterAccount")]
        RequesterAccount,

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
        /// Filter on Status.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
