using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/configurationitemupdateinput/">ConfigurationItemUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ConfigurationItemUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private Collection<string>? _alternateNames;
        private string? _assetID;
#if NET6_0_OR_GREATER
        private DateOnly? _endOfSupportDate;
#else
        private DateTime? _endOfSupportDate;
#endif
        private Collection<string>? _contractIds;
        private string? _financialOwnerId;
#if NET6_0_OR_GREATER
        private DateOnly? _inUseSince;
#else
        private DateTime? _inUseSince;
#endif
        private string? _label;
        private DateTime? _lastSeenAt;
#if NET6_0_OR_GREATER
        private DateOnly? _licenseExpiryDate;
#else
        private DateTime? _licenseExpiryDate;
#endif
        private CiLicenseType? _licenseType;
        private Collection<string>? _licensedSiteIds;
        private string? _location;
        private string? _name;
        private long? _nrOfCores;
        private long? _nrOfLicenses;
        private long? _nrOfProcessors;
        private string? _operatingSystemId;
        private string? _productId;
        private decimal? _purchaseValue;
        private Currency? _purchaseValueCurrency;
        private decimal? _ramAmount;
        private RecurrenceInput? _recurrence;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private ProductCategoryRuleSet? _ruleSet;
        private string? _serialNr;
        private string? _serviceId;
        private Collection<string>? _serviceInstanceIds;
        private string? _siteId;
        private bool? _siteLicense;
        private CiStatus? _status;
        private string? _supplierId;
        private string? _supportTeamId;
        private string? _systemID;
        private bool? _temporaryLicense;
        private Collection<string>? _userIds;
#if NET6_0_OR_GREATER
        private DateOnly? _warrantyExpiryDate;
#else
        private DateTime? _warrantyExpiryDate;
#endif
        private string? _workflowManagerId;
        private string? _workflowTemplateId;
        private Collection<CiRelationInput>? _newCiRelations;
        private string _id;
        private Collection<string>? _ciRelationsToDelete;

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
        /// Alternate names the configuration item is also known by.
        /// </summary>
        [XurrentField("alternateNames")]
        public Collection<string>? AlternateNames
        {
            get => _alternateNames;
            set => _alternateNames = Set("alternateNames", value);
        }

        /// <summary>
        /// Asset identifier of the configuration item.
        /// </summary>
        [XurrentField("assetID")]
        public string? AssetID
        {
            get => _assetID;
            set => _assetID = Set("assetID", value);
        }

        /// <summary>
        /// The date at which the support for this configuration item ends.
        /// </summary>
        [XurrentField("endOfSupportDate")]
#if NET6_0_OR_GREATER
        public DateOnly? EndOfSupportDate
#else
        public DateTime? EndOfSupportDate
#endif
        {
            get => _endOfSupportDate;
            set => _endOfSupportDate = Set("endOfSupportDate", value);
        }

        /// <summary>
        /// Identifiers of the contracts of this configuration item.
        /// </summary>
        [XurrentField("contractIds")]
        public Collection<string>? ContractIds
        {
            get => _contractIds;
            set => _contractIds = Set("contractIds", value);
        }

        /// <summary>
        /// Identifier of the internal organization which budget is used to pay for the configuration item. If the CI is leased or rented, the organization that pays the lease or rent is selected in this field. When creating a new CI and a value is not specified for this field, it is set to the financial owner of the CI's product.
        /// </summary>
        [XurrentField("financialOwnerId")]
        public string? FinancialOwnerId
        {
            get => _financialOwnerId;
            set => _financialOwnerId = Set("financialOwnerId", value);
        }

        /// <summary>
        /// The date on which the expense for the configuration item (CI) was incurred or, if the CI is depreciated over time, the date on which the depreciation was started. This is typically the invoice date.
        /// </summary>
        [XurrentField("inUseSince")]
#if NET6_0_OR_GREATER
        public DateOnly? InUseSince
#else
        public DateTime? InUseSince
