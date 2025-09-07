using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/organizationcreateinput/">OrganizationCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class OrganizationCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private bool? _businessUnit;
        private string? _businessUnitOrganizationId;
        private bool? _disabled;
        private bool? _endUserPrivacy;
        private string? _financialID;
        private string? _managerId;
        private string? _parentId;
        private string? _region;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private string? _substituteId;
        private Collection<string>? _timeAllocationIds;
        private Collection<string>? _permittedCustomerIds;
        private Collection<AddressInput>? _newAddresses;
        private Collection<ContactInput>? _newContacts;
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
        /// Whether the organization needs to be treated as a separate entity from a reporting perspective. This checkbox is only available for internal organizations.
        /// </summary>
        [XurrentField("businessUnit")]
        public bool? BusinessUnit
        {
            get => _businessUnit;
            set => _businessUnit = Set("businessUnit", value);
        }

        /// <summary>
        /// Refers to itself if the organization is a business unit, or refers to the business unit that the organization belongs to.
        /// </summary>
        [XurrentField("businessUnitOrganizationId")]
        public string? BusinessUnitOrganizationId
        {
            get => _businessUnitOrganizationId;
            set => _businessUnitOrganizationId = Set("businessUnitOrganizationId", value);
        }

        /// <summary>
        /// Whether the organization may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Whether end users from this organization should be prevented from seeing information of other end users.
        /// </summary>
        [XurrentField("endUserPrivacy")]
        public bool? EndUserPrivacy
        {
            get => _endUserPrivacy;
            set => _endUserPrivacy = Set("endUserPrivacy", value);
        }

        /// <summary>
        /// The unique identifier by which the organization is known in the financial system.
        /// </summary>
        [XurrentField("financialID")]
        public string? FinancialID
        {
            get => _financialID;
            set => _financialID = Set("financialID", value);
        }

        /// <summary>
        /// The manager of the organization.
        /// </summary>
        [XurrentField("managerId")]
        public string? ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// The organization's parent organization.
        /// </summary>
        [XurrentField("parentId")]
        public string? ParentId
        {
            get => _parentId;
            set => _parentId = Set("parentId", value);
        }

        /// <summary>
        /// Which region the organization belongs to. It is possible to select a previously entered region name or to enter a new one. The Region field of a business unit's child organizations cannot be modified, as it is automatically set to the same value as the Region field of the business unit.<br />
        /// Examples of commonly used region names are:<br />
        /// • Asia Pacific (APAC).<br />
        /// • Europe, Middle East &amp; Africa (EMEA).<br />
        /// • North America (NA).<br />
        /// </summary>
        [XurrentField("region")]
        public string? Region
        {
            get => _region;
            set => _region = Set("region", value);
        }

        /// <summary>
        /// Any additional information about the organization that might prove useful.
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
        /// The person who acts as the substitute of the organization's manager.
        /// </summary>
        [XurrentField("substituteId")]
        public string? SubstituteId
        {
            get => _substituteId;
            set => _substituteId = Set("substituteId", value);
        }

        /// <summary>
        /// Time allocations of the organization.
        /// </summary>
        [XurrentField("timeAllocationIds")]
        public Collection<string>? TimeAllocationIds
        {
            get => _timeAllocationIds;
            set => _timeAllocationIds = Set("timeAllocationIds", value);
        }

        /// <summary>
        /// The external customer organizations which requests people in this organization are allowed to see. Only applicable if customer privacy is activated.
        /// </summary>
        [XurrentField("permittedCustomerIds")]
        public Collection<string>? PermittedCustomerIds
        {
            get => _permittedCustomerIds;
            set => _permittedCustomerIds = Set("permittedCustomerIds", value);
        }

        /// <summary>
        /// New or updated addresses of the organization.
        /// </summary>
        [XurrentField("newAddresses")]
        public Collection<AddressInput>? NewAddresses
        {
            get => _newAddresses;
            set => _newAddresses = Set("newAddresses", value);
        }

        /// <summary>
        /// New or updated contacts of the organization.
        /// </summary>
        [XurrentField("newContacts")]
        public Collection<ContactInput>? NewContacts
        {
            get => _newContacts;
            set => _newContacts = Set("newContacts", value);
        }

        /// <summary>
        /// The full name of the organization.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateInput"/> class without providing the required values.
        /// </summary>
        public OrganizationCreateInput()
        {
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateInput"/> class.
        /// </summary>
        public OrganizationCreateInput(string name)
        {
            _name = Set("name", name);
        }
    }
}
