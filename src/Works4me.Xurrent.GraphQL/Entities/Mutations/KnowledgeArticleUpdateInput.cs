using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/knowledgearticleupdateinput/">KnowledgeArticleUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class KnowledgeArticleUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
#if NET6_0_OR_GREATER
        private DateOnly? _archiveDate;
#else
        private DateTime? _archiveDate;
#endif
        private bool? _coveredSpecialists;
        private string? _createdById;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private bool? _endUsers;
        private bool? _public;
        private string? _instructions;
        private bool? _internalSpecialists;
        private bool? _keyContacts;
        private string? _keywords;
        private string? _serviceId;
        private Collection<string>? _serviceInstanceIds;
        private KnowledgeArticleStatus? _status;
        private string? _subject;
        private string? _templateId;
        private string _id;
        private Collection<string>? _translationsToDelete;

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
        /// The date until which the knowledge article will be active. The knowledge article will be archived at the beginning of this day. When the knowledge article is archived, its status will automatically be set to "Archived".
        /// </summary>
        [XurrentField("archiveDate")]
#if NET6_0_OR_GREATER
        public DateOnly? ArchiveDate
#else
        public DateTime? ArchiveDate
#endif
        {
            get => _archiveDate;
            set => _archiveDate = Set("archiveDate", value);
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to the people who are a member of the support team of one of the service instances that are selected in the Coverage section of an active SLA for the service that is linked to the article.
        /// </summary>
        [XurrentField("coveredSpecialists")]
        public bool? CoveredSpecialists
        {
            get => _coveredSpecialists;
            set => _coveredSpecialists = Set("coveredSpecialists", value);
        }

        /// <summary>
        /// Identifier of the person who created the knowledge article.
        /// </summary>
        [XurrentField("createdById")]
        public string? CreatedById
        {
            get => _createdById;
            set => _createdById = Set("createdById", value);
        }

        /// <summary>
        /// Describes the situation and/or environment in which the instructions of the knowledge article may be helpful.
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
        /// Whether the knowledge article needs to be available to anyone who is covered by an active SLA for the service that is linked to the article.
        /// </summary>
        [XurrentField("endUsers")]
        public bool? EndUsers
        {
            get => _endUsers;
            set => _endUsers = Set("endUsers", value);
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to anyone, including people without access to Xurrent.
        /// </summary>
        [XurrentField("public")]
        public bool? Public
        {
            get => _public;
            set => _public = Set("public", value);
        }

        /// <summary>
        /// Used to enter instructions for the service desk analysts, specialists and/or end users who are likely to look up the knowledge article to help them with their work or to resolve an issue.
        /// </summary>
        [XurrentField("instructions")]
        public string? Instructions
        {
            get => _instructions;
            set => _instructions = Set("instructions", value);
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to the people who have the Specialist role of the account in which the article is registered.
        /// </summary>
        [XurrentField("internalSpecialists")]
        public bool? InternalSpecialists
        {
            get => _internalSpecialists;
            set => _internalSpecialists = Set("internalSpecialists", value);
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to the people who have the Key Contact role of the customer account of an active SLA for the service that is linked to the article.
        /// </summary>
        [XurrentField("keyContacts")]
        public bool? KeyContacts
        {
            get => _keyContacts;
            set => _keyContacts = Set("keyContacts", value);
        }

        /// <summary>
        /// A comma-separated list of words that can be used to find the knowledge article using search.
        /// </summary>
        [XurrentField("keywords")]
        public string? Keywords
        {
            get => _keywords;
            set => _keywords = Set("keywords", value);
        }

        /// <summary>
        /// Identifier of the service for which the knowledge article is made available.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Identifiers of service instances linked to this knowledge article.
        /// </summary>
        [XurrentField("serviceInstanceIds")]
        public Collection<string>? ServiceInstanceIds
        {
            get => _serviceInstanceIds;
            set => _serviceInstanceIds = Set("serviceInstanceIds", value);
        }

        /// <summary>
        /// The current status of the knowledge article.
        /// </summary>
        [XurrentField("status")]
        public KnowledgeArticleStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// A short description of the knowledge article.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Identifier of the knowledge article template that this knowledge article is based on.
        /// </summary>
        [XurrentField("templateId")]
        public string? TemplateId
        {
            get => _templateId;
            set => _templateId = Set("templateId", value);
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
        /// Identifiers of translations to remove from this knowledge articles.
        /// </summary>
        [XurrentField("translationsToDelete")]
        public Collection<string>? TranslationsToDelete
        {
            get => _translationsToDelete;
            set => _translationsToDelete = Set("translationsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeArticleUpdateInput"/> class without providing the required values.
        /// </summary>
        public KnowledgeArticleUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeArticleUpdateInput"/> class.
        /// </summary>
        public KnowledgeArticleUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
