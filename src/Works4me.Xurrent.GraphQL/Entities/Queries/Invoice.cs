using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/invoice/">Invoice</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Invoice")]
    public sealed class Invoice : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The end date of the period over which the invoice is to be amortized.
        /// </summary>
        [XurrentField("amortizationEnd")]
#if NET6_0_OR_GREATER
        public DateOnly? AmortizationEnd { get; internal set; }
#else
        public DateTime? AmortizationEnd { get; internal set; }
#endif

        /// <summary>
        /// The start date of the period over which the invoice is to be amortized.
        /// </summary>
        [XurrentField("amortizationStart")]
#if NET6_0_OR_GREATER
        public DateOnly? AmortizationStart { get; internal set; }
#else
        public DateTime? AmortizationStart { get; internal set; }
#endif

        /// <summary>
        /// Whether the invoice amount is to be amortized over time.
        /// </summary>
        [XurrentField("amortize")]
        public bool? Amortize { get; internal set; }

        /// <summary>
        /// The product of the <c>unitPrice</c> field value and the <c>quantity</c> field value.
        /// </summary>
        [XurrentField("amount")]
        public decimal? Amount { get; internal set; }

        [XurrentField("configurationItems")]
        internal PagedResponse<ConfigurationItem>? ConfigurationItemsCollection { get; set; }
        /// <summary>
        /// The configuration items linked to this invoice.
        /// </summary>
        public ReadOnlyDataCollection<ConfigurationItem>? ConfigurationItems { get => ConfigurationItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<ConfigurationItem>(ConfigurationItemsCollection.Data); }

        /// <summary>
        /// The contract linked to this invoice.
        /// </summary>
        [XurrentField("contract")]
        public Contract? Contract { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Currency of the <c>amount</c> value of the invoice.
        /// </summary>
        [XurrentField("currency")]
        public Currency? Currency { get; internal set; }

        /// <summary>
        /// Whether or not the invoice should be depreciated and if so, which depreciation method is to be applied. When creating a new invoice and a value is not specified for this field, and the invoice is related to a configuration item, the value is set to the depreciation method of the product of the configuration item.<br />
        /// Valid values are:<br />
        ///   • <c>not_depreciated</c>: Not Depreciated.<br />
        ///   • <c>double_declining_balance</c>: Double Declining Balance.<br />
        ///   • <c>reducing_balance</c>: Reducing Balance (or Diminishing Value).<br />
        ///   • <c>straight_line</c>: Straight Line (or Prime Cost).<br />
        ///   • <c>sum_of_the_years_digits</c>: Sum of the Year's Digits.<br />
        /// </summary>
        [XurrentField("depreciationMethod")]
        public ProductDepreciationMethod? DepreciationMethod { get; internal set; }

        /// <summary>
        /// The date on which to start depreciating the asset.
        /// </summary>
        [XurrentField("depreciationStart")]
#if NET6_0_OR_GREATER
        public DateOnly? DepreciationStart { get; internal set; }
#else
        public DateTime? DepreciationStart { get; internal set; }
#endif

        /// <summary>
        /// Short description of what was acquired.
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        /// <summary>
        /// The unique identifier by which the invoice is known in the financial system.
        /// </summary>
        [XurrentField("financialID")]
        public string? FinancialID { get; internal set; }

        /// <summary>
        /// The first line support agreement linked to this invoice.
        /// </summary>
        [XurrentField("flsa")]
        public FirstLineSupportAgreement? Flsa { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The date on which the invoice was sent out by the supplier.
        /// </summary>
        [XurrentField("invoiceDate")]
#if NET6_0_OR_GREATER
        public DateOnly? InvoiceDate { get; internal set; }
#else
        public DateTime? InvoiceDate { get; internal set; }
#endif

        /// <summary>
        /// The invoice number that the supplier specified on the invoice.
        /// </summary>
        [XurrentField("invoiceNr")]
        public string? InvoiceNr { get; internal set; }

        /// <summary>
        /// The number of the purchase order that was sent to supplier.
        /// </summary>
        [XurrentField("poNr")]
        public string? PoNr { get; internal set; }

        /// <summary>
        /// The project linked to this invoice.
        /// </summary>
        [XurrentField("project")]
        public Project? Project { get; internal set; }

        /// <summary>
        /// The number of units that were acquired.
        /// </summary>
        [XurrentField("quantity")]
        public decimal? Quantity { get; internal set; }

        /// <summary>
        /// Used to specify the yearly rate that should be applied to calculate the depreciation of the invoice using the reducing balance (or diminishing value) method. When creating a new invoice and a value is not specified for this field, and the invoice is related to a CI, the value is set to the rate of the CI's product.
        /// </summary>
        [XurrentField("rate")]
        public long? Rate { get; internal set; }

        /// <summary>
        /// Any additional information about the contract that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks { get; internal set; }

        [XurrentField("remarksAttachments")]
        internal PagedResponse<Attachment>? RemarksAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? RemarksAttachments { get => RemarksAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(RemarksAttachmentsCollection.Data); }

        /// <summary>
        /// The value of this invoice at the end of its useful life (i.e. at the end of its depreciation period). When a value is not specified for this field, it is set to zero.
        /// </summary>
        [XurrentField("salvageValue")]
        public decimal? SalvageValue { get; internal set; }

        /// <summary>
        /// The currency of the salvage value of this invoice.
        /// </summary>
        [XurrentField("salvageValueCurrency")]
        public Currency? SalvageValueCurrency { get; internal set; }

        /// <summary>
        /// The service that covers this invoice.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

        /// <summary>
        /// The service level agreement linked to this invoice.
        /// </summary>
        [XurrentField("sla")]
        public ServiceLevelAgreement? Sla { get; internal set; }

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
        /// The organization from which the invoice was received.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The amount that the supplier has charged per unit that was acquired.
        /// </summary>
        [XurrentField("unitPrice")]
        public decimal? UnitPrice { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The number of years within which the invoice is to be depreciated. When creating a new invoice and a value is not specified for this field, and the invoice is related to a CI, the value is set to the useful life of the CI's product.
        /// </summary>
        [XurrentField("usefulLife")]
        public long? UsefulLife { get; internal set; }

        /// <summary>
        /// The workflow linked to this invoice.
        /// </summary>
        [XurrentField("workflow")]
        public Workflow? Workflow { get; internal set; }

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
            if (data is Invoice invoice)
            {
                ConfigurationItemsCollection?.Data?.AddRange(invoice.ConfigurationItems);
                RemarksAttachmentsCollection?.Data?.AddRange(invoice.RemarksAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ConfigurationItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ConfigurationItemsCollection.GetPageInfo("configurationItems", depth))
                    yield return pageInfo;

            if (RemarksAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RemarksAttachmentsCollection.GetPageInfo("remarksAttachments", depth))
                    yield return pageInfo;
        }
    }
}
