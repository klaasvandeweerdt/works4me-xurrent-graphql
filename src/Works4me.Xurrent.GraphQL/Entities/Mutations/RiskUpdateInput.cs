using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/riskupdateinput/">RiskUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class RiskUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private RiskClosureReason? _closureReason;
        private string? _managerId;
#if NET6_0_OR_GREATER
        private DateOnly? _mitigationTargetAt;
#else
        private DateTime? _mitigationTargetAt;
#endif
        private string? _note;
        private string? _severity;
        private RiskStatus? _status;
        private string? _subject;
        private Collection<string>? _organizationIds;
        private Collection<string>? _projectIds;
        private Collection<string>? _serviceIds;
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
        /// The appropriate closure reason for the risk when it has been closed.
        /// </summary>
        [XurrentField("closureReason")]
        public RiskClosureReason? ClosureReason
        {
            get => _closureReason;
            set => _closureReason = Set("closureReason", value);
        }

        /// <summary>
        /// Identifier of the manager of the risk. This person is able to maintain the information about the risk.
        /// </summary>
        [XurrentField("managerId")]
        public string? ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// The date by which the risk should have been mitigated.
        /// </summary>
        [XurrentField("mitigationTargetAt")]
#if NET6_0_OR_GREATER
        public DateOnly? MitigationTargetAt
#else
        public DateTime? MitigationTargetAt
#endif
        {
            get => _mitigationTargetAt;
            set => _mitigationTargetAt = Set("mitigationTargetAt", value);
        }

        /// <summary>
        /// The Note field is used to provide a detailed description of the risk and the actions that are planned or have already been taken to eliminate it, or to minimize its severity. This field is also used when the status is set to <c>closed</c> to explain why it was decided to close the risk.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// The severity of the risk.
        /// </summary>
        [XurrentField("severity")]
        public string? Severity
        {
            get => _severity;
            set => _severity = Set("severity", value);
        }

        /// <summary>
        /// The current status of the risk.
        /// </summary>
        [XurrentField("status")]
        public RiskStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// The subject of the risk.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Identifiers of organizations linked to the risk.
        /// </summary>
        [XurrentField("organizationIds")]
        public Collection<string>? OrganizationIds
        {
            get => _organizationIds;
            set => _organizationIds = Set("organizationIds", value);
        }

        /// <summary>
        /// Identifiers of projects linked to the risk.
        /// </summary>
        [XurrentField("projectIds")]
        public Collection<string>? ProjectIds
        {
            get => _projectIds;
            set => _projectIds = Set("projectIds", value);
        }

        /// <summary>
        /// Identifiers of services linked to the risk.
        /// </summary>
        [XurrentField("serviceIds")]
        public Collection<string>? ServiceIds
        {
            get => _serviceIds;
            set => _serviceIds = Set("serviceIds", value);
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
        /// Initializes a new instance of the <see cref="RiskUpdateInput"/> class without providing the required values.
        /// </summary>
        public RiskUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskUpdateInput"/> class.
        /// </summary>
        public RiskUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
