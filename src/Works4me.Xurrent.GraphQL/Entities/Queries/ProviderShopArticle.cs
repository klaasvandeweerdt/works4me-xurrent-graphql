using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/providershoparticle/">ProviderShopArticle</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ProviderShopArticle")]
    public sealed class ProviderShopArticle : IDataItem, INode
    {
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
        /// The full description of the shop article.
        /// </summary>
        [XurrentField("fullDescription")]
        public string? FullDescription { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
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
        /// The shop description of the shop article.
        /// </summary>
        [XurrentField("shortDescription")]
        public string? ShortDescription { get; internal set; }

        /// <summary>
        /// The moment the shop article becomes available in the shop.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt { get; internal set; }

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
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
