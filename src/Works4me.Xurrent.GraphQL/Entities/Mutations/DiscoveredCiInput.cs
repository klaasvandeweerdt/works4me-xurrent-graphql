using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/discoveredciinput/">DiscoveredCiInput</see> in Xurrent.
    /// </summary>
    public sealed class DiscoveredCiInput : PropertyChangeSet
    {
        private DiscoveredItemMetaData? _meta;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string _sourceID;
        private string _name;
        private DiscoveredCiRelationInput? _ciRelations;
        private string? _service;
        private CiStatus? _status;
#if NET6_0_OR_GREATER
        private DateOnly? _endOfSupportDate;
#else
        private DateTime? _endOfSupportDate;
#endif
        private string? _serialNr;
        private string? _systemID;
        private string? _assetID;
#if NET6_0_OR_GREATER
        private DateOnly? _inUseSince;
#else
        private DateTime? _inUseSince;
#endif
        private string? _label;
        private DateTime? _lastSeenAt;
        private string? _location;
        private long? _nrOfCores;
        private long? _nrOfProcessors;
#if NET6_0_OR_GREATER
        private DateOnly? _warrantyExpiryDate;
#else
        private DateTime? _warrantyExpiryDate;
#endif
        private decimal? _ramAmount;
        private string? _remarks;
        private string? _operatingSystemId;
        private decimal? _purchaseValue;
        private Currency? _purchaseValueCurrency;
        private Collection<string>? _userIds;

        /// <summary>
        /// Meta data describing how to process the values supplied.
        /// </summary>
        [XurrentField("meta")]
        public DiscoveredItemMetaData? Meta
        {
            get => _meta;
            set => _meta = Set("meta", value);
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
        /// The unique identifier of the configuration item in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Name of the configuration item.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        [XurrentField("ciRelations")]
        public DiscoveredCiRelationInput? CiRelations
        {
            get => _ciRelations;
            set => _ciRelations = Set("ciRelations", value);
        }

        /// <summary>
        /// The name of the service the configuration item is, or will be, a part of. When no value is specified for this field, it is set to the service of the CI's product.
        /// </summary>
        [XurrentField("service")]
        public string? Service
        {
            get => _service;
            set => _service = Set("service", value);
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
        /// Serial number of the configuration item. The concatenation of <c>product</c>'s' <c>brand</c> and <c>serialNr</c> must be unique within a Xurrent account.
        /// </summary>
        [XurrentField("serialNr")]
        public string? SerialNr
        {
            get => _serialNr;
            set => _serialNr = Set("serialNr", value);
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
        /// Asset identifier of the configuration item.
        /// </summary>
        [XurrentField("assetID")]
        public string? AssetID
        {
            get => _assetID;
            set => _assetID = Set("assetID", value);
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
        /// The name or number of the room in which the CI is located, if it concerns a hardware CI.
        /// </summary>
        [XurrentField("location")]
        public string? Location
        {
            get => _location;
            set => _location = Set("location", value);
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
        /// The number of processors that are installed in the server.
        /// </summary>
        [XurrentField("nrOfProcessors")]
        public long? NrOfProcessors
        {
            get => _nrOfProcessors;
            set => _nrOfProcessors = Set("nrOfProcessors", value);
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
        /// The amount of RAM (in GB) of this configuration item.
        /// </summary>
        [XurrentField("ramAmount")]
        public decimal? RamAmount
        {
            get => _ramAmount;
            set => _ramAmount = Set("ramAmount", value);
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
        /// Identifier of the (software) configuration item representing the operating system of this configuration item.
        /// </summary>
        [XurrentField("operatingSystemId")]
        public string? OperatingSystemId
        {
            get => _operatingSystemId;
            set => _operatingSystemId = Set("operatingSystemId", value);
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
        /// Identifiers of the users of this configuration item.
        /// </summary>
        [XurrentField("userIds")]
        public Collection<string>? UserIds
        {
            get => _userIds;
            set => _userIds = Set("userIds", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredCiInput"/> class without providing the required values.
        /// </summary>
        public DiscoveredCiInput()
        {
            _sourceID = string.Empty;
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredCiInput"/> class.
        /// </summary>
        public DiscoveredCiInput(string sourceID, string name)
        {
            _sourceID = Set("sourceID", sourceID);
            _name = Set("name", name);
        }
    }
}
