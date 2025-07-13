using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttaskupdateinput/">ProjectTaskUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class ProjectTaskUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private long? _timeSpent;
        private string? _timeSpentEffortClassId;
        private string? _timeEntryDescription;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _agileBoardId;
        private string? _agileBoardColumnId;
        private long? _agileBoardColumnPosition;
        private DateTime? _assignedAt;
        private ProjectTaskCategory? _category;
        private DateTime? _deadline;
        private string? _instructions;
        private string? _note;
        private string? _pdfDesignId;
        private string? _phaseId;
        private long? _plannedDuration;
        private long? _plannedEffort;
        private long? _requiredApprovals;
        private DateTime? _startAt;
        private ProjectTaskStatus? _status;
        private string? _subject;
        private string? _skillPoolId;
        private string? _supplierId;
        private string? _supplierRequestID;
        private string? _teamId;
        private string? _templateId;
        private bool? _urgent;
        private DateTime? _waitingUntil;
        private bool? _workHoursAre24x7;
        private Collection<string>? _predecessorIds;
        private Collection<string>? _successorIds;
        private Collection<ProjectTaskAssignmentInput>? _newAssignments;
        private string _id;
        private Collection<string>? _assignmentsToDelete;

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
        /// Automatically set to the current date and time when the project task is assigned.
        /// </summary>
        [XurrentField("assignedAt")]
        public DateTime? AssignedAt
        {
            get => _assignedAt;
            set => _assignedAt = Set("assignedAt", value);
        }

        /// <summary>
        /// The category of the project task. Activity tasks are used to assign project-related work to people. Approval tasks are used to collect approvals for projects. Milestones are used to mark specific points along a project's implementation plan.
        /// </summary>
        [XurrentField("category")]
        public ProjectTaskCategory? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// The date and time at which the milestone needs to have been reached.
        /// </summary>
        [XurrentField("deadline")]
        public DateTime? Deadline
        {
            get => _deadline;
            set => _deadline = Set("deadline", value);
        }

        /// <summary>
        /// Used to provide instructions for the person(s) to whom the project task will be assigned.
        /// </summary>
        [XurrentField("instructions")]
        public string? Instructions
        {
            get => _instructions;
            set => _instructions = Set("instructions", value);
        }

        /// <summary>
        /// Used to provide information for the person to whom the project task is assigned. It is also used to provide a summary of the actions that have been taken to date and the results of these actions.
        /// </summary>
        [XurrentField("note")]
        public string? Note
        {
            get => _note;
            set => _note = Set("note", value);
        }

        /// <summary>
        /// Identifier of the PDF design to link to the task.
        /// </summary>
        [XurrentField("pdfDesignId")]
        public string? PdfDesignId
        {
            get => _pdfDesignId;
            set => _pdfDesignId = Set("pdfDesignId", value);
        }

        /// <summary>
        /// Identifier of the phase of the project to which the project task belongs.
        /// </summary>
        [XurrentField("phaseId")]
        public string? PhaseId
        {
            get => _phaseId;
            set => _phaseId = Set("phaseId", value);
        }

        /// <summary>
        /// The number of minutes it is expected to take for the project task to be completed following its assignment, or following its fixed start date and time if the Start no earlier than field is filled out.
        /// </summary>
        [XurrentField("plannedDuration")]
        public long? PlannedDuration
        {
            get => _plannedDuration;
            set => _plannedDuration = Set("plannedDuration", value);
        }

        /// <summary>
        /// The number of minutes the team is expected to spend working on the project task.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort
        {
            get => _plannedEffort;
            set => _plannedEffort = Set("plannedEffort", value);
        }

        /// <summary>
        /// The number of assignees who need to have provided their approval before the status of the project task gets updated to "Approved".
        /// </summary>
        [XurrentField("requiredApprovals")]
        public long? RequiredApprovals
        {
            get => _requiredApprovals;
            set => _requiredApprovals = Set("requiredApprovals", value);
        }

        /// <summary>
        /// Only used when work on the project task may not start before a specific date and time.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt
        {
            get => _startAt;
            set => _startAt = Set("startAt", value);
        }

        /// <summary>
        /// The current status of the project task.
        /// </summary>
        [XurrentField("status")]
        public ProjectTaskStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// A short description of the objective of the project task.
        /// </summary>
        [XurrentField("subject")]
        public string? Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Skill pool that represents the specific expertise needed to complete the task.
        /// </summary>
        [XurrentField("skillPoolId")]
        public string? SkillPoolId
        {
            get => _skillPoolId;
            set => _skillPoolId = Set("skillPoolId", value);
        }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the project task.
        /// </summary>
        [XurrentField("supplierId")]
        public string? SupplierId
        {
            get => _supplierId;
            set => _supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// The identifier under which the request to help with the execution of the project task has been registered at the supplier organization.
        /// </summary>
        [XurrentField("supplierRequestID")]
        public string? SupplierRequestID
        {
            get => _supplierRequestID;
            set => _supplierRequestID = Set("supplierRequestID", value);
        }

        /// <summary>
        /// The team to which the project task is to be assigned.
        /// </summary>
        [XurrentField("teamId")]
        public string? TeamId
        {
            get => _teamId;
            set => _teamId = Set("teamId", value);
        }

        /// <summary>
        /// The project task template that was used to register the project task.
        /// </summary>
        [XurrentField("templateId")]
        public string? TemplateId
        {
            get => _templateId;
            set => _templateId = Set("templateId", value);
        }

        /// <summary>
        /// Whether the project task is urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent
        {
            get => _urgent;
            set => _urgent = Set("urgent", value);
        }

        /// <summary>
        /// The date and time at which the status of the project task is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => _waitingUntil;
            set => _waitingUntil = Set("waitingUntil", value);
        }

        /// <summary>
        /// When set to true, the completion target of the project task is calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [XurrentField("workHoursAre24x7")]
        public bool? WorkHoursAre24x7
        {
            get => _workHoursAre24x7;
            set => _workHoursAre24x7 = Set("workHoursAre24x7", value);
        }

        /// <summary>
        /// Identifiers of the predecessors of the project task.
        /// </summary>
        [XurrentField("predecessorIds")]
        public Collection<string>? PredecessorIds
        {
            get => _predecessorIds;
            set => _predecessorIds = Set("predecessorIds", value);
        }

        /// <summary>
        /// Identifiers of the successors of the project task.
        /// </summary>
        [XurrentField("successorIds")]
        public Collection<string>? SuccessorIds
        {
            get => _successorIds;
            set => _successorIds = Set("successorIds", value);
        }

        /// <summary>
        /// Assignments of the project task.
        /// </summary>
        [XurrentField("newAssignments")]
        public Collection<ProjectTaskAssignmentInput>? NewAssignments
        {
            get => _newAssignments;
            set => _newAssignments = Set("newAssignments", value);
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
        /// Identifiers of assignments to remove from the project task.
        /// </summary>
        [XurrentField("assignmentsToDelete")]
        public Collection<string>? AssignmentsToDelete
        {
            get => _assignmentsToDelete;
            set => _assignmentsToDelete = Set("assignmentsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskUpdateInput"/> class without providing the required values.
        /// </summary>
        public ProjectTaskUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskUpdateInput"/> class.
        /// </summary>
        public ProjectTaskUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
