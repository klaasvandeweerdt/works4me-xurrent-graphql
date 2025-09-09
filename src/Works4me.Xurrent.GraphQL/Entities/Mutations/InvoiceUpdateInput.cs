using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/invoiceupdateinput/">InvoiceUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class InvoiceUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _workflowId;
        private string? _projectId;
        private string? _slaId;
        private string? _flsaId;
        private string? _contractId;
        private Collection<string>? _ciIds;
        private bool? _amortize;
#if NET6_0_OR_GREATER
        private DateOnly? _amortizationStart;
#else
        private DateTime? _amortizationStart;
#endif
#if NET6_0_OR_GREATER
        private DateOnly? _amortizationEnd;
#else
        private DateTime? _amortizationEnd;
#endif
        private Currency? _currency;
        private ProductDepreciationMethod? _depreciationMethod;
#if NET6_0_OR_GREATER
        private DateOnly? _depreciationStart;
#else
        private DateTime? _depreciationStart;
#endif
        private string? _description;
#if NET6_0_OR_GREATER
        private DateOnly? _invoiceDate;
#else
        private DateTime? _invoiceDate;
#endif
        private string? _invoiceNr;
        private string? _poNr;
        private string? _financialID;
        private decimal? _quantity;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private string? _serviceId;
        private string? _supplierId;
        private long? _rate;
        private decimal? _salvageValue;
        private Currency? _salvageValueCurrency;
        private decimal? _unitPrice;
        private long? _usefulLife;
        private string _id;

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
        /// The workflow linked to this invoice.
        /// </summary>
        [XurrentField("workflowId")]
        public string? WorkflowId
        {
            get => _workflowId;
            set => _workflowId = Set("workflowId", value);
        }

        /// <summary>
        /// The project linked to this invoice.
        /// </summary>
        [XurrentField("projectId")]
        public string? ProjectId
        {
            get => _projectId;
            set => _projectId = Set("projectId", value);
        }

        /// <summary>
        /// The service level agreement linked to this invoice.
        /// </summary>
        [XurrentField("slaId")]
        public string? SlaId
        {
            get => _slaId;
            set => _slaId = Set("slaId", value);
        }

        /// <summary>
        /// The first line support agreement linked to this invoice.
        /// </summary>
        [XurrentField("flsaId")]
        public string? FlsaId
        {
            get => _flsaId;
            set => _flsaId = Set("flsaId", value);
        }

        /// <summary>
        /// The contract linked to this invoice.
        /// </summary>
        [XurrentField("contractId")]
        public string? ContractId
        {
            get => _contractId;
            set => _contractId = Set("contractId", value);
        }

        /// <summary>
        /// The configuration items linked to this invoice.
        /// </summary>
        [XurrentField("ciIds")]
        public Collection<string>? CiIds
        {
            get => _ciIds;
            set => _ciIds = Set("ciIds", value);
        }

        /// <summary>
        /// Whether the invoice amount is to be amortized over time.
        /// </summary>
        [XurrentField("amortize")]
        public bool? Amortize
        {
            get => _amortize;
            set => _amortize = Set("amortize", value);
        }

        /// <summary>
        /// The start date of the period over which the invoice is to be amortized.
        /// </summary>
        [XurrentField("amortizationStart")]
#if NET6_0_OR_GREATER
        public DateOnly? AmortizationStart
#else
        public DateTime? AmortizationStart
#endif
        {
            get => _amortizationStart;
            set => _amortizationStart = Set("amortizationStart", value);
        }

        /// <summary>
        /// The end date of the period over which the invoice is to be amortized.
        /// </summary>
        [XurrentField("amortizationEnd")]
#if NET6_0_OR_GREATER
        public DateOnly? AmortizationEnd
#else
        public DateTime? AmortizationEnd
#endif
        {
            get => _amortizationEnd;
            set => _amortizationEnd = Set("amortizationEnd", value);
        }

        /// <summary>
        /// Currency of the <c>amount</c> value of the invoice.
        /// </summary>
        [XurrentField("currency")]
        public Currency? Currency
        {
            get => _currency;
            set => _currency = Set("currency", value);
        }

        /// <summary>
        /// Used to specify whether or not configuration items that are linked to this invoice are depreciated.<br />
        /// and if so, which depreciation method is to be applied. Valid values are:<br />
        ///   • <c>not_depreciated</c>: Not Depreciated.<br />
        ///   • <c>double_declining_balance</c>: Double Declining Balance.<br />
        ///   • <c>reducing_balance</c>: Reducing Balance (or Diminishing Value).<br />
        ///   • <c>straight_line</c>: Straight Line (or Prime Cost).<br />
        ///   • <c>sum_of_the_years_digits</c>: Sum of the Year's Digits.<br />
        /// </summary>
        [XurrentField("depreciationMethod")]
        public ProductDepreciationMethod? DepreciationMethod
        {
            get => _depreciationMethod;
            set => _depreciationMethod = Set("depreciationMethod", value);
        }

        /// <summary>
        /// The date on which to start depreciating the asset.
        /// </summary>
        [XurrentField("depreciationStart")]
