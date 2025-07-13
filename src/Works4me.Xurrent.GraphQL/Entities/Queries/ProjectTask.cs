using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttask/">ProjectTask</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ProjectTask")]
    public sealed class ProjectTask : IAgileBoardItem, IDataItem, IHasAutomationRules, IHasLifeCycleState, IHasNotes, IHasSprintBacklogItems, IHasTimeEntries, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        [XurrentField("agileBoard")]
        public AgileBoard? AgileBoard { get; internal set; }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        [XurrentField("agileBoardColumn")]
        public AgileBoardColumn? AgileBoardColumn { get; internal set; }

        /// <summary>
        /// The (one based) position of this item in its column.
        /// </summary>
        [XurrentField("agileBoardColumnPosition")]
        public long? AgileBoardColumnPosition { get; internal set; }

        /// <summary>
        /// The date and time at which the project task is currently expected to be assigned.
        /// </summary>
        [XurrentField("anticipatedAssignmentAt")]
        public DateTime? AnticipatedAssignmentAt { get; internal set; }

        /// <summary>
        /// Automatically set to the current date and time when the project task is assigned.
        /// </summary>
        [XurrentField("assignedAt")]
        public DateTime? AssignedAt { get; internal set; }

        [XurrentField("assignments")]
        internal PagedResponse<ProjectTaskAssignment>? AssignmentsCollection { get; set; }
        /// <summary>
        /// Assignments of the project task.
        /// </summary>
        public ReadOnlyDataCollection<ProjectTaskAssignment>? Assignments { get => AssignmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectTaskAssignment>(AssignmentsCollection.Data); }

        [XurrentField("automationRules")]
        internal PagedResponse<AutomationRule>? AutomationRulesCollection { get; set; }
        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ReadOnlyDataCollection<AutomationRule>? AutomationRules { get => AutomationRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<AutomationRule>(AutomationRulesCollection.Data); }

        /// <summary>
        /// The category of the project task. Activity tasks are used to assign project-related work to people. Approval tasks are used to collect approvals for projects. Milestones are used to mark specific points along a project's implementation plan.
        /// </summary>
        [XurrentField("category")]
        public ProjectTaskCategory? Category { get; internal set; }

        /// <summary>
        /// The names of the checked items from any of the checklists in the instructions.
        /// </summary>
        [XurrentField("checkedItems")]
        public IReadOnlyList<string>? CheckedItems { get; internal set; }

        /// <summary>
        /// The date and time at which the project task is expected to be completed.
        /// </summary>
        [XurrentField("completionTargetAt")]
        public DateTime? CompletionTargetAt { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [XurrentField("customFields")]
        internal CustomFieldCollection? CustomFieldCollection { get; set; }
        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public IReadOnlyCustomFieldCollection? CustomFields { get => CustomFieldCollection is null ? null : new ReadOnlyCustomFieldCollection(CustomFieldCollection); }

        [XurrentField("customFieldsAttachments")]
        internal PagedResponse<Attachment>? CustomFieldsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? CustomFieldsAttachments { get => CustomFieldsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(CustomFieldsAttachmentsCollection.Data); }

        /// <summary>
        /// The date and time at which the milestone needs to have been reached.
        /// </summary>
        [XurrentField("deadline")]
        public DateTime? Deadline { get; internal set; }

        /// <summary>
        /// The Finished field is automatically set to the date and time at which the project task is saved with the status "Failed", "Rejected", "Completed", "Approved" or "Canceled".
        /// </summary>
        [XurrentField("finishedAt")]
        public DateTime? FinishedAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Used to provide instructions for the person(s) to whom the project task will be assigned.
        /// </summary>
        [XurrentField("instructions")]
        public string? Instructions { get; internal set; }

        [XurrentField("instructionsAttachments")]
        internal PagedResponse<Attachment>? InstructionsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? InstructionsAttachments { get => InstructionsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(InstructionsAttachmentsCollection.Data); }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// Influences the behavior of the note field on completion or approval.
        /// </summary>
        [XurrentField("noteBehavior")]
        public ProjectTaskNoteBehavior? NoteBehavior { get; internal set; }

        [XurrentField("notes")]
        internal PagedResponse<Note>? NotesCollection { get; set; }
        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ReadOnlyDataCollection<Note>? Notes { get => NotesCollection?.Data is null ? null : new ReadOnlyDataCollection<Note>(NotesCollection.Data); }

        /// <summary>
        /// The PDF design associated with the task.
        /// </summary>
        [XurrentField("pdfDesign")]
        public PdfDesign? PdfDesign { get; internal set; }

        /// <summary>
        /// The phase of the project to which the project task belongs.
        /// </summary>
        [XurrentField("phase")]
        public ProjectPhase? Phase { get; internal set; }

        /// <summary>
        /// The number of minutes it is expected to take for the project task to be completed following its assignment, or following its fixed start date and time if the Start no earlier than field is filled out.
        /// </summary>
        [XurrentField("plannedDuration")]
        public long? PlannedDuration { get; internal set; }

        /// <summary>
        /// The number of minutes the team is expected to spend working on the project task.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        [XurrentField("predecessors")]
        internal PagedResponse<ProjectTask>? PredecessorsCollection { get; set; }
        /// <summary>
        /// Predecessors of the project task.
        /// </summary>
        public ReadOnlyDataCollection<ProjectTask>? Predecessors { get => PredecessorsCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectTask>(PredecessorsCollection.Data); }

        /// <summary>
        /// The project to which the project task belongs.
        /// </summary>
        [XurrentField("project")]
        public Project? Project { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI.
        /// </summary>
        [XurrentField("projectTaskId")]
        public string? ProjectTaskId { get; internal set; }

        /// <summary>
        /// The number of assignees who need to have provided their approval before the status of the project task gets updated to "Approved".
        /// </summary>
        [XurrentField("requiredApprovals")]
        public long? RequiredApprovals { get; internal set; }

        /// <summary>
        /// The number of minutes it took to complete this project task, which is calculated as the difference between the <c>assignedAt</c> and <c>finishedAt</c> values.
        /// </summary>
        [XurrentField("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// Skill pool that represents the specific expertise needed to complete the task.
        /// </summary>
        [XurrentField("skillPool")]
        public SkillPool? SkillPool { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

        [XurrentField("sprintBacklogItems")]
        internal PagedResponse<SprintBacklogItem>? SprintBacklogItemsCollection { get; set; }
        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<SprintBacklogItem>? SprintBacklogItems { get => SprintBacklogItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<SprintBacklogItem>(SprintBacklogItemsCollection.Data); }

        /// <summary>
        /// Only used when work on the project task may not start before a specific date and time.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The current status of the project task.
        /// </summary>
        [XurrentField("status")]
        public ProjectTaskStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the objective of the project task.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        [XurrentField("successors")]
        internal PagedResponse<ProjectTask>? SuccessorsCollection { get; set; }
        /// <summary>
        /// Successors of the project task.
        /// </summary>
        public ReadOnlyDataCollection<ProjectTask>? Successors { get => SuccessorsCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectTask>(SuccessorsCollection.Data); }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the project task.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The identifier under which the request to help with the execution of the project task has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field.
        /// </summary>
        [XurrentField("supplierRequestID")]
        public string? SupplierRequestID { get; internal set; }

        /// <summary>
        /// The team to which the project task is to be assigned.
        /// </summary>
        [XurrentField("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The project task template that was used to register the project task.
        /// </summary>
        [XurrentField("template")]
        public ProjectTaskTemplate? Template { get; internal set; }

        [XurrentField("timeEntries")]
        internal PagedResponse<TimeEntry>? TimeEntriesCollection { get; set; }
        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public ReadOnlyDataCollection<TimeEntry>? TimeEntries { get => TimeEntriesCollection?.Data is null ? null : new ReadOnlyDataCollection<TimeEntry>(TimeEntriesCollection.Data); }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether the project task is urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// The date and time at which the status of the project task is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

        /// <summary>
        /// When set to true, the completion target of the project task is calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [XurrentField("workHoursAre24x7")]
        public bool? WorkHoursAre24x7 { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is ProjectTask projectTask)
            {
                AssignmentsCollection?.Data?.AddRange(projectTask.Assignments);
                AutomationRulesCollection?.Data?.AddRange(projectTask.AutomationRules);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(projectTask.CustomFieldsAttachments);
                InstructionsAttachmentsCollection?.Data?.AddRange(projectTask.InstructionsAttachments);
                NotesCollection?.Data?.AddRange(projectTask.Notes);
                PredecessorsCollection?.Data?.AddRange(projectTask.Predecessors);
                SprintBacklogItemsCollection?.Data?.AddRange(projectTask.SprintBacklogItems);
                SuccessorsCollection?.Data?.AddRange(projectTask.Successors);
                TimeEntriesCollection?.Data?.AddRange(projectTask.TimeEntries);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AssignmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AssignmentsCollection.GetPageInfo("assignments", depth))
                    yield return pageInfo;

            if (AutomationRulesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AutomationRulesCollection.GetPageInfo("automationRules", depth))
                    yield return pageInfo;

            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;

            if (InstructionsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InstructionsAttachmentsCollection.GetPageInfo("instructionsAttachments", depth))
                    yield return pageInfo;

            if (NotesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in NotesCollection.GetPageInfo("notes", depth))
                    yield return pageInfo;

            if (PredecessorsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PredecessorsCollection.GetPageInfo("predecessors", depth))
                    yield return pageInfo;

            if (SprintBacklogItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SprintBacklogItemsCollection.GetPageInfo("sprintBacklogItems", depth))
                    yield return pageInfo;

            if (SuccessorsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SuccessorsCollection.GetPageInfo("successors", depth))
                    yield return pageInfo;

            if (TimeEntriesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TimeEntriesCollection.GetPageInfo("timeEntries", depth))
                    yield return pageInfo;
        }
    }
}
