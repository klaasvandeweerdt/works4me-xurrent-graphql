using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/productupdateinput/">ProductUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ProductUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private string? _uiExtensionId;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _brand;
        private string? _category;
        private ProductDepreciationMethod? _depreciationMethod;
        private bool? _disabled;
        private string? _financialOwnerId;
        private string? _model;
        private string? _name;
        private string? _productID;
        private long? _rate;
        private RecurrenceInput? _recurrence;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private decimal? _salvageValue;
        private Currency? _salvageValueCurrency;
        private string? _serviceId;
        private string? _supplierId;
        private string? _supportTeamId;
        private long? _usefulLife;
        private string? _workflowManagerId;
        private string? _workflowTemplateId;
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
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [XurrentField("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => _customFields;
            set => _customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [XurrentField("customFieldsAttachments")]
        public Collection<AttachmentInput>? CustomFieldsAttachments
        {
            get => _customFieldsAttachments;
            set => _customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// The brand name is typically the name of the product's manufacturer.
        /// </summary>
        [XurrentField("brand")]
        public string? Brand
        {
            get => _brand;
            set => _brand = Set("brand", value);
        }

        /// <summary>
        /// The appropriate product category for the product.
        /// </summary>
        [XurrentField("category")]
        public string? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// Used to specify whether or not configuration items that are based on the product are typically depreciated and if so, which depreciation method is normally applied. Valid values are:<br />
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
        /// Whether the product may no longer be used to register new configuration items.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the internal organization which budget is normally used to obtain the product.
        /// </summary>
        [XurrentField("financialOwnerId")]
        public string? FinancialOwnerId
        {
            get => _financialOwnerId;
            set => _financialOwnerId = Set("financialOwnerId", value);
        }

        /// <summary>
        /// The model of the product.
        /// </summary>
        [XurrentField("model")]
        public string? Model
        {
            get => _model;
            set => _model = Set("model", value);
        }

        /// <summary>
        /// The name of the product. Fill out the Brand, Model, Product ID (optional) and Category fields to automatically generate a name based on the values entered in these fields.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The unique identifier of the product that is used by the manufacturer. The concatenation of <c>brand</c> and <c>productID</c> must be unique within a Xurrent account.
        /// </summary>
        [XurrentField("productID")]
        public string? ProductID
        {
            get => _productID;
            set => _productID = Set("productID", value);
        }

        /// <summary>
        /// The yearly rate that should normally be applied to calculate the depreciation of configuration items that are based on the product using the reducing balance (or diminishing value) method.
        /// </summary>
        [XurrentField("rate")]
        public long? Rate
        {
            get => _rate;
            set => _rate = Set("rate", value);
        }

        /// <summary>
        /// Recurrence for maintenance of configuration items created from the product.
        /// </summary>
        [XurrentField("recurrence")]
        public RecurrenceInput? Recurrence
        {
            get => _recurrence;
            set => _recurrence = Set("recurrence", value);
        }

        /// <summary>
        /// Any additional information about the product that might prove useful.
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
        /// Identifier of the Service which Service Instances would typically include the product.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Identifier of the organization from which the product is typically obtained. If the product is developed internally, select the internal organization that develops it. Note that a lease company should be selected in this field if the product is normally leased.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the team responsible for maintaining the product's information in the configuration management database (CMDB).
        /// </summary>
        [XurrentField("supportTeamId")]
        public string? SupportTeamId
        {
            get => _supportTeamId;
            set => _supportTeamId = Set("supportTeamId", value);
        }

        /// <summary>
        /// The number of years within which configuration items that are based on the product are typically depreciated.
        /// </summary>
        [XurrentField("usefulLife")]
        public long? UsefulLife
        {
            get => _usefulLife;
            set => _usefulLife = Set("usefulLife", value);
        }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [XurrentField("workflowManagerId")]
        public string? WorkflowManagerId
        {
            get => _workflowManagerId;
            set => _workflowManagerId = Set("workflowManagerId", value);
        }

        /// <summary>
        /// The workflow template that is used to periodically maintain configuration items created from the product.
        /// </summary>
        [XurrentField("workflowTemplateId")]
        public string? WorkflowTemplateId
        {
            get => _workflowTemplateId;
            set => _workflowTemplateId = Set("workflowTemplateId", value);
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
        /// Initializes a new instance of the <see cref="ProductUpdateInput"/> class without providing the required values.
        /// </summary>
        public ProductUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUpdateInput"/> class.
        /// </summary>
        public ProductUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
