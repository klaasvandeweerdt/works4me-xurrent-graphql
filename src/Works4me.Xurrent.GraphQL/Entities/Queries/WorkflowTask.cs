using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/task/">WorkflowTask</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Task")]
    public sealed class WorkflowTask : IAgileBoardItem, IDataItem, IHasAutomationRules, IHasLifeCycleState, IHasNotes, IHasSprintBacklogItems, IHasTimeEntries, INode, IRecord
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
        /// The date and time at which the task is currently expected to be assigned.
        /// </summary>
        [XurrentField("anticipatedAssignmentAt")]
        public DateTime? AnticipatedAssignmentAt { get; internal set; }

        [XurrentField("approvals")]
        internal PagedResponse<TaskApproval>? ApprovalsCollection { get; set; }
        /// <summary>
        /// Approvals of the task.
        /// </summary>
        public ReadOnlyDataCollection<TaskApproval>? Approvals { get => ApprovalsCollection?.Data is null ? null : new ReadOnlyDataCollection<TaskApproval>(ApprovalsCollection.Data); }

        /// <summary>
        /// Automatically set to the current date and time when the task is assigned.
        /// </summary>
        [XurrentField("assignedAt")]
        public DateTime? AssignedAt { get; internal set; }

        [XurrentField("automationRules")]
        internal PagedResponse<AutomationRule>? AutomationRulesCollection { get; set; }
        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ReadOnlyDataCollection<AutomationRule>? AutomationRules { get => AutomationRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<AutomationRule>(AutomationRulesCollection.Data); }

        /// <summary>
        /// The category of the task. Risk &amp; impact tasks are used to help plan workflows. Approval tasks are used to collect approvals for workflows. These can be used at various stages in the life of the workflow. Implementation tasks are added to workflows for development, installation, configuration, test, transfer and administrative work that needs to be completed for the implementation of the workflow.
        /// </summary>
        [XurrentField("category")]
        public TaskCategory? Category { get; internal set; }

        /// <summary>
        /// The names of the checked items from any of the checklists in the instructions.
        /// </summary>
        [XurrentField("checkedItems")]
        public IReadOnlyList<string>? CheckedItems { get; internal set; }

        /// <summary>
        /// The date and time at which the task is expected to be completed.
        /// </summary>
        [XurrentField("completionTargetAt")]
        public DateTime? CompletionTargetAt { get; internal set; }

        [XurrentField("configurationItems")]
        internal PagedResponse<ConfigurationItem>? ConfigurationItemsCollection { get; set; }
        /// <summary>
        /// Configuration items of the task.
        /// </summary>
        public ReadOnlyDataCollection<ConfigurationItem>? ConfigurationItems { get => ConfigurationItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<ConfigurationItem>(ConfigurationItemsCollection.Data); }

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
        /// The task that will be assigned in case this task is failed or rejected.
        /// </summary>
        [XurrentField("failureTask")]
        public WorkflowTask? FailureTask { get; internal set; }

        /// <summary>
        /// Automatically set to the date and time at which the task is saved with the status "Failed", "Rejected", "Completed", "Approved" or "Canceled".
        /// </summary>
        [XurrentField("finishedAt")]
        public DateTime? FinishedAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The extent to which the service instances related to the task will be impacted by the completion of the task.
        /// </summary>
        [XurrentField("impact")]
        public TaskImpact? Impact { get; internal set; }

        /// <summary>
        /// Used to provide instructions for the person to whom the task will be assigned.
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
        /// The person to whom the task is to be assigned. This field's value is <c>null</c> in case of an approval task with multiple approvers.
        /// </summary>
        [XurrentField("member")]
        public Person? Member { get; internal set; }

        /// <summary>
        /// Influences the behavior of the note field on completion or approval.
        /// </summary>
        [XurrentField("noteBehavior")]
        public TaskNoteBehavior? NoteBehavior { get; internal set; }

        [XurrentField("notes")]
        internal PagedResponse<Note>? NotesCollection { get; set; }
        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ReadOnlyDataCollection<Note>? Notes { get => NotesCollection?.Data is null ? null : new ReadOnlyDataCollection<Note>(NotesCollection.Data); }

        /// <summary>
        /// The order line related to the fulfillment task.
        /// </summary>
        [XurrentField("orderLine")]
        public ShopOrderLine? OrderLine { get; internal set; }

        /// <summary>
        /// The PDF design associated with the task.
        /// </summary>
        [XurrentField("pdfDesign")]
        public PdfDesign? PdfDesign { get; internal set; }

        /// <summary>
        /// The phase of the workflow to which the task belongs.
        /// </summary>
        [XurrentField("phase")]
        public WorkflowPhase? Phase { get; internal set; }

        /// <summary>
        /// The number of minutes it is expected to take for the task to be completed following its assignment, or following its fixed start date and time if the Start no earlier than field is filled out.
        /// </summary>
        [XurrentField("plannedDuration")]
        public long? PlannedDuration { get; internal set; }

        /// <summary>
        /// The number of minutes the member is expected to spend working on the task.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// Whether the provider indicates not to be accountable for the affected SLAs linked to the requests that are linked to the workflow of a task that was created based on the template.
        /// </summary>
        [XurrentField("providerNotAccountable")]
        public bool? ProviderNotAccountable { get; internal set; }

        /// <summary>
        /// Automatically set to the number of times that an approval task is rejected.
        /// </summary>
        [XurrentField("rejectionCount")]
        public long? RejectionCount { get; internal set; }

        /// <summary>
        /// The request related to this task. When this request is solved the task will be completed.
        /// </summary>
        [XurrentField("request")]
        public Request? Request { get; internal set; }

        /// <summary>
        /// The service instance that should be used to create the request for this task.
        /// </summary>
        [XurrentField("requestServiceInstance")]
        public ServiceInstance? RequestServiceInstance { get; internal set; }

        /// <summary>
        /// The request template that should be used to create the request for this task.
        /// </summary>
        [XurrentField("requestTemplate")]
        public RequestTemplate? RequestTemplate { get; internal set; }

        /// <summary>
        /// The number of approvers who need to have provided their approval before the status of the task gets updated to "Approved".
        /// </summary>
        [XurrentField("requiredApprovals")]
        public long? RequiredApprovals { get; internal set; }

        /// <summary>
        /// The number of minutes it took to complete this problem, which is calculated as the difference between the <c>assignedAt</c> and <c>finishedAt</c> values.
        /// </summary>
        [XurrentField("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        [XurrentField("serviceInstances")]
        internal PagedResponse<ServiceInstance>? ServiceInstancesCollection { get; set; }
        /// <summary>
        /// Service instances of the task.
        /// </summary>
        public ReadOnlyDataCollection<ServiceInstance>? ServiceInstances { get => ServiceInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceInstance>(ServiceInstancesCollection.Data); }

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
        /// Only used when work on the task may not start before a specific date and time.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The Status field is used to select the current status of the task.
        /// </summary>
        [XurrentField("status")]
        public WorkflowTaskStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the objective of the task.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the task.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The identifier under which the request to help with the execution of the task has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field.
        /// </summary>
        [XurrentField("supplierRequestID")]
        public string? SupplierRequestID { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI.
        /// </summary>
        [XurrentField("taskId")]
        public string? TaskId { get; internal set; }

        /// <summary>
        /// The team to which the task is to be assigned.
        /// </summary>
        [XurrentField("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The task template that was used to register the task.
        /// </summary>
        [XurrentField("template")]
        public WorkflowTaskTemplate? Template { get; internal set; }

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
        /// Whether the task has been marked as urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// The date and time at which the status of the task is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

        /// <summary>
        /// When set to true, the completion target of the task is calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [XurrentField("workHoursAre24x7")]
        public bool? WorkHoursAre24x7 { get; internal set; }

        /// <summary>
        /// The workflow to which the task belongs.
        /// </summary>
        [XurrentField("workflow")]
        public Workflow? Workflow { get; internal set; }

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
            if (data is WorkflowTask workflowTask)
            {
                ApprovalsCollection?.Data?.AddRange(workflowTask.Approvals);
                AutomationRulesCollection?.Data?.AddRange(workflowTask.AutomationRules);
                ConfigurationItemsCollection?.Data?.AddRange(workflowTask.ConfigurationItems);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(workflowTask.CustomFieldsAttachments);
                InstructionsAttachmentsCollection?.Data?.AddRange(workflowTask.InstructionsAttachments);
                NotesCollection?.Data?.AddRange(workflowTask.Notes);
                ServiceInstancesCollection?.Data?.AddRange(workflowTask.ServiceInstances);
                SprintBacklogItemsCollection?.Data?.AddRange(workflowTask.SprintBacklogItems);
                TimeEntriesCollection?.Data?.AddRange(workflowTask.TimeEntries);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ApprovalsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ApprovalsCollection.GetPageInfo("approvals", depth))
                    yield return pageInfo;

            if (AutomationRulesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AutomationRulesCollection.GetPageInfo("automationRules", depth))
                    yield return pageInfo;

            if (ConfigurationItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ConfigurationItemsCollection.GetPageInfo("configurationItems", depth))
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

            if (ServiceInstancesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceInstancesCollection.GetPageInfo("serviceInstances", depth))
                    yield return pageInfo;

            if (SprintBacklogItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SprintBacklogItemsCollection.GetPageInfo("sprintBacklogItems", depth))
                    yield return pageInfo;

            if (TimeEntriesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TimeEntriesCollection.GetPageInfo("timeEntries", depth))
                    yield return pageInfo;
        }
    }
}
