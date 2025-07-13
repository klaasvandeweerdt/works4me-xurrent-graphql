using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/releasecreateinput/">ReleaseCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class ReleaseCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private string? _note;
        private Collection<string>? _workflowIds;
        private string _managerId;
        private string _subject;

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
        /// High-level description of the result that should be accomplished by the implementation of the release's workflows. It is also used to add any information that could prove useful for anyone affected by the release.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// Identifiers of the workflows of the release.
        /// </summary>
        [XurrentField("workflowIds")]
        public Collection<string>? WorkflowIds
        {
            get => _workflowIds;
            set => _workflowIds = Set("workflowIds", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the implementation of the release. The person must have the release Manager role.
        /// </summary>
        [XurrentField("managerId")]
        public string ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// A short description of the objective of the release.
        /// </summary>
        [XurrentField("subject")]
        public string Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreateInput"/> class without providing the required values.
        /// </summary>
        public ReleaseCreateInput()
        {
            _managerId = string.Empty;
            _subject = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreateInput"/> class.
        /// </summary>
        public ReleaseCreateInput(string managerId, string subject)
        {
            _managerId = Set("managerId", managerId);
            _subject = Set("subject", subject);
        }
    }
}