#if NET6_0_OR_GREATER
        public DateOnly? DepreciationStart
#else
        public DateTime? DepreciationStart
#endif
        {
            get => _depreciationStart;
            set => _depreciationStart = Set("depreciationStart", value);
        }

        /// <summary>
        /// Short description of what was acquired.
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// The date on which the invoice was sent out by the supplier.
        /// </summary>
        [XurrentField("invoiceDate")]
#if NET6_0_OR_GREATER
        public DateOnly? InvoiceDate
#else
        public DateTime? InvoiceDate
#endif
        {
            get => _invoiceDate;
            set => _invoiceDate = Set("invoiceDate", value);
        }

        /// <summary>
        /// The invoice number that the supplier specified on the invoice.
        /// </summary>
        [XurrentField("invoiceNr")]
        public string? InvoiceNr
        {
            get => _invoiceNr;
            set => _invoiceNr = Set("invoiceNr", value);
        }

        /// <summary>
        /// Number of the purchase order that was used to order the (lease of the) configuration item from the supplier.
        /// </summary>
        [XurrentField("poNr")]
        public string? PoNr
        {
            get => _poNr;
            set => _poNr = Set("poNr", value);
        }

        /// <summary>
        /// The unique identifier by which the invoice is known in the financial system.
        /// </summary>
        [XurrentField("financialID")]
        public string? FinancialID
        {
            get => _financialID;
            set => _financialID = Set("financialID", value);
        }

        /// <summary>
        /// The number of units that were acquired.
        /// </summary>
        [XurrentField("quantity")]
        public decimal? Quantity
        {
            get => _quantity;
            set => _quantity = Set("quantity", value);
        }

        /// <summary>
        /// Any additional information about the invoice that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks
        {
            get => _remarks;
            set => _remarks = Set("remarks", value);
        }

        /// <summary>
        /// The attachments used in the <c>remarks</c> field.
        /// </summary>
        [XurrentField("remarksAttachments")]
        public Collection<AttachmentInput>? RemarksAttachments
        {
            get => _remarksAttachments;
            set => _remarksAttachments = Set("remarksAttachments", value);
        }

        /// <summary>
        /// The service that covers this invoice. Can only be set when the invoice is linked to a contract or configuration items.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Identifier of the organization from which the invoice was received.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Used to specify the yearly rate that should be applied to calculate the depreciation of the configuration item (CI) using the reducing balance (or diminishing value) method. When creating a new CI and a value is not specified for this field, it is set to the rate of the CI's product.
        /// </summary>
        [XurrentField("rate")]
        public long? Rate
        {
            get => _rate;
            set => _rate = Set("rate", value);
        }

        /// <summary>
        /// The value of this configuration item at the end of its useful life (i.e. at the end of its depreciation period). When a value is not specified for this field, it is set to zero.
        /// </summary>
        [XurrentField("salvageValue")]
        public decimal? SalvageValue
        {
            get => _salvageValue;
            set => _salvageValue = Set("salvageValue", value);
        }

        /// <summary>
        /// The currency of the salvage value attributed to this configuration item.
        /// </summary>
        [XurrentField("salvageValueCurrency")]
        public Currency? SalvageValueCurrency
        {
            get => _salvageValueCurrency;
            set => _salvageValueCurrency = Set("salvageValueCurrency", value);
        }

        /// <summary>
        /// The amount that the supplier has charged per unit that was acquired.
        /// </summary>
        [XurrentField("unitPrice")]
        public decimal? UnitPrice
        {
            get => _unitPrice;
            set => _unitPrice = Set("unitPrice", value);
        }

        /// <summary>
        /// The number of years within which the configuration item is to be depreciated. When creating a new CI and a value is not specified for this field, it is set to the useful life of the CI's product.
        /// </summary>
        [XurrentField("usefulLife")]
        public long? UsefulLife
        {
            get => _usefulLife;
            set => _usefulLife = Set("usefulLife", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceUpdateInput"/> class without providing the required values.
        /// </summary>
        public InvoiceUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceUpdateInput"/> class.
        /// </summary>
        public InvoiceUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
