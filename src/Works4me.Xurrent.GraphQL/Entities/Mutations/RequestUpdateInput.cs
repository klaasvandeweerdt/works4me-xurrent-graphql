using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/requestupdateinput/">RequestUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class RequestUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private long? _timeSpent;
        private string? _timeSpentEffortClassId;
        private string? _timeEntryDescription;
        private string? _agileBoardId;
        private string? _agileBoardColumnId;
        private long? _agileBoardColumnPosition;
        private string? _productBacklogId;
        private long? _productBacklogPosition;
        private long? _productBacklogEstimate;
        private bool? _addressed;
        private RequestCategory? _category;
        private string? _workflowId;
        private RequestCompletionReason? _completionReason;
        private string? _closureCode;
        private DateTime? _downtimeEndAt;
        private DateTime? _downtimeStartAt;
        private DateTime? _desiredCompletionAt;
        private string? _groupedIntoId;
        private RequestImpact? _impact;
        private string? _internalNote;
        private Collection<AttachmentInput>? _internalNoteAttachments;
        private Collection<string>? _knowledgeArticleIds;
        private RequestMajorIncidentStatus? _majorIncidentStatus;
        private string? _memberId;
        private string? _note;
        private Collection<AttachmentInput>? _noteAttachments;
        private string? _problemId;
        private string? _projectId;
        private bool? _providerNotAccountable;
        private string? _requestedById;
        private string? _requestedForId;
        private bool? _reviewed;
        private string? _serviceInstanceId;
        private RequestStatus? _status;
        private string? _subject;
        private string? _supplierId;
        private string? _supplierRequestID;
        private string? _teamId;
        private string? _templateId;
        private bool? _urgent;
        private DateTime? _waitingUntil;
        private Collection<WatchInput>? _newWatches;
        private Collection<TagInput>? _newTags;
        private Collection<string>? _configurationItemIds;
        private string _id;
        private Collection<string>? _watchesToDelete;
        private Collection<string>? _tagsToDelete;

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
        /// The time that you have spent working on the request since you started to work on it or, if you already entered some time for this request, since you last added your time spent in it.
        /// </summary>
        [XurrentField("timeSpent")]
        public long? TimeSpent
        {
            get => _timeSpent;
            set => _timeSpent = Set("timeSpent", value);
        }

        /// <summary>
        /// The effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        [XurrentField("timeSpentEffortClassId")]
        public string? TimeSpentEffortClassId
        {
            get => _timeSpentEffortClassId;
            set => _timeSpentEffortClassId = Set("timeSpentEffortClassId", value);
        }

        /// <summary>
        /// The justification of the time spent.
        /// </summary>
        [XurrentField("timeEntryDescription")]
        public string? TimeEntryDescription
        {
            get => _timeEntryDescription;
            set => _timeEntryDescription = Set("timeEntryDescription", value);
        }

        /// <summary>
        /// ID of the board this item is placed on.
        /// </summary>
        [XurrentField("agileBoardId")]
        public string? AgileBoardId
        {
            get => _agileBoardId;
            set => _agileBoardId = Set("agileBoardId", value);
        }

        /// <summary>
        /// ID of the column this item is placed in.
        /// </summary>
        [XurrentField("agileBoardColumnId")]
        public string? AgileBoardColumnId
        {
            get => _agileBoardColumnId;
            set => _agileBoardColumnId = Set("agileBoardColumnId", value);
        }

        /// <summary>
        /// The (one based) position of this item in its column.
        /// </summary>
        [XurrentField("agileBoardColumnPosition")]
        public long? AgileBoardColumnPosition
        {
            get => _agileBoardColumnPosition;
            set => _agileBoardColumnPosition = Set("agileBoardColumnPosition", value);
        }

        /// <summary>
        /// Identifier of the product backlog this item is placed on.
        /// </summary>
        [XurrentField("productBacklogId")]
        public string? ProductBacklogId
        {
            get => _productBacklogId;
            set => _productBacklogId = Set("productBacklogId", value);
        }

        /// <summary>
        /// The (one based) position of this item on the backlog.
        /// </summary>
        [XurrentField("productBacklogPosition")]
        public long? ProductBacklogPosition
        {
            get => _productBacklogPosition;
            set => _productBacklogPosition = Set("productBacklogPosition", value);
        }

        /// <summary>
        /// Estimate of the relative size of this item on the product backlog.
        /// </summary>
        [XurrentField("productBacklogEstimate")]
        public long? ProductBacklogEstimate
        {
            get => _productBacklogEstimate;
            set => _productBacklogEstimate = Set("productBacklogEstimate", value);
        }

        /// <summary>
        /// Default: <c>false</c> - When the Satisfaction field of the request is set to 'Dissatisfied', a person who has the Service Desk Manager role, can check the Addressed box to indicate that the requester has been conciliated.
        /// </summary>
        [XurrentField("addressed")]
        public bool? Addressed
        {
            get => _addressed;
            set => _addressed = Set("addressed", value);
        }

        /// <summary>
        /// The Category field is used to select the category of the request.
        /// </summary>
        [XurrentField("category")]
        public RequestCategory? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// ID of workflow to link request to.
        /// </summary>
        [XurrentField("workflowId")]
        public string? WorkflowId
        {
            get => _workflowId;
            set => _workflowId = Set("workflowId", value);
        }

        /// <summary>
        /// The appropriate completion reason for the request when it has been completed.
        /// </summary>
        [XurrentField("completionReason")]
        public RequestCompletionReason? CompletionReason
        {
            get => _completionReason;
            set => _completionReason = Set("completionReason", value);
        }

        /// <summary>
        /// reference of the closure code to be selected for the request when it has been completed. Generally this reference is the snake-cased version of the name (eg. <c>resolved_by_workaround</c> for "Resolved by Workaround").
        /// </summary>
        [XurrentField("closureCode")]
        public string? ClosureCode
        {
            get => _closureCode;
            set => _closureCode = Set("closureCode", value);
        }

        /// <summary>
        /// Used to specify the actual date and time at which the service became available again.
        /// </summary>
        [XurrentField("downtimeEndAt")]
        public DateTime? DowntimeEndAt
        {
            get => _downtimeEndAt;
            set => _downtimeEndAt = Set("downtimeEndAt", value);
        }

        /// <summary>
        /// Used to specify the actual date and time at which the service outage started.
        /// </summary>
        [XurrentField("downtimeStartAt")]
        public DateTime? DowntimeStartAt
        {
            get => _downtimeStartAt;
            set => _downtimeStartAt = Set("downtimeStartAt", value);
        }

        /// <summary>
        /// The date and time that has been agreed on for the completion of the request. The desired completion overwrites the automatically calculated resolution target of any affected SLA that is related to the request when the desired completion is later than the affected SLA's resolution target. By default, the person selected in the Requested by field receives a notification based on the 'Desired Completion Set for Request' email template whenever the value in the Desired completion field is set, updated or removed.
        /// </summary>
        [XurrentField("desiredCompletionAt")]
        public DateTime? DesiredCompletionAt
        {
            get => _desiredCompletionAt;
            set => _desiredCompletionAt = Set("desiredCompletionAt", value);
        }

        /// <summary>
        /// ID of the request group that is used to group the requests that have been submitted for the resolution of exactly the same incident, for the implementation of exactly the same change, for the provision of exactly the same information, etc.
        /// </summary>
        [XurrentField("groupedIntoId")]
        public string? GroupedIntoId
        {
            get => _groupedIntoId;
            set => _groupedIntoId = Set("groupedIntoId", value);
        }

        /// <summary>
        /// Used to select the extent to which the service instance is impacted.
        /// </summary>
        [XurrentField("impact")]
        public RequestImpact? Impact
        {
            get => _impact;
            set => _impact = Set("impact", value);
        }

        /// <summary>
        /// Used to provide information that is visible only for people who have the Auditor, Specialist or Account Administrator role of the account for which the internal note is intended. The <c>x-xurrent-account</c> header sent determines the account.
        /// </summary>
        [XurrentField("internalNote")]
        public string? InternalNote
        {
            get => _internalNote;
            set => _internalNote = Set("internalNote", value);
        }

        /// <summary>
        /// The attachments used in the <c>internalNote</c> field.
        /// </summary>
        [XurrentField("internalNoteAttachments")]
        public Collection<AttachmentInput>? InternalNoteAttachments
        {
            get => _internalNoteAttachments;
            set => _internalNoteAttachments = Set("internalNoteAttachments", value);
        }

        /// <summary>
        /// Knowledge articles applied to the request.
        /// </summary>
        [XurrentField("knowledgeArticleIds")]
        public Collection<string>? KnowledgeArticleIds
        {
            get => _knowledgeArticleIds;
            set => _knowledgeArticleIds = Set("knowledgeArticleIds", value);
        }

        /// <summary>
        /// Used to indicate the status in the major incident management process.
        /// </summary>
        [XurrentField("majorIncidentStatus")]
        public RequestMajorIncidentStatus? MajorIncidentStatus
        {
            get => _majorIncidentStatus;
            set => _majorIncidentStatus = Set("majorIncidentStatus", value);
        }

        /// <summary>
        /// ID of the person to whom the request is to be assigned.
        /// </summary>
        [XurrentField("memberId")]
        public string? MemberId
        {
            get => _memberId;
            set => _memberId = Set("memberId", value);
        }

        /// <summary>
        /// Any additional information that could prove useful for resolving the request and/or to provide a summary of the actions that have been taken since the last entry.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// The attachments used in the <c>note</c> field.
        /// </summary>
        [XurrentField("noteAttachments")]
        public Collection<AttachmentInput>? NoteAttachments
        {
            get => _noteAttachments;
            set => _noteAttachments = Set("noteAttachments", value);
        }

        /// <summary>
        /// ID of problem to link request to.
        /// </summary>
        [XurrentField("problemId")]
        public string? ProblemId
        {
            get => _problemId;
            set => _problemId = Set("problemId", value);
        }

        /// <summary>
        /// ID of project to link request to.
        /// </summary>
        [XurrentField("projectId")]
        public string? ProjectId
        {
            get => _projectId;
            set => _projectId = Set("projectId", value);
        }

        /// <summary>
        /// Default: <c>false</c> - Whether the provider currently indicates not to be accountable.
        /// </summary>
        [XurrentField("providerNotAccountable")]
        public bool? ProviderNotAccountable
        {
            get => _providerNotAccountable;
            set => _providerNotAccountable = Set("providerNotAccountable", value);
        }

        /// <summary>
        /// ID of the person who submitted the request. Defaults to the Requested for field if its value was explicitely provided, otherwise it defaults to the current authenticated person.
        /// </summary>
        [XurrentField("requestedById")]
        public string? RequestedById
        {
            get => _requestedById;
            set => _requestedById = Set("requestedById", value);
        }

        /// <summary>
        /// ID of the person for whom the request was submitted. The person selected in the Requested by field is automatically selected in this field, but another person can be selected if the request is submitted for another person.
        /// </summary>
        [XurrentField("requestedForId")]
        public string? RequestedForId
        {
            get => _requestedForId;
            set => _requestedForId = Set("requestedForId", value);
        }

        /// <summary>
        /// Default: <c>false</c> - A request can be marked as reviewed by the problem manager of the service of the service instance that is linked to the request. Marking a request as reviewed excludes it from the 'Requests for Problem Identification' view.
        /// </summary>
        [XurrentField("reviewed")]
        public bool? Reviewed
        {
            get => _reviewed;
            set => _reviewed = Set("reviewed", value);
        }

        /// <summary>
        /// ID of the service instance in which the cause of the incident resides, for which the change is requested, or about which information is needed.
        /// </summary>
        [XurrentField("serviceInstanceId")]
        public string? ServiceInstanceId
        {
            get => _serviceInstanceId;
            set => _serviceInstanceId = Set("serviceInstanceId", value);
        }

        /// <summary>
        /// Default: <c>assigned</c> - Used to select the current status of the request.
        /// </summary>
        [XurrentField("status")]
        public RequestStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// A short description of the request.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// ID of the supplier organization that has been asked to assist with the request. The supplier organization is automatically selected in this field after a service instance has been selected that is provided by an external service provider organization.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// The identifier under which the request has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field.
        /// </summary>
        [XurrentField("supplierRequestID")]
        public string? SupplierRequestID
        {
            get => _supplierRequestID;
            set => _supplierRequestID = Set("supplierRequestID", value);
        }

        /// <summary>
        /// ID of the team to which the request is to be assigned. By default, the first line team of the service instance that is related to the request will be selected. If a first line team has not been specified for the service instance, the support team of the service instance will be selected instead.
        /// </summary>
        [XurrentField("teamId")]
        public string? TeamId
        {
            get => _teamId;
            set => _teamId = Set("teamId", value);
        }

        /// <summary>
        /// ID of the request template to apply to the request.
        /// </summary>
        [XurrentField("templateId")]
        public string? TemplateId
        {
            get => _templateId;
            set => _templateId = Set("templateId", value);
        }

        /// <summary>
        /// Setting to <c>true</c> marks request as urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent
        {
            get => _urgent;
            set => _urgent = Set("urgent", value);
        }

        /// <summary>
        /// The date and time at which the status of the request is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => _waitingUntil;
            set => _waitingUntil = Set("waitingUntil", value);
        }

        /// <summary>
        /// New or updated watches.
        /// </summary>
        [XurrentField("newWatches")]
        public Collection<WatchInput>? NewWatches
        {
            get => _newWatches;
            set => _newWatches = Set("newWatches", value);
        }

        /// <summary>
        /// Tags to be added to the request.
        /// </summary>
        [XurrentField("newTags")]
        public Collection<TagInput>? NewTags
        {
            get => _newTags;
            set => _newTags = Set("newTags", value);
        }

        /// <summary>
        /// Identifiers of the configuration items to relate to the request. When this field is used to update an existing request, all configuration items that were linked to this request will be replaced by the supplied configuration items.
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
        /// Identifiers of watches to delete.
        /// </summary>
        [XurrentField("watchesToDelete")]
        public Collection<string>? WatchesToDelete
        {
            get => _watchesToDelete;
            set => _watchesToDelete = Set("watchesToDelete", value);
        }

        /// <summary>
        /// Identifiers of tags to delete.
        /// </summary>
        [XurrentField("tagsToDelete")]
        public Collection<string>? TagsToDelete
        {
            get => _tagsToDelete;
            set => _tagsToDelete = Set("tagsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUpdateInput"/> class without providing the required values.
        /// </summary>
        public RequestUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUpdateInput"/> class.
        /// </summary>
        public RequestUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