#endif
        {
            get => _inUseSince;
            set => _inUseSince = Set("inUseSince", value);
        }

        /// <summary>
        /// The label that is attached to the configuration item (CI). A label is automatically generated using the same prefix of other CIs of the same product category, followed by the next available number as the suffix.
        /// </summary>
        [XurrentField("label")]
        public string? Label
        {
            get => _label;
            set => _label = Set("label", value);
        }

        /// <summary>
        /// The date and time at which the configuration item was last seen.
        /// </summary>
        [XurrentField("lastSeenAt")]
        public DateTime? LastSeenAt
        {
            get => _lastSeenAt;
            set => _lastSeenAt = Set("lastSeenAt", value);
        }

        /// <summary>
        /// The date through which the temporary software license certificate is valid. The license certificate expires at the end of this day.
        /// </summary>
        [XurrentField("licenseExpiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? LicenseExpiryDate
#else
        public DateTime? LicenseExpiryDate
#endif
        {
            get => _licenseExpiryDate;
            set => _licenseExpiryDate = Set("licenseExpiryDate", value);
        }

        /// <summary>
        /// The type of license that the license certificate covers.
        /// </summary>
        [XurrentField("licenseType")]
        public CiLicenseType? LicenseType
        {
            get => _licenseType;
            set => _licenseType = Set("licenseType", value);
        }

        /// <summary>
        /// Identifiers of the sites at which the software that is covered by the license certificate may be used.
        /// </summary>
        [XurrentField("licensedSiteIds")]
        public Collection<string>? LicensedSiteIds
        {
            get => _licensedSiteIds;
            set => _licensedSiteIds = Set("licensedSiteIds", value);
        }

        /// <summary>
        /// The name or number of the room in which the CI is located, if it concerns a hardware CI.
        /// </summary>
        [XurrentField("location")]
        public string? Location
        {
            get => _location;
            set => _location = Set("location", value);
        }

        /// <summary>
        /// The name of the configuration item (CI). When creating a new CI and a value is not specified for this field, it is set to the name of the CI's product.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The total number of processor cores that are installed in the server.
        /// </summary>
        [XurrentField("nrOfCores")]
        public long? NrOfCores
        {
            get => _nrOfCores;
            set => _nrOfCores = Set("nrOfCores", value);
        }

        /// <summary>
        /// The number of licenses that the license certificate covers.
        /// </summary>
        [XurrentField("nrOfLicenses")]
        public long? NrOfLicenses
        {
            get => _nrOfLicenses;
            set => _nrOfLicenses = Set("nrOfLicenses", value);
        }

        /// <summary>
        /// The number of processors that are installed in the server.
        /// </summary>
        [XurrentField("nrOfProcessors")]
        public long? NrOfProcessors
        {
            get => _nrOfProcessors;
            set => _nrOfProcessors = Set("nrOfProcessors", value);
        }

        /// <summary>
        /// Identifier of the (software) configuration item representing the operating system of this configuration item.
        /// </summary>
        [XurrentField("operatingSystemId")]
        public string? OperatingSystemId
        {
            get => _operatingSystemId;
            set => _operatingSystemId = Set("operatingSystemId", value);
        }

        /// <summary>
        /// Identifier of the related product.
        /// </summary>
        [XurrentField("productId")]
        public string? ProductId
        {
            get => _productId;
            set => _productId = Set("productId", value);
        }

        /// <summary>
        /// The amount that was paid for the configuration item (this is normally equal to the invoice amount).
        /// </summary>
        [XurrentField("purchaseValue")]
        public decimal? PurchaseValue
        {
            get => _purchaseValue;
            set => _purchaseValue = Set("purchaseValue", value);
        }

        /// <summary>
        /// The currency of the purchase value attributed to this configuration item.
        /// </summary>
        [XurrentField("purchaseValueCurrency")]
        public Currency? PurchaseValueCurrency
        {
            get => _purchaseValueCurrency;
            set => _purchaseValueCurrency = Set("purchaseValueCurrency", value);
        }

        /// <summary>
        /// The amount of RAM (in GB) of this configuration item.
        /// </summary>
        [XurrentField("ramAmount")]
        public decimal? RamAmount
        {
            get => _ramAmount;
            set => _ramAmount = Set("ramAmount", value);
        }

        /// <summary>
        /// Recurrence for maintenance of the configuration item.
        /// </summary>
        [XurrentField("recurrence")]
        public RecurrenceInput? Recurrence
        {
            get => _recurrence;
            set => _recurrence = Set("recurrence", value);
        }

        /// <summary>
        /// Any additional information about the configuration item that might prove useful. When creating a new CI and a value is not specified for this field, it is set to the remarks of the CI's product.
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
        /// The Rule set field is automatically set to the rule set of product category, except when the CI is a license certificate, in which case the rule set is <c>license_certificate</c>.
        /// </summary>
        [XurrentField("ruleSet")]
        public ProductCategoryRuleSet? RuleSet
        {
            get => _ruleSet;
            set => _ruleSet = Set("ruleSet", value);
        }

        /// <summary>
        /// Serial number of the configuration item. The concatenation of <c>product</c>'s' <c>brand</c> and <c>serialNr</c> must be unique within a Xurrent account.
        /// </summary>
        [XurrentField("serialNr")]
        public string? SerialNr
        {
            get => _serialNr;
            set => _serialNr = Set("serialNr", value);
        }

        /// <summary>
        /// Which service instance(s) the configuration item is, or will be, a part of. When creating a new CI and a value is not specified for this field, it is set to the service of the CI's product.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Identifiers of the service instances of this configuration item.
        /// </summary>
        [XurrentField("serviceInstanceIds")]
        public Collection<string>? ServiceInstanceIds
        {
            get => _serviceInstanceIds;
            set => _serviceInstanceIds = Set("serviceInstanceIds", value);
        }

        /// <summary>
        /// Where the CI is located, if it concerns a hardware CI.
        /// </summary>
        [XurrentField("siteId")]
        public string? SiteId
        {
            get => _siteId;
            set => _siteId = Set("siteId", value);
        }

        /// <summary>
        /// <c>true</c> for license certificates that may only be used at one or more specific locations.
        /// </summary>
        [XurrentField("siteLicense")]
        public bool? SiteLicense
        {
            get => _siteLicense;
            set => _siteLicense = Set("siteLicense", value);
        }

        /// <summary>
        /// The appropriate status for the configuration item (CI).
        /// </summary>
        [XurrentField("status")]
        public CiStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// Identifier of the supplier from which the configuration item (CI) has been obtained. When creating a new CI and a value is not specified for this field, it is set to the supplier of the CI's product.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the team responsible for supporting the configuration item and maintaining its information in the configuration management database (CMDB). When creating a new CI and a value is not specified for this field, it is set to the support team of the CI's product. Optional when status of CI equals "Removed", required otherwise.
        /// </summary>
        [XurrentField("supportTeamId")]
        public string? SupportTeamId
        {
            get => _supportTeamId;
            set => _supportTeamId = Set("supportTeamId", value);
        }

        /// <summary>
        /// System identifier of the configuration item.
        /// </summary>
        [XurrentField("systemID")]
        public string? SystemID
        {
            get => _systemID;
            set => _systemID = Set("systemID", value);
        }

        /// <summary>
        /// <c>true</c> for license certificates that are not valid indefinitely.
        /// </summary>
        [XurrentField("temporaryLicense")]
        public bool? TemporaryLicense
        {
            get => _temporaryLicense;
            set => _temporaryLicense = Set("temporaryLicense", value);
        }

        /// <summary>
        /// Identifiers of the users of this configuration item.
        /// </summary>
        [XurrentField("userIds")]
        public Collection<string>? UserIds
        {
            get => _userIds;
            set => _userIds = Set("userIds", value);
        }

        /// <summary>
        /// The date through which the warranty coverage for the configuration item is valid. The warranty expires at the end of this day.
        /// </summary>
        [XurrentField("warrantyExpiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? WarrantyExpiryDate
#else
        public DateTime? WarrantyExpiryDate
#endif
        {
            get => _warrantyExpiryDate;
            set => _warrantyExpiryDate = Set("warrantyExpiryDate", value);
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
        /// The workflow template that is used to periodically maintain the configuration item.
        /// </summary>
        [XurrentField("workflowTemplateId")]
        public string? WorkflowTemplateId
        {
            get => _workflowTemplateId;
            set => _workflowTemplateId = Set("workflowTemplateId", value);
        }

        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        [XurrentField("newCiRelations")]
        public Collection<CiRelationInput>? NewCiRelations
        {
            get => _newCiRelations;
            set => _newCiRelations = Set("newCiRelations", value);
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
        /// Identifiers of relations other configuration items to remove from the configuration item.
        /// </summary>
        [XurrentField("ciRelationsToDelete")]
        public Collection<string>? CiRelationsToDelete
        {
            get => _ciRelationsToDelete;
            set => _ciRelationsToDelete = Set("ciRelationsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationItemUpdateInput"/> class without providing the required values.
        /// </summary>
        public ConfigurationItemUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationItemUpdateInput"/> class.
        /// </summary>
        public ConfigurationItemUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
