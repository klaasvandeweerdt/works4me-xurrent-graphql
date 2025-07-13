using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflow/">Workflow</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Workflow")]
    public sealed class Workflow : IDataItem, IHasAutomationRules, IHasInvoices, IHasLifeCycleState, IHasNotes, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The total time that has already been spent on the workflow. This is the sum of the time spent on each of the workflow's tasks and the requests and problems that are related to the workflow.
        /// </summary>
        [XurrentField("actualEffort")]
        public long? ActualEffort { get; internal set; }

        /// <summary>
        /// The actual effort as a percentage of the planned effort.
        /// </summary>
        [XurrentField("actualVsPlannedEffortPercentage")]
        public long? ActualVsPlannedEffortPercentage { get; internal set; }

        [XurrentField("automationRules")]
        internal PagedResponse<AutomationRule>? AutomationRulesCollection { get; set; }
        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ReadOnlyDataCollection<AutomationRule>? AutomationRules { get => AutomationRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<AutomationRule>(AutomationRulesCollection.Data); }

        /// <summary>
        /// The category of the workflow.
        /// </summary>
        [XurrentField("category")]
        public WorkflowCategory? Category { get; internal set; }

        /// <summary>
        /// The date and time at which the workflow is saved with the status "Completed".
        /// </summary>
        [XurrentField("completedAt")]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// Used to select the appropriate completion reason for the workflow when it has been completed. It is automatically set to "Complete" when all tasks related to the workflow have reached the status "Completed", "Approved" or "Canceled".
        /// </summary>
        [XurrentField("completionReason")]
        public WorkflowCompletionReason? CompletionReason { get; internal set; }

        /// <summary>
        /// Shows the target date and time of the last task of the workflow.
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
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The maximum impact level that is selected in the tasks that are a part of the workflow. This indicates the maximum extent to which the service is impacted when the implementation tasks that are related to the workflow are executed.
        /// </summary>
        [XurrentField("impact")]
        public TaskImpact? Impact { get; internal set; }

        [XurrentField("invoices")]
        internal PagedResponse<Invoice>? InvoicesCollection { get; set; }
        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Invoice>? Invoices { get => InvoicesCollection?.Data is null ? null : new ReadOnlyDataCollection<Invoice>(InvoicesCollection.Data); }

        /// <summary>
        /// The reason why the workflow was requested.
        /// </summary>
        [XurrentField("justification")]
        public WorkflowJustification? Justification { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// Who is responsible for coordinating the implementation of the workflow. If a manager is not specified for a new workflow, the API user is selected in the Manager field by default.
        /// </summary>
        [XurrentField("manager")]
        public Person? Manager { get; internal set; }

        [XurrentField("notes")]
        internal PagedResponse<Note>? NotesCollection { get; set; }
        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ReadOnlyDataCollection<Note>? Notes { get => NotesCollection?.Data is null ? null : new ReadOnlyDataCollection<Note>(NotesCollection.Data); }

        [XurrentField("phases")]
        internal PagedResponse<WorkflowPhase>? PhasesCollection { get; set; }
        /// <summary>
        /// Phases of the workflow.
        /// </summary>
        public ReadOnlyDataCollection<WorkflowPhase>? Phases { get => PhasesCollection?.Data is null ? null : new ReadOnlyDataCollection<WorkflowPhase>(PhasesCollection.Data); }

        /// <summary>
        /// The total planned effort of the workflow. This is the sum of the planned effort (or planned duration if the planned effort is empty) of the workflow's tasks.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        [XurrentField("problems")]
        internal PagedResponse<Problem>? ProblemsCollection { get; set; }
        /// <summary>
        /// All problems of this workflow.
        /// </summary>
        public ReadOnlyDataCollection<Problem>? Problems { get => ProblemsCollection?.Data is null ? null : new ReadOnlyDataCollection<Problem>(ProblemsCollection.Data); }

        /// <summary>
        /// Linked project.
        /// </summary>
        [XurrentField("project")]
        public Project? Project { get; internal set; }

        /// <summary>
        /// The release that the workflow is a part of.
        /// </summary>
        [XurrentField("release")]
        public Release? Release { get; internal set; }

        [XurrentField("requests")]
        internal PagedResponse<Request>? RequestsCollection { get; set; }
        /// <summary>
        /// All requests of this workflow.
        /// </summary>
        public ReadOnlyDataCollection<Request>? Requests { get => RequestsCollection?.Data is null ? null : new ReadOnlyDataCollection<Request>(RequestsCollection.Data); }

        /// <summary>
        /// The number of minutes it took to complete this workflow, which is calculated as the difference between the <c>createdAt</c> and <c>completedAt</c> values.
        /// </summary>
        [XurrentField("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// The service that will directly be affected by the workflow implementation, or in case of an emergency change, the service that was directly affected by the workflow implementation.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

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

        /// <summary>
        /// The date and time at which the Status field of the first tasks of the workflow will automatically be set to "Assigned".
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// Automatically set based on the status of the workflow's tasks.
        /// </summary>
        [XurrentField("status")]
        public WorkflowStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the objective of the workflow.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        [XurrentField("tasks")]
        internal PagedResponse<WorkflowTask>? TasksCollection { get; set; }
        /// <summary>
        /// All tasks of this workflow.
        /// </summary>
        public ReadOnlyDataCollection<WorkflowTask>? Tasks { get => TasksCollection?.Data is null ? null : new ReadOnlyDataCollection<WorkflowTask>(TasksCollection.Data); }

        /// <summary>
        /// The workflow template that was used to register the workflow.
        /// </summary>
        [XurrentField("template")]
        public WorkflowTemplate? Template { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI.
        /// </summary>
        [XurrentField("workflowId")]
        public string? WorkflowId { get; internal set; }

        /// <summary>
        /// Used to indicate the type of the workflow.
        /// </summary>
        [XurrentField("workflowType")]
        public string? WorkflowType { get; internal set; }

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
            if (data is Workflow workflow)
            {
                AutomationRulesCollection?.Data?.AddRange(workflow.AutomationRules);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(workflow.CustomFieldsAttachments);
                InvoicesCollection?.Data?.AddRange(workflow.Invoices);
                NotesCollection?.Data?.AddRange(workflow.Notes);
                PhasesCollection?.Data?.AddRange(workflow.Phases);
                ProblemsCollection?.Data?.AddRange(workflow.Problems);
                RequestsCollection?.Data?.AddRange(workflow.Requests);
                TasksCollection?.Data?.AddRange(workflow.Tasks);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AutomationRulesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AutomationRulesCollection.GetPageInfo("automationRules", depth))
                    yield return pageInfo;

            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;

            if (InvoicesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InvoicesCollection.GetPageInfo("invoices", depth))
                    yield return pageInfo;

            if (NotesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in NotesCollection.GetPageInfo("notes", depth))
                    yield return pageInfo;

            if (PhasesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PhasesCollection.GetPageInfo("phases", depth))
                    yield return pageInfo;

            if (ProblemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ProblemsCollection.GetPageInfo("problems", depth))
                    yield return pageInfo;

            if (RequestsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RequestsCollection.GetPageInfo("requests", depth))
                    yield return pageInfo;

            if (TasksCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TasksCollection.GetPageInfo("tasks", depth))
                    yield return pageInfo;
        }
    }
}
