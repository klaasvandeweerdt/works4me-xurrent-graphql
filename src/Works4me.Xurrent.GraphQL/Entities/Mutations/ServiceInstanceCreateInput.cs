using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/serviceinstancecreateinput/">ServiceInstanceCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class ServiceInstanceCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private string? _firstLineTeamId;
        private string? _remarks;
        private Collection<AttachmentInput>? _remarksAttachments;
        private ServiceInstanceStatus? _status;
        private string? _supportTeamId;
        private Collection<string>? _configurationItemIds;
        private string _name;
        private string _serviceId;

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
        /// The hyperlink to the image file for the record. This may be a <a href="https://developer.mozilla.org/en-US/docs/Web/URI/Reference/Schemes/data">'data URL'</a>, allowing the image to be supplied directly without requiring a separate upload first.
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
        /// Idenifier of the team that will automatically be selected in the Team field of requests to which the service instance is linked after they have been submitted using Self Service or when they are generated using the Requests API, Mail API or Events API.
        /// </summary>
        [XurrentField("firstLineTeamId")]
        public string? FirstLineTeamId
        {
            get => _firstLineTeamId;
            set => _firstLineTeamId = Set("firstLineTeamId", value);
        }

        /// <summary>
        /// Any additional information about the service instance that might prove useful.
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
        /// The current status of the service instance.
        /// </summary>
        [XurrentField("status")]
        public ServiceInstanceStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// Identifier of the team that will, by default, be selected in the Team field of a request when the service instance is manually selected in the Service instance field of the request, or when the service instance is applied from the Service Hierarchy Browser.
        /// </summary>
        [XurrentField("supportTeamId")]
        public string? SupportTeamId
        {
            get => _supportTeamId;
            set => _supportTeamId = Set("supportTeamId", value);
        }

        /// <summary>
        /// Identifiers of the configuration items of the service instance.
        /// </summary>
        [XurrentField("configurationItemIds")]
        public Collection<string>? ConfigurationItemIds
        {
            get => _configurationItemIds;
            set => _configurationItemIds = Set("configurationItemIds", value);
        }

        /// <summary>
        /// The name of the service instance.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Identifier of the service which functionality the service instance provides.
        /// </summary>
        [XurrentField("serviceId")]
        public string ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInstanceCreateInput"/> class without providing the required values.
        /// </summary>
        public ServiceInstanceCreateInput()
        {
            _name = string.Empty;
            _serviceId = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInstanceCreateInput"/> class.
        /// </summary>
        public ServiceInstanceCreateInput(string name, string serviceId)
        {
            _name = Set("name", name);
            _serviceId = Set("serviceId", serviceId);
        }
    }
}
