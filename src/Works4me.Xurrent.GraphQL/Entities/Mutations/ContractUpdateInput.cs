using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/contractupdateinput/">ContractUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class ContractUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private ContractCategory? _category;
        private string? _customerId;
        private string? _customerRepresentativeId;
#if NET6_0_OR_GREATER
        private DateOnly? _expiryDate;
#else
        private DateTime? _expiryDate;
#endif
        private string? _name;
#if NET6_0_OR_GREATER
        private DateOnly? _noticeDate;
#else
        private DateTime? _noticeDate;
#endif
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
#if NET6_0_OR_GREATER
        private DateOnly? _startDate;
#else
        private DateTime? _startDate;
#endif
        private AgreementStatus? _status;
        private string? _supplierId;
        private string? _supplierContactId;
        private string? _timeZone;
        private Collection<string>? _configurationItemIds;
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
        /// UI extension that is to be applied to the record.
        /// </summary>
        [XurrentField("uiExtensionId")]
        public string? UiExtensionId
        {
            get => _uiExtensionId;
            set => _uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Used to select the appropriate category for the contract.
        /// </summary>
        [XurrentField("category")]
        public ContractCategory? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// Identifier of the organization that pays for the contract.
        /// </summary>
        [XurrentField("customerId")]
        public string? CustomerId
        {
            get => _customerId;
            set => _customerId = Set("customerId", value);
        }

        /// <summary>
        /// Identifier of the person who represents the customer of the contract.
        /// </summary>
        [XurrentField("customerRepresentativeId")]
        public string? CustomerRepresentativeId
        {
            get => _customerRepresentativeId;
            set => _customerRepresentativeId = Set("customerRepresentativeId", value);
        }

        /// <summary>
        /// The date through which the contract will be active. The contract expires at the end of this day if it is not renewed before then.<br />
        /// When the contract has expired, its status will automatically be set to <c>expired</c>.<br />
        /// As long as notice still needs to be given to terminate the contract, the <c>expiryDate</c> field is to remain empty.<br />
        /// </summary>
        [XurrentField("expiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? ExpiryDate
#else
        public DateTime? ExpiryDate
#endif
        {
            get => _expiryDate;
            set => _expiryDate = Set("expiryDate", value);
        }

        /// <summary>
        /// The name of the contract.<br />
        /// If a unique ID is given to each contract, then this ID can be added at the start of the name.<br />
        /// Example:<br />
        /// • 2EGXQ2W – Dell 3-Year ProSupport and Next Business Day Onsite Repair for CMP00035.<br />
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The last day on which the supplier organization can still be contacted to terminate the contract to ensure that it expires on the intended expiry date.<br />
        /// The <c>noticeDate</c> field is left empty, and the <c>expiryDate</c> field is filled out, when the contract is to expire on a specific date and no notice needs to be given to terminate it.<br />
        /// As long as notice still needs to be given to terminate the contract, the <c>expiryDate</c> field is to remain empty.<br />
        /// </summary>
        [XurrentField("noticeDate")]
#if NET6_0_OR_GREATER
        public DateOnly? NoticeDate
#else
        public DateTime? NoticeDate
#endif
        {
            get => _noticeDate;
            set => _noticeDate = Set("noticeDate", value);
        }

        /// <summary>
        /// Any additional information about the contract that might prove useful.
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
        /// The first day during which the contract is active.
        /// </summary>
        [XurrentField("startDate")]
#if NET6_0_OR_GREATER
        public DateOnly? StartDate
#else
        public DateTime? StartDate
#endif
        {
            get => _startDate;
            set => _startDate = Set("startDate", value);
        }

        /// <summary>
        /// The current status of the contract.
        /// </summary>
        [XurrentField("status")]
        public AgreementStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// Identifier of the organization that has provided the contract to the customer.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the person who represents the supplier of the contract.
        /// </summary>
        [XurrentField("supplierContactId")]
        public string? SupplierContactId
        {
            get => _supplierContactId;
            set => _supplierContactId = Set("supplierContactId", value);
        }

        /// <summary>
        /// The time zone that applies to the start date, notice date and expiry date of the contract.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Identifiers of the configuration items of the contract.
        /// </summary>
        [XurrentField("configurationItemIds")]
        public Collection<string>? ConfigurationItemIds
        {
            get => _configurationItemIds;
            set => _configurationItemIds = Set("configurationItemIds", value);
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
        /// Initializes a new instance of the <see cref="ContractUpdateInput"/> class without providing the required values.
        /// </summary>
        public ContractUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractUpdateInput"/> class.
        /// </summary>
        public ContractUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
