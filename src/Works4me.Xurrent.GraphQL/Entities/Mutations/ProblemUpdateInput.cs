using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/problemupdateinput/">ProblemUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ProblemUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _uiExtensionId;
        private long? _timeSpent;
        private string? _timeSpentEffortClassId;
        private string? _timeEntryDescription;
        private string? _agileBoardId;
        private string? _agileBoardColumnId;
        private long? _agileBoardColumnPosition;
        private string? _productBacklogId;
        private long? _productBacklogPosition;
        private long? _productBacklogEstimate;
        private DateTime? _analysisTargetAt;
        private ProblemCategory? _category;
        private string? _workflowId;
        private ProblemImpact? _impact;
        private string? _knowledgeArticleId;
        private bool? _knownError;
        private string? _managerId;
        private string? _memberId;
        private string? _note;
        private string? _projectId;
        private string? _serviceId;
        private ProblemStatus? _status;
        private string? _subject;
        private string? _supplierId;
        private string? _supplierRequestID;
        private string? _teamId;
        private bool? _urgent;
        private DateTime? _waitingUntil;
        private string? _workaround;
        private Collection<string>? _configurationItemIds;
        private Collection<string>? _requestIds;
        private Collection<string>? _serviceInstanceIds;
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
        /// Used to specify when the current assignee needs to have completed the root cause analysis of the problem.
        /// </summary>
        [XurrentField("analysisTargetAt")]
        public DateTime? AnalysisTargetAt
        {
            get => _analysisTargetAt;
            set => _analysisTargetAt = Set("analysisTargetAt", value);
        }

        /// <summary>
        /// The category of the problem.
        /// </summary>
        [XurrentField("category")]
        public ProblemCategory? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// Identifier of the workflow that will implement the proposed permanent solution for the problem.
        /// </summary>
        [XurrentField("workflowId")]
        public string? WorkflowId
        {
            get => _workflowId;
            set => _workflowId = Set("workflowId", value);
        }

        /// <summary>
        /// Used to select the extent to which the service is impacted when an incident occurs that is caused by the problem. Defaults to <c>none</c>.
        /// </summary>
        [XurrentField("impact")]
        public ProblemImpact? Impact
        {
            get => _impact;
            set => _impact = Set("impact", value);
        }

        /// <summary>
        /// Identifier of the knowledge article which instructions should be followed to resolve incidents caused by this problem until a structural solution has been implemented.
        /// </summary>
        [XurrentField("knowledgeArticleId")]
        public string? KnowledgeArticleId
        {
            get => _knowledgeArticleId;
            set => _knowledgeArticleId = Set("knowledgeArticleId", value);
        }

        /// <summary>
        /// Whether the underlying cause of the problem has been found and a temporary workaround has been proposed.
        /// </summary>
        [XurrentField("knownError")]
        public bool? KnownError
        {
            get => _knownError;
            set => _knownError = Set("knownError", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the problem through root cause analysis, the proposal of a structural solution and ultimately its closure. Defaults to the current authenticated person.
        /// </summary>
        [XurrentField("managerId")]
        public string? ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// Identifier of the person to whom the problem is to be assigned.
        /// </summary>
        [XurrentField("memberId")]
        public string? MemberId
        {
            get => _memberId;
            set => _memberId = Set("memberId", value);
        }

        /// <summary>
        /// Detailed description of the symptoms that are caused by the problem.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// Identifier of the project to link the problem to.
        /// </summary>
        [XurrentField("projectId")]
        public string? ProjectId
        {
            get => _projectId;
            set => _projectId = Set("projectId", value);
        }

        /// <summary>
        /// Identifier of the service in which instance(s) the problem resides.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// The current status of the problem.
        /// </summary>
        [XurrentField("status")]
        public ProblemStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// A short description of the symptoms that the problem causes.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Identifier of the supplier organization that has been asked for a solution to the problem.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// The identifier under which the request to help with the solution of the problem has been registered at the supplier organization.
        /// </summary>
        [XurrentField("supplierRequestID")]
        public string? SupplierRequestID
        {
            get => _supplierRequestID;
            set => _supplierRequestID = Set("supplierRequestID", value);
        }

        /// <summary>
        /// Identifier of the team to which the problem is to be assigned. Defaults to the support team of the service if no team or member is present.
        /// </summary>
        [XurrentField("teamId")]
        public string? TeamId
        {
            get => _teamId;
            set => _teamId = Set("teamId", value);
        }

        /// <summary>
        /// Whether the problem has been marked as urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent
        {
            get => _urgent;
            set => _urgent = Set("urgent", value);
        }

        /// <summary>
        /// The date and time at which the status of the problem is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => _waitingUntil;
            set => _waitingUntil = Set("waitingUntil", value);
        }

        /// <summary>
        /// Used to describe the temporary workaround that should be applied to resolve incidents caused by this problem until a structural solution has been implemented.
        /// </summary>
        [XurrentField("workaround")]
        public string? Workaround
        {
            get => _workaround;
            set => _workaround = Set("workaround", value);
        }

        /// <summary>
        /// Identifiers of configuration items of this problem.
        /// </summary>
        [XurrentField("configurationItemIds")]
        public Collection<string>? ConfigurationItemIds
        {
            get => _configurationItemIds;
            set => _configurationItemIds = Set("configurationItemIds", value);
        }

        /// <summary>
        /// Identifiers of requests of this problem.
        /// </summary>
        [XurrentField("requestIds")]
        public Collection<string>? RequestIds
        {
            get => _requestIds;
            set => _requestIds = Set("requestIds", value);
        }

        /// <summary>
        /// Identifiers of service instances of this problem.
        /// </summary>
        [XurrentField("serviceInstanceIds")]
        public Collection<string>? ServiceInstanceIds
        {
            get => _serviceInstanceIds;
            set => _serviceInstanceIds = Set("serviceInstanceIds", value);
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
        /// Initializes a new instance of the <see cref="ProblemUpdateInput"/> class without providing the required values.
        /// </summary>
        public ProblemUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemUpdateInput"/> class.
        /// </summary>
        public ProblemUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
