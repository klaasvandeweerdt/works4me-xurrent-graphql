using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/serviceupdateinput/">ServiceUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ServiceUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private string? _availabilityManagerId;
        private string? _capacityManagerId;
        private string? _changeManagerId;
        private string? _continuityManagerId;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private bool? _disabled;
        private string? _firstLineTeamId;
        private string? _keywords;
        private string? _knowledgeManagerId;
        private string? _name;
        private string? _problemManagerId;
        private string? _providerId;
        private string? _releaseManagerId;
        private string? _serviceOwnerId;
        private string? _supportTeamId;
        private string? _surveyId;
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
        /// Identifier of the person who is responsible for ensuring that the availability targets specified in the active SLAs for the service are met.
        /// </summary>
        [XurrentField("availabilityManagerId")]
        public string? AvailabilityManagerId
        {
            get => _availabilityManagerId;
            set => _availabilityManagerId = Set("availabilityManagerId", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for ensuring that the service is not affected by incidents that are caused by capacity shortages.
        /// </summary>
        [XurrentField("capacityManagerId")]
        public string? CapacityManagerId
        {
            get => _capacityManagerId;
            set => _capacityManagerId = Set("capacityManagerId", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the changes of the service.
        /// </summary>
        [XurrentField("changeManagerId")]
        public string? ChangeManagerId
        {
            get => _changeManagerId;
            set => _changeManagerId = Set("changeManagerId", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for creating and maintaining the continuity plans for the service's instances that have an active SLA with a continuity target.
        /// </summary>
        [XurrentField("continuityManagerId")]
        public string? ContinuityManagerId
        {
            get => _continuityManagerId;
            set => _continuityManagerId = Set("continuityManagerId", value);
        }

        /// <summary>
        /// A high-level description of the service's core functionality.
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        [XurrentField("descriptionAttachments")]
        public Collection<AttachmentInput>? DescriptionAttachments
        {
            get => _descriptionAttachments;
            set => _descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// Whether the service may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the team that will, by default, be selected in the First line team field of a new service instance when it is being registered for the service.
        /// </summary>
        [XurrentField("firstLineTeamId")]
        public string? FirstLineTeamId
        {
            get => _firstLineTeamId;
            set => _firstLineTeamId = Set("firstLineTeamId", value);
        }

        /// <summary>
        /// A comma-separated list of words that can be used to find the service via search.
        /// </summary>
        [XurrentField("keywords")]
        public string? Keywords
        {
            get => _keywords;
            set => _keywords = Set("keywords", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for the quality of the knowledge articles for the service.
        /// </summary>
        [XurrentField("knowledgeManagerId")]
        public string? KnowledgeManagerId
        {
            get => _knowledgeManagerId;
            set => _knowledgeManagerId = Set("knowledgeManagerId", value);
        }

        /// <summary>
        /// The name of the service. The service name may be followed by the name of its core application placed between brackets.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the problems that directly affect the service.
        /// </summary>
        [XurrentField("problemManagerId")]
        public string? ProblemManagerId
        {
            get => _problemManagerId;
            set => _problemManagerId = Set("problemManagerId", value);
        }

        /// <summary>
        /// Identifier of the organization who provides the service.
        /// </summary>
        [XurrentField("providerId")]
        public string? ProviderId
        {
            get => _providerId;
            set => _providerId = Set("providerId", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the releases of the service.
        /// </summary>
        [XurrentField("releaseManagerId")]
        public string? ReleaseManagerId
        {
            get => _releaseManagerId;
            set => _releaseManagerId = Set("releaseManagerId", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for ensuring that the service level targets specified in the SLAs for the service are met.
        /// </summary>
        [XurrentField("serviceOwnerId")]
        public string? ServiceOwnerId
        {
            get => _serviceOwnerId;
            set => _serviceOwnerId = Set("serviceOwnerId", value);
        }

        /// <summary>
        /// Identifier of the team that will, by default, be selected in the Support team field of a service instance when one is registered for the service. Similarly, this team will be selected in the Team field of a problem when the service is related to it.
        /// </summary>
        [XurrentField("supportTeamId")]
        public string? SupportTeamId
        {
            get => _supportTeamId;
            set => _supportTeamId = Set("supportTeamId", value);
        }

        /// <summary>
        /// Identifier of the survey used to measure customer rating of this service.
        /// </summary>
        [XurrentField("surveyId")]
        public string? SurveyId
        {
            get => _surveyId;
            set => _surveyId = Set("surveyId", value);
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
        /// Initializes a new instance of the <see cref="ServiceUpdateInput"/> class without providing the required values.
        /// </summary>
        public ServiceUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUpdateInput"/> class.
        /// </summary>
        public ServiceUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
