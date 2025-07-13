using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shoporderline/">ShopOrderLine</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ShopOrderLine")]
    public sealed class ShopOrderLine : IDataItem, IHasLifeCycleState, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        [XurrentField("addresses")]
        internal PagedResponse<Address>? AddressesCollection { get; set; }
        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public ReadOnlyDataCollection<Address>? Addresses { get => AddressesCollection?.Data is null ? null : new ReadOnlyDataCollection<Address>(AddressesCollection.Data); }

        /// <summary>
        /// Automatically set to the date and time at which the shop order line is saved with the status "Completed".
        /// </summary>
        [XurrentField("completedAt")]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [XurrentField("customFields")]
        internal CustomFieldCollection? CustomFieldCollection { get; set; }
        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public IReadOnlyCustomFieldCollection? CustomFields { get => CustomFieldCollection is null ? null : new ReadOnlyCustomFieldCollection(CustomFieldCollection); }

        [XurrentField("customFieldsAttachments")]
        internal PagedResponse<Attachment>? CustomFieldsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? CustomFieldsAttachments { get => CustomFieldsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(CustomFieldsAttachmentsCollection.Data); }

        /// <summary>
        /// The fulfillment request that is assigned to the provider to fulfil this shop order line.
        /// </summary>
        [XurrentField("fulfillmentRequest")]
        public Request? FulfillmentRequest { get; internal set; }

        /// <summary>
        /// The fulfillment task of the purchase workflow generated to fulfil this shop order line.
        /// </summary>
        [XurrentField("fulfillmentTask")]
        public WorkflowTask? FulfillmentTask { get; internal set; }

        /// <summary>
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        [XurrentField("fulfillmentTemplate")]
        public RequestTemplate? FulfillmentTemplate { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The name of the shop article.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The request for purchase that includes this shop order line.
        /// </summary>
        [XurrentField("order")]
        public Request? Order { get; internal set; }

        /// <summary>
        /// After this moment the shop article is no longer available in the shop.
        /// </summary>
        [XurrentField("orderedAt")]
        public DateTime? OrderedAt { get; internal set; }

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
        /// Information from the provider.
        /// </summary>
        [XurrentField("providerOrderLine")]
        public ProviderShopOrderLine? ProviderOrderLine { get; internal set; }

        /// <summary>
        /// The number units ordered.
        /// </summary>
        [XurrentField("quantity")]
        public long? Quantity { get; internal set; }

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
        /// The person creating the shop order line.
        /// </summary>
        [XurrentField("requestedBy")]
        public Person? RequestedBy { get; internal set; }

        /// <summary>
        /// The person for whom the shop order line was submitted.
        /// </summary>
        [XurrentField("requestedFor")]
        public Person? RequestedFor { get; internal set; }

        /// <summary>
        /// The shop article that is ordered.
        /// </summary>
        [XurrentField("shopArticle")]
        public ShopArticle? ShopArticle { get; internal set; }

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
        /// The status of the shop order line.
        /// </summary>
        [XurrentField("status")]
        public ShopOrderLineStatus? Status { get; internal set; }

        /// <summary>
        /// The total price of a all units.
        /// </summary>
        [XurrentField("totalPrice")]
        public decimal? TotalPrice { get; internal set; }

        /// <summary>
        /// The recurring price of a all units.
        /// </summary>
        [XurrentField("totalRecurringPrice")]
        public decimal? TotalRecurringPrice { get; internal set; }

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
            if (data is ShopOrderLine shopOrderLine)
            {
                AddressesCollection?.Data?.AddRange(shopOrderLine.Addresses);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(shopOrderLine.CustomFieldsAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AddressesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AddressesCollection.GetPageInfo("addresses", depth))
                    yield return pageInfo;

            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;
        }
    }
}
