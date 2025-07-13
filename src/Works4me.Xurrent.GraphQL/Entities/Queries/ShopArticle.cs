using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shoparticle/">ShopArticle</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ShopArticle")]
    public sealed class ShopArticle : IDataItem, IHasTranslations, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Calendar that represents the work hours related to the fulfillment/delivery.
        /// </summary>
        [XurrentField("calendar")]
        public Calendar? Calendar { get; internal set; }

        /// <summary>
        /// Related category.
        /// </summary>
        [XurrentField("category")]
        public ShopArticleCategory? Category { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The number of minutes it usually takes to deliver the shop article.
        /// </summary>
        [XurrentField("deliveryDuration")]
        public long? DeliveryDuration { get; internal set; }

        /// <summary>
        /// Whether the shop article is visible in the shop.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// After this moment the shop article is no longer available in the shop.
        /// </summary>
        [XurrentField("endAt")]
        public DateTime? EndAt { get; internal set; }

        /// <summary>
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        [XurrentField("fulfillmentTemplate")]
        public RequestTemplate? FulfillmentTemplate { get; internal set; }

        /// <summary>
        /// The full description of the shop article.
        /// </summary>
        [XurrentField("fullDescription")]
        public string? FullDescription { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The largest number of units that may be bought at once.
        /// </summary>
        [XurrentField("maxQuantity")]
        public long? MaxQuantity { get; internal set; }

        /// <summary>
        /// The display name of the shop article.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// The price of a single unit.
        /// </summary>
        [XurrentField("price")]
        public decimal? Price { get; internal set; }

        /// <summary>
        /// The currency of the price of this shop article.
        /// </summary>
        [XurrentField("priceCurrency")]
        public Currency? PriceCurrency { get; internal set; }

        /// <summary>
        /// Related product.
        /// </summary>
        [XurrentField("product")]
        public Product? Product { get; internal set; }

        /// <summary>
        /// Information from the provider.
        /// </summary>
        [XurrentField("providerShopArticle")]
        public ProviderShopArticle? ProviderShopArticle { get; internal set; }

        /// <summary>
        /// The frequency in which the recurring price is due.
        /// </summary>
        [XurrentField("recurringPeriod")]
        public ShopArticleRecurringPeriod? RecurringPeriod { get; internal set; }

        /// <summary>
        /// The recurring price of a single unit.
        /// </summary>
        [XurrentField("recurringPrice")]
        public decimal? RecurringPrice { get; internal set; }

        /// <summary>
        /// The currency of the recurring price of this shop article.
        /// </summary>
        [XurrentField("recurringPriceCurrency")]
        public Currency? RecurringPriceCurrency { get; internal set; }

        /// <summary>
        /// This reference can be used to link the shop article to a shop order line using the Xurrent APIs or the Xurrent Import functionality.
        /// </summary>
        [XurrentField("reference")]
        public string? Reference { get; internal set; }

        /// <summary>
        /// Whether or not this is a physical article that requires shipping.
        /// </summary>
        [XurrentField("requiresShipping")]
        public bool? RequiresShipping { get; internal set; }

        /// <summary>
        /// The shop description of the shop article.
        /// </summary>
        [XurrentField("shortDescription")]
        public string? ShortDescription { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The moment the shop article becomes available in the shop.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The Time zone related to the calendar.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

        [XurrentField("translations")]
        internal PagedResponse<Translation>? TranslationsCollection { get; set; }
        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Translation>? Translations { get => TranslationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Translation>(TranslationsCollection.Data); }

        /// <summary>
        /// UI extension that is to be used when the shop article is ordered.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is ShopArticle shopArticle)
            {
                TranslationsCollection?.Data?.AddRange(shopArticle.Translations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (TranslationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TranslationsCollection.GetPageInfo("translations", depth))
                    yield return pageInfo;
        }
    }
}
