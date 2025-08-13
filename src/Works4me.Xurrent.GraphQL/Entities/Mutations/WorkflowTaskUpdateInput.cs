using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/taskupdateinput/">WorkflowTaskUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class WorkflowTaskUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private long? _timeSpent;
        private string? _timeSpentEffortClassId;
        private string? _timeEntryDescription;
        private string? _agileBoardId;
        private string? _agileBoardColumnId;
        private long? _agileBoardColumnPosition;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private DateTime? _assignedAt;
        private TaskCategory? _category;
        private string? _workflowId;
        private DateTime? _finishedAt;
        private TaskImpact? _impact;
        private string? _instructions;
        private Collection<AttachmentInput>? _instructionsAttachments;
        private string? _memberId;
        private string? _note;
        private Collection<AttachmentInput>? _noteAttachments;
        private string? _pdfDesignId;
        private string? _phaseId;
        private long? _plannedDuration;
        private long? _plannedEffort;
        private long? _requiredApprovals;
        private DateTime? _startAt;
        private WorkflowTaskStatus? _status;
        private string? _subject;
        private string? _supplierId;
        private string? _supplierRequestID;
        private string? _requestTemplateId;
        private string? _requestServiceInstanceId;
        private string? _teamId;
        private string? _templateId;
        private bool? _urgent;
        private DateTime? _waitingUntil;
        private bool? _workHoursAre24x7;
        private Collection<TaskApprovalInput>? _newApprovals;
        private Collection<string>? _configurationItemIds;
        private Collection<string>? _serviceInstanceIds;
        private Collection<string>? _predecessorIds;
        private Collection<string>? _successorIds;
        private string _id;
        private Collection<string>? _approvalsToDelete;

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
        /// Automatically set to the current date and time when the task is assigned.
        /// </summary>
        [XurrentField("assignedAt")]
        public DateTime? AssignedAt
        {
            get => _assignedAt;
            set => _assignedAt = Set("assignedAt", value);
        }

        /// <summary>
        /// The category of the task. Risk &amp; impact tasks are used to help plan workflows. Approval tasks are used to collect approvals for workflows. These can be used at various stages in the life of the workflow. Implementation tasks are added to workflows for development, installation, configuration, test, transfer and administrative work that needs to be completed for the implementation of the workflow.
        /// </summary>
        [XurrentField("category")]
        public TaskCategory? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// Identifier of the workflow to which the task belongs.
        /// </summary>
        [XurrentField("workflowId")]
        public string? WorkflowId
        {
            get => _workflowId;
            set => _workflowId = Set("workflowId", value);
        }

        /// <summary>
        /// Automatically set to the date and time at which the task is saved with the status "Failed", "Rejected", "Completed", "Approved" or "Canceled".
        /// </summary>
        [XurrentField("finishedAt")]
        public DateTime? FinishedAt
        {
            get => _finishedAt;
            set => _finishedAt = Set("finishedAt", value);
        }

        /// <summary>
        /// The extent to which the service instances related to the task will be impacted by the completion of the task.
        /// </summary>
        [XurrentField("impact")]
        public TaskImpact? Impact
        {
            get => _impact;
            set => _impact = Set("impact", value);
        }

        /// <summary>
        /// Used to provide instructions for the person to whom the task will be assigned.
        /// </summary>
        [XurrentField("instructions")]
        public string? Instructions
        {
            get => _instructions;
            set => _instructions = Set("instructions", value);
        }

        /// <summary>
        /// The attachments used in the <c>instructions</c> field.
        /// </summary>
        [XurrentField("instructionsAttachments")]
        public Collection<AttachmentInput>? InstructionsAttachments
        {
            get => _instructionsAttachments;
            set => _instructionsAttachments = Set("instructionsAttachments", value);
        }

        /// <summary>
        /// Identifier of the person to whom the task is to be assigned. This field's value is <c>null</c> in case of an approval task with multiple approvers.
        /// </summary>
        [XurrentField("memberId")]
        public string? MemberId
        {
            get => _memberId;
            set => _memberId = Set("memberId", value);
        }

        /// <summary>
        /// Used to provide information for the person to whom the task is assigned. It is also used to provide a summary of the actions that have been taken to date and the results of these actions.
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
        /// Identifier of the PDF design associated with the task.
        /// </summary>
        [XurrentField("pdfDesignId")]
        public string? PdfDesignId
        {
            get => _pdfDesignId;
            set => _pdfDesignId = Set("pdfDesignId", value);
        }

        /// <summary>
        /// Identifier of the phase of the workflow to which the task belongs.
        /// </summary>
        [XurrentField("phaseId")]
        public string? PhaseId
        {
            get => _phaseId;
            set => _phaseId = Set("phaseId", value);
        }

        /// <summary>
        /// The number of minutes it is expected to take for the task to be completed following its assignment, or following its fixed start date and time if the Start no earlier than field is filled out.
        /// </summary>
        [XurrentField("plannedDuration")]
        public long? PlannedDuration
        {
            get => _plannedDuration;
            set => _plannedDuration = Set("plannedDuration", value);
        }

        /// <summary>
        /// The number of minutes the member is expected to spend working on the task.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort
        {
            get => _plannedEffort;
            set => _plannedEffort = Set("plannedEffort", value);
        }

        /// <summary>
        /// The number of approvers who need to have provided their approval before the status of the task gets updated to "Approved".
        /// </summary>
        [XurrentField("requiredApprovals")]
        public long? RequiredApprovals
        {
            get => _requiredApprovals;
            set => _requiredApprovals = Set("requiredApprovals", value);
        }

        /// <summary>
        /// Only used when work on the task may not start before a specific date and time.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt
        {
            get => _startAt;
            set => _startAt = Set("startAt", value);
        }

        /// <summary>
        /// The Status field is used to select the current status of the task.
        /// </summary>
        [XurrentField("status")]
        public WorkflowTaskStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// A short description of the objective of the task.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Identifier of the supplier organization that has been asked to assist with the completion of the task.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// The identifier under which the request to help with the execution of the task has been registered at the supplier organization.
        /// </summary>
        [XurrentField("supplierRequestID")]
        public string? SupplierRequestID
        {
            get => _supplierRequestID;
            set => _supplierRequestID = Set("supplierRequestID", value);
        }

        /// <summary>
        /// The identifier of the request template that should be used to create the request for this task.
        /// </summary>
        [XurrentField("requestTemplateId")]
        public string? RequestTemplateId
        {
            get => _requestTemplateId;
            set => _requestTemplateId = Set("requestTemplateId", value);
        }

        /// <summary>
        /// The identifier of the service instance that should be used to create the request for this task.
        /// </summary>
        [XurrentField("requestServiceInstanceId")]
        public string? RequestServiceInstanceId
        {
            get => _requestServiceInstanceId;
            set => _requestServiceInstanceId = Set("requestServiceInstanceId", value);
        }

        /// <summary>
        /// Identifier of the team to which the task is to be assigned.
        /// </summary>
        [XurrentField("teamId")]
        public string? TeamId
        {
            get => _teamId;
            set => _teamId = Set("teamId", value);
        }

        /// <summary>
        /// Identifier of the task template that was used to register the task.
        /// </summary>
        [XurrentField("templateId")]
        public string? TemplateId
        {
            get => _templateId;
            set => _templateId = Set("templateId", value);
        }

        /// <summary>
        /// Whether the task has been marked as urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent
        {
            get => _urgent;
            set => _urgent = Set("urgent", value);
        }

        /// <summary>
        /// The date and time at which the status of the task is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => _waitingUntil;
            set => _waitingUntil = Set("waitingUntil", value);
        }

        /// <summary>
        /// When set to true, the completion target of the task is calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [XurrentField("workHoursAre24x7")]
        public bool? WorkHoursAre24x7
        {
            get => _workHoursAre24x7;
            set => _workHoursAre24x7 = Set("workHoursAre24x7", value);
        }

        /// <summary>
        /// Approvals of the task.
        /// </summary>
        [XurrentField("newApprovals")]
        public Collection<TaskApprovalInput>? NewApprovals
        {
            get => _newApprovals;
            set => _newApprovals = Set("newApprovals", value);
        }

        /// <summary>
        /// Identifiers of the configuration items of the task.
        /// </summary>
        [XurrentField("configurationItemIds")]
        public Collection<string>? ConfigurationItemIds
        {
            get => _configurationItemIds;
            set => _configurationItemIds = Set("configurationItemIds", value);
        }

        /// <summary>
        /// Identifiers of service instances of the task.
        /// </summary>
        [XurrentField("serviceInstanceIds")]
        public Collection<string>? ServiceInstanceIds
        {
            get => _serviceInstanceIds;
            set => _serviceInstanceIds = Set("serviceInstanceIds", value);
        }

        /// <summary>
        /// Identifiers of predecessors of the task.
        /// </summary>
        [XurrentField("predecessorIds")]
        public Collection<string>? PredecessorIds
        {
            get => _predecessorIds;
            set => _predecessorIds = Set("predecessorIds", value);
        }

        /// <summary>
        /// Identifiers of successors of the task.
        /// </summary>
        [XurrentField("successorIds")]
        public Collection<string>? SuccessorIds
        {
            get => _successorIds;
            set => _successorIds = Set("successorIds", value);
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
        /// Identifiers of approvals to delete.
        /// </summary>
        [XurrentField("approvalsToDelete")]
        public Collection<string>? ApprovalsToDelete
        {
            get => _approvalsToDelete;
            set => _approvalsToDelete = Set("approvalsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTaskUpdateInput"/> class without providing the required values.
        /// </summary>
        public WorkflowTaskUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTaskUpdateInput"/> class.
        /// </summary>
        public WorkflowTaskUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
