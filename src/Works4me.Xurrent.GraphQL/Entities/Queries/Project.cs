using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/project/">Project</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Project")]
    public sealed class Project : IDataItem, IHasInvoices, IHasLifeCycleState, IHasNotes, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Whether the project has been approved and no longer needs to be considered for funding by portfolio management.
        /// </summary>
        [XurrentField("budgetAllocated")]
        public bool? BudgetAllocated { get; internal set; }

        /// <summary>
        /// The category of the project.
        /// </summary>
        [XurrentField("category")]
        public string? Category { get; internal set; }

        /// <summary>
        /// Automatically set to the date and time at which the project is saved with the status "Completed".
        /// </summary>
        [XurrentField("completedAt")]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The appropriate completion reason for the project when it has been completed. It is automatically set to "Complete" when all tasks related to the project have reached the status "Completed", "Approved" or "Canceled".
        /// </summary>
        [XurrentField("completionReason")]
        public ProjectCompletionReason? CompletionReason { get; internal set; }

        /// <summary>
        /// The target date and time of the last task of the project.
        /// </summary>
        [XurrentField("completionTargetAt")]
        public DateTime? CompletionTargetAt { get; internal set; }

        /// <summary>
        /// The estimated cost of the effort that will be needed from internal employees and/or long-term contractors to implement the project.
        /// </summary>
        [XurrentField("costOfEffort")]
        public decimal? CostOfEffort { get; internal set; }

        /// <summary>
        /// The estimated cost of all purchases (for equipment, consulting effort, licenses, etc.) needed to implement the project. Recurring costs that will be incurred following the implementation of the project are to be included for the entire ROI calculation period.
        /// </summary>
        [XurrentField("costOfPurchases")]
        public decimal? CostOfPurchases { get; internal set; }

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
        /// Used to select the organization for which the project is to be implemented.
        /// </summary>
        [XurrentField("customer")]
        public Organization? Customer { get; internal set; }

        /// <summary>
        /// The estimated number of hours of effort that will be needed from internal employees and/or long-term contractors to implement the project.
        /// </summary>
        [XurrentField("effort")]
        public long? Effort { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        [XurrentField("invoices")]
        internal PagedResponse<Invoice>? InvoicesCollection { get; set; }
        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Invoice>? Invoices { get => InvoicesCollection?.Data is null ? null : new ReadOnlyDataCollection<Invoice>(InvoicesCollection.Data); }

        /// <summary>
        /// The reason why the project should be considered for implementation.
        /// </summary>
        [XurrentField("justification")]
        public ProjectJustification? Justification { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The person who is responsible for coordinating the implementation of the project.
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
        internal PagedResponse<ProjectPhase>? PhasesCollection { get; set; }
        /// <summary>
        /// Phases of the project.
        /// </summary>
        public ReadOnlyDataCollection<ProjectPhase>? Phases { get => PhasesCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectPhase>(PhasesCollection.Data); }

        [XurrentField("problems")]
        internal PagedResponse<Problem>? ProblemsCollection { get; set; }
        /// <summary>
        /// Problems of the project.
        /// </summary>
        public ReadOnlyDataCollection<Problem>? Problems { get => ProblemsCollection?.Data is null ? null : new ReadOnlyDataCollection<Problem>(ProblemsCollection.Data); }

        /// <summary>
        /// Used to indicate which program the project is a part of.
        /// </summary>
        [XurrentField("program")]
        public string? Program { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI.
        /// </summary>
        [XurrentField("projectId")]
        public string? ProjectId { get; internal set; }

        [XurrentField("requests")]
        internal PagedResponse<Request>? RequestsCollection { get; set; }
        /// <summary>
        /// Requests of the project.
        /// </summary>
        public ReadOnlyDataCollection<Request>? Requests { get => RequestsCollection?.Data is null ? null : new ReadOnlyDataCollection<Request>(RequestsCollection.Data); }

        /// <summary>
        /// The number of minutes it took to complete this project, which is calculated as the difference between the <c>createdAt</c> and <c>completedAt</c> values.
        /// </summary>
        [XurrentField("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// The risk level of the project.
        /// </summary>
        [XurrentField("riskLevel")]
        public string? RiskLevel { get; internal set; }

        [XurrentField("risks")]
        internal PagedResponse<Risk>? RisksCollection { get; set; }
        /// <summary>
        /// Risks of the project.
        /// </summary>
        public ReadOnlyDataCollection<Risk>? Risks { get => RisksCollection?.Data is null ? null : new ReadOnlyDataCollection<Risk>(RisksCollection.Data); }

        /// <summary>
        /// The estimated return on investment for the project. This percentage is calculated by dividing the value, minus the total costs, by the total costs and multiplying the result by 100.
        /// </summary>
        [XurrentField("roi")]
        public long? Roi { get; internal set; }

        /// <summary>
        /// The service for which the project will be implemented.
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
        /// Automatically set based on the status of the project's tasks.
        /// </summary>
        [XurrentField("status")]
        public ProjectStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the objective of the project.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        [XurrentField("tasks")]
        internal PagedResponse<ProjectTask>? TasksCollection { get; set; }
        /// <summary>
        /// Tasks of the project.
        /// </summary>
        public ReadOnlyDataCollection<ProjectTask>? Tasks { get => TasksCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectTask>(TasksCollection.Data); }

        /// <summary>
        /// The time zone that applies to the selected work hours.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// The total estimated cost to implement the project. This is the sum of the estimated cost of effort and cost of purchases.
        /// </summary>
        [XurrentField("totalCost")]
        public decimal? TotalCost { get; internal set; }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The estimated financial value that the implementation of the project will deliver for the entire ROI calculation period.
        /// </summary>
        [XurrentField("value")]
        public decimal? Value { get; internal set; }

        /// <summary>
        /// The currency of the value of this project.
        /// </summary>
        [XurrentField("valueCurrency")]
        public Currency? ValueCurrency { get; internal set; }

        /// <summary>
        /// The calendar that defines the work hours that are to be used to calculate the anticipated assignment and completion target for the tasks of the project.
        /// </summary>
        [XurrentField("workHours")]
        public Calendar? WorkHours { get; internal set; }

        [XurrentField("workflows")]
        internal PagedResponse<Workflow>? WorkflowsCollection { get; set; }
        /// <summary>
        /// Workflows of the project.
        /// </summary>
        public ReadOnlyDataCollection<Workflow>? Workflows { get => WorkflowsCollection?.Data is null ? null : new ReadOnlyDataCollection<Workflow>(WorkflowsCollection.Data); }

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
            if (data is Project project)
            {
                CustomFieldsAttachmentsCollection?.Data?.AddRange(project.CustomFieldsAttachments);
                InvoicesCollection?.Data?.AddRange(project.Invoices);
                NotesCollection?.Data?.AddRange(project.Notes);
                PhasesCollection?.Data?.AddRange(project.Phases);
                ProblemsCollection?.Data?.AddRange(project.Problems);
                RequestsCollection?.Data?.AddRange(project.Requests);
                RisksCollection?.Data?.AddRange(project.Risks);
                TasksCollection?.Data?.AddRange(project.Tasks);
                WorkflowsCollection?.Data?.AddRange(project.Workflows);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
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

            if (RisksCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RisksCollection.GetPageInfo("risks", depth))
                    yield return pageInfo;

            if (TasksCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TasksCollection.GetPageInfo("tasks", depth))
                    yield return pageInfo;

            if (WorkflowsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in WorkflowsCollection.GetPageInfo("workflows", depth))
                    yield return pageInfo;
        }
    }
}
