using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/problem/">Problem</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Problem")]
    public sealed class Problem : IAgileBoardItem, IDataItem, IHasLifeCycleState, IHasNotes, IHasSprintBacklogItems, IHasTimeEntries, INode, IProductBacklogItem, IRecord
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
        /// Used to specify when the current assignee needs to have completed the root cause analysis of the problem.
        /// </summary>
        [XurrentField("analysisTargetAt")]
        public DateTime? AnalysisTargetAt { get; internal set; }

        /// <summary>
        /// The category of the problem.
        /// </summary>
        [XurrentField("category")]
        public ProblemCategory? Category { get; internal set; }

        [XurrentField("configurationItems")]
        internal PagedResponse<ConfigurationItem>? ConfigurationItemsCollection { get; set; }
        /// <summary>
        /// Configuration items of this problem.
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
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Used to select the extent to which the service is impacted when an incident occurs that is caused by the problem.
        /// </summary>
        [XurrentField("impact")]
        public ProblemImpact? Impact { get; internal set; }

        /// <summary>
        /// The knowledge article which instructions should be followed to resolve incidents caused by this problem until a structural solution has been implemented.
        /// </summary>
        [XurrentField("knowledgeArticle")]
        public KnowledgeArticle? KnowledgeArticle { get; internal set; }

        /// <summary>
        /// Whether the underlying cause of the problem has been found and a temporary workaround has been proposed.
        /// </summary>
        [XurrentField("knownError")]
        public bool? KnownError { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// Person who is responsible for coordinating the problem through root cause analysis, the proposal of a structural solution and ultimately its closure.
        /// </summary>
        [XurrentField("manager")]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// The person to whom the problem is to be assigned.
        /// </summary>
        [XurrentField("member")]
        public Person? Member { get; internal set; }

        [XurrentField("notes")]
        internal PagedResponse<Note>? NotesCollection { get; set; }
        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ReadOnlyDataCollection<Note>? Notes { get => NotesCollection?.Data is null ? null : new ReadOnlyDataCollection<Note>(NotesCollection.Data); }

        /// <summary>
        /// The number of minutes the member is expected to spend working on the problem.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI.
        /// </summary>
        [XurrentField("problemId")]
        public string? ProblemId { get; internal set; }

        /// <summary>
        /// Product backlog this item is placed on.
        /// </summary>
        [XurrentField("productBacklog")]
        public ProductBacklog? ProductBacklog { get; internal set; }

        /// <summary>
        /// Estimate of the relative size of this item on the product backlog.
        /// </summary>
        [XurrentField("productBacklogEstimate")]
        public long? ProductBacklogEstimate { get; internal set; }

        /// <summary>
        /// The (one based) position of this item on the backlog.
        /// </summary>
        [XurrentField("productBacklogPosition")]
        public long? ProductBacklogPosition { get; internal set; }

        /// <summary>
        /// Used to link the problem to a project.
        /// </summary>
        [XurrentField("project")]
        public Project? Project { get; internal set; }

        [XurrentField("requests")]
        internal PagedResponse<Request>? RequestsCollection { get; set; }
        /// <summary>
        /// Requests of this problem.
        /// </summary>
        public ReadOnlyDataCollection<Request>? Requests { get => RequestsCollection?.Data is null ? null : new ReadOnlyDataCollection<Request>(RequestsCollection.Data); }

        /// <summary>
        /// The number of minutes it took to complete this problem, which is calculated as the difference between the <c>createdAt</c> and <c>solvedAt</c> values.
        /// </summary>
        [XurrentField("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// The service in which instance(s) the problem resides.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

        [XurrentField("serviceInstances")]
        internal PagedResponse<ServiceInstance>? ServiceInstancesCollection { get; set; }
        /// <summary>
        /// Service instances of this problem.
        /// </summary>
        public ReadOnlyDataCollection<ServiceInstance>? ServiceInstances { get => ServiceInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceInstance>(ServiceInstancesCollection.Data); }

        /// <summary>
        /// Automatically set to the date and time at which the problem is saved with the status "Solved".
        /// </summary>
        [XurrentField("solvedAt")]
        public DateTime? SolvedAt { get; internal set; }

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
        /// The current status of the problem.
        /// </summary>
        [XurrentField("status")]
        public ProblemStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the symptoms that the problem causes.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The supplier organization that has been asked for a solution to the problem.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The identifier under which the request to help with the solution of the problem has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field.
        /// </summary>
        [XurrentField("supplierRequestID")]
        public string? SupplierRequestID { get; internal set; }

        /// <summary>
        /// The team to which the problem is to be assigned. After a service has been selected in the Service field, the support team of the service is automatically selected in this field.
        /// </summary>
        [XurrentField("team")]
        public Team? Team { get; internal set; }

        [XurrentField("timeEntries")]
        internal PagedResponse<TimeEntry>? TimeEntriesCollection { get; set; }
        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public ReadOnlyDataCollection<TimeEntry>? TimeEntries { get => TimeEntriesCollection?.Data is null ? null : new ReadOnlyDataCollection<TimeEntry>(TimeEntriesCollection.Data); }

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
        /// Whether the problem has been marked as urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// The date and time at which the status of the problem is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

        /// <summary>
        /// Used to describe the temporary workaround that should be applied to resolve incidents caused by this problem until a structural solution has been implemented.
        /// </summary>
        [XurrentField("workaround")]
        public string? Workaround { get; internal set; }

        [XurrentField("workaroundAttachments")]
        internal PagedResponse<Attachment>? WorkaroundAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Workaround field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? WorkaroundAttachments { get => WorkaroundAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(WorkaroundAttachmentsCollection.Data); }

        /// <summary>
        /// The workflow that will implement the proposed permanent solution for the problem.
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
            if (data is Problem problem)
            {
                ConfigurationItemsCollection?.Data?.AddRange(problem.ConfigurationItems);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(problem.CustomFieldsAttachments);
                NotesCollection?.Data?.AddRange(problem.Notes);
                RequestsCollection?.Data?.AddRange(problem.Requests);
                ServiceInstancesCollection?.Data?.AddRange(problem.ServiceInstances);
                SprintBacklogItemsCollection?.Data?.AddRange(problem.SprintBacklogItems);
                TimeEntriesCollection?.Data?.AddRange(problem.TimeEntries);
                WorkaroundAttachmentsCollection?.Data?.AddRange(problem.WorkaroundAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ConfigurationItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ConfigurationItemsCollection.GetPageInfo("configurationItems", depth))
                    yield return pageInfo;

            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;

            if (NotesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in NotesCollection.GetPageInfo("notes", depth))
                    yield return pageInfo;

            if (RequestsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RequestsCollection.GetPageInfo("requests", depth))
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

            if (WorkaroundAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in WorkaroundAttachmentsCollection.GetPageInfo("workaroundAttachments", depth))
                    yield return pageInfo;
        }
    }
}
