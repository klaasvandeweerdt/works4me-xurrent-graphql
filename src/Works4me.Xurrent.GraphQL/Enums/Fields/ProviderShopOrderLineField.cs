using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProviderShopOrderLine">ProviderShopOrderLine</see> fields.
    /// </summary>
    public enum ProviderShopOrderLineField
    {
        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

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
        /// The total price field.
        /// </summary>
        [XurrentEnum("totalPrice")]
        TotalPrice,

        /// <summary>
        /// The total recurring price field.
        /// </summary>
        [XurrentEnum("totalRecurringPrice")]
        TotalRecurringPrice
    }
}
