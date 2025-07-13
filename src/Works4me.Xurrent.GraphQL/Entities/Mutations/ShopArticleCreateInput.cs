using System;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shoparticlecreateinput/">ShopArticleCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class ShopArticleCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private string? _uiExtensionId;
        private bool? _disabled;
        private string? _reference;
        private string? _productId;
        private string? _fulfillmentTemplateId;
        private long? _deliveryDuration;
        private bool? _requiresShipping;
        private string? _calendarId;
        private string? _timeZone;
        private string? _shortDescription;
        private string? _fullDescription;
        private DateTime? _startAt;
        private DateTime? _endAt;
        private long? _maxQuantity;
        private decimal? _price;
        private Currency? _priceCurrency;
        private decimal? _recurringPrice;
        private Currency? _recurringPriceCurrency;
        private ShopArticleRecurringPeriod? _recurringPeriod;
        private string _name;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// UI extension that is to be applied to the record.
        /// </summary>
        [XurrentField("uiExtensionId")]
        public string? UiExtensionId
        {
            get => _uiExtensionId;
            set => _uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Whether the shop article is visible in the shop.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// This reference can be used to link the shop article to a shop order line using the Xurrent APIs or the Xurrent Import functionality.
        /// </summary>
        [XurrentField("reference")]
        public string? Reference
        {
            get => _reference;
            set => _reference = Set("reference", value);
        }

        /// <summary>
        /// Related product.
        /// </summary>
        [XurrentField("productId")]
        public string? ProductId
        {
            get => _productId;
            set => _productId = Set("productId", value);
        }

        /// <summary>
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        [XurrentField("fulfillmentTemplateId")]
        public string? FulfillmentTemplateId
        {
            get => _fulfillmentTemplateId;
            set => _fulfillmentTemplateId = Set("fulfillmentTemplateId", value);
        }

        /// <summary>
        /// The number of minutes it usually takes to deliver the shop article.
        /// </summary>
        [XurrentField("deliveryDuration")]
        public long? DeliveryDuration
        {
            get => _deliveryDuration;
            set => _deliveryDuration = Set("deliveryDuration", value);
        }

        /// <summary>
        /// Whether or not this is a physical article that requires shipping.
        /// </summary>
        [XurrentField("requiresShipping")]
        public bool? RequiresShipping
        {
            get => _requiresShipping;
            set => _requiresShipping = Set("requiresShipping", value);
        }

        /// <summary>
        /// Calendar that represents the work hours related to the fulfillment/delivery.
        /// </summary>
        [XurrentField("calendarId")]
        public string? CalendarId
        {
            get => _calendarId;
            set => _calendarId = Set("calendarId", value);
        }

        /// <summary>
        /// The Time zone related to the calendar.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// The shop description of the shop article.
        /// </summary>
        [XurrentField("shortDescription")]
        public string? ShortDescription
        {
            get => _shortDescription;
            set => _shortDescription = Set("shortDescription", value);
        }

        /// <summary>
        /// The full description of the shop article.
        /// </summary>
        [XurrentField("fullDescription")]
        public string? FullDescription
        {
            get => _fullDescription;
            set => _fullDescription = Set("fullDescription", value);
        }

        /// <summary>
        /// The moment the shop article becomes available in the shop.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt
        {
            get => _startAt;
            set => _startAt = Set("startAt", value);
        }

        /// <summary>
        /// After this moment the shop article is no longer available in the shop.
        /// </summary>
        [XurrentField("endAt")]
        public DateTime? EndAt
        {
            get => _endAt;
            set => _endAt = Set("endAt", value);
        }

        /// <summary>
        /// The largest number of units that may be bought at once.
        /// </summary>
        [XurrentField("maxQuantity")]
        public long? MaxQuantity
        {
            get => _maxQuantity;
            set => _maxQuantity = Set("maxQuantity", value);
        }

        /// <summary>
        /// The price of a single unit.
        /// </summary>
        [XurrentField("price")]
        public decimal? Price
        {
            get => _price;
            set => _price = Set("price", value);
        }

        /// <summary>
        /// The currency of the price of this shop article.
        /// </summary>
        [XurrentField("priceCurrency")]
        public Currency? PriceCurrency
        {
            get => _priceCurrency;
            set => _priceCurrency = Set("priceCurrency", value);
        }

        /// <summary>
        /// The recurring price of a single unit.
        /// </summary>
        [XurrentField("recurringPrice")]
        public decimal? RecurringPrice
        {
            get => _recurringPrice;
            set => _recurringPrice = Set("recurringPrice", value);
        }

        /// <summary>
        /// The currency of the recurring price of this shop article.
        /// </summary>
        [XurrentField("recurringPriceCurrency")]
        public Currency? RecurringPriceCurrency
        {
            get => _recurringPriceCurrency;
            set => _recurringPriceCurrency = Set("recurringPriceCurrency", value);
        }

        /// <summary>
        /// The frequency in which the recurring price is due.
        /// </summary>
        [XurrentField("recurringPeriod")]
        public ShopArticleRecurringPeriod? RecurringPeriod
        {
            get => _recurringPeriod;
            set => _recurringPeriod = Set("recurringPeriod", value);
        }

        /// <summary>
        /// The display name of the shop article.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCreateInput"/> class without providing the required values.
        /// </summary>
        public ShopArticleCreateInput()
        {
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCreateInput"/> class.
        /// </summary>
        public ShopArticleCreateInput(string name)
        {
            _name = Set("name", name);
        }
    }
}
