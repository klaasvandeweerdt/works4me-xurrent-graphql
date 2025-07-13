using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProviderShopArticle">ProviderShopArticle</see> fields.
    /// </summary>
    public enum ProviderShopArticleField
    {
        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The end at field.
        /// </summary>
        [XurrentEnum("endAt")]
        EndAt,

        /// <summary>
        /// The full description field.
        /// </summary>
        [XurrentEnum("fullDescription")]
        FullDescription,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The max quantity field.
        /// </summary>
        [XurrentEnum("maxQuantity")]
        MaxQuantity,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The picture uri field.
        /// </summary>
        [XurrentEnum("pictureUri")]
        PictureUri,

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
        /// The short description field.
        /// </summary>
        [XurrentEnum("shortDescription")]
        ShortDescription,

        /// <summary>
        /// The start at field.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt
    }
}
