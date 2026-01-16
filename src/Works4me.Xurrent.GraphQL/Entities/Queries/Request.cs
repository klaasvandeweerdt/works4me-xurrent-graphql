using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/request/">Request</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Request")]
    public sealed class Request : IAgileBoardItem, IDataItem, IHasAutomationRules, IHasLifeCycleState, IHasNotes, IHasSprintBacklogItems, IHasTimeEntries, INode, IProductBacklogItem, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// When the Satisfaction field of the request is set to 'Dissatisfied', a person who has the Service Desk Manager role, can check the Addressed box to indicate that the requester has been conciliated.
        /// </summary>
        [XurrentField("addressed")]
        public bool? Addressed { get; internal set; }

        [XurrentField("affectedSlas")]
        internal PagedResponse<AffectedSla>? AffectedSlasCollection { get; set; }
        /// <summary>
        /// Affected SLAs of the request.
        /// </summary>
        public ReadOnlyDataCollection<AffectedSla>? AffectedSlas { get => AffectedSlasCollection?.Data is null ? null : new ReadOnlyDataCollection<AffectedSla>(AffectedSlasCollection.Data); }

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
        /// Automatically set to the number of times that the Team field of the request has been set to a team that is registered in the accounts from which the request data is retrieved. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("assignmentCount")]
        public long? AssignmentCount { get; internal set; }

        [XurrentField("automationRules")]
        internal PagedResponse<AutomationRule>? AutomationRulesCollection { get; set; }
        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ReadOnlyDataCollection<AutomationRule>? AutomationRules { get => AutomationRulesCollection?.Data is null ? null : new ReadOnlyDataCollection<AutomationRule>(AutomationRulesCollection.Data); }

        /// <summary>
        /// The category of the request.
        /// </summary>
        [XurrentField("category")]
        public RequestCategory? Category { get; internal set; }

        /// <summary>
        /// The names of the checked items from any of the checklists in the instructions.
        /// </summary>
        [XurrentField("checkedItems")]
        public IReadOnlyList<string>? CheckedItems { get; internal set; }

        /// <summary>
        /// The appropriate closure code for the request when it has been completed. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("closureCode")]
        public string? ClosureCode { get; internal set; }

        /// <summary>
        /// Automatically set to the date and time at which the request is saved with the status "Completed". This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("completedAt")]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The appropriate completion reason for the request when it has been completed. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("completionReason")]
        public RequestCompletionReason? CompletionReason { get; internal set; }

        [XurrentField("configurationItems")]
        internal PagedResponse<ConfigurationItem>? ConfigurationItemsCollection { get; set; }
        /// <summary>
        /// Configuration items of the request. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        public ReadOnlyDataCollection<ConfigurationItem>? ConfigurationItems { get => ConfigurationItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<ConfigurationItem>(ConfigurationItemsCollection.Data); }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Automatically set to the person who submitted the request.
        /// </summary>
        [XurrentField("createdBy")]
        public Person? CreatedBy { get; internal set; }

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
        /// The date and time that has been agreed on for the completion of the request. The desired completion overwrites the automatically calculated resolution target of any affected SLA that is related to the request when the desired completion is later than the affected SLA's resolution target. By default, the person selected in the Requested by field receives a notification based on the 'Desired Completion Set for Request' email template whenever the value in the Desired completion field is set, updated or removed.
        /// </summary>
        [XurrentField("desiredCompletionAt")]
        public DateTime? DesiredCompletionAt { get; internal set; }

        /// <summary>
        /// The actual date and time at which the service became available again.
        /// </summary>
        [XurrentField("downtimeEndAt")]
        public DateTime? DowntimeEndAt { get; internal set; }

        /// <summary>
        /// The actual date and time at which the service outage started.
        /// </summary>
        [XurrentField("downtimeStartAt")]
        public DateTime? DowntimeStartAt { get; internal set; }

        /// <summary>
        /// The <c>satisfiedUrl</c> and the <c>dissatisfiedUrl</c> of the <c>requestedFor</c>. In case the <c>requestedBy</c> is different form the <c>requestedFor</c>, the satisfaction link of the <c>requestedBy</c> are also included. Feedback is <c>null</c> in case no feedback for the request can be provided at this time.
        /// </summary>
        [XurrentField("feedback")]
        public Feedback? Feedback { get; internal set; }

        /// <summary>
        /// The knowledge article that this request provides feedback on.
        /// </summary>
        [XurrentField("feedbackOnKnowledgeArticle")]
        public KnowledgeArticle? FeedbackOnKnowledgeArticle { get; internal set; }

        /// <summary>
        /// The request group that is used to group the requests that have been submitted for the resolution of exactly the same incident, for the implementation of exactly the same change, for the provision of exactly the same information, etc.
        /// </summary>
        [XurrentField("groupedInto")]
        public Request? GroupedInto { get; internal set; }

        [XurrentField("groupedRequests")]
        internal PagedResponse<Request>? GroupedRequestsCollection { get; set; }
        /// <summary>
        /// Requests that are grouped into this request group.
        /// </summary>
        public ReadOnlyDataCollection<Request>? GroupedRequests { get => GroupedRequestsCollection?.Data is null ? null : new ReadOnlyDataCollection<Request>(GroupedRequestsCollection.Data); }

        /// <summary>
        /// Default: <c>none</c>.
        /// </summary>
        [XurrentField("grouping")]
        public RequestGrouping? Grouping { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The extent to which the service instance is impacted.
        /// </summary>
        [XurrentField("impact")]
        public RequestImpact? Impact { get; internal set; }

        [XurrentField("knowledgeArticles")]
        internal PagedResponse<KnowledgeArticle>? KnowledgeArticlesCollection { get; set; }
        /// <summary>
        /// Knowledge articles of the current request account.
        /// </summary>
        public ReadOnlyDataCollection<KnowledgeArticle>? KnowledgeArticles { get => KnowledgeArticlesCollection?.Data is null ? null : new ReadOnlyDataCollection<KnowledgeArticle>(KnowledgeArticlesCollection.Data); }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// Used to indicate the status in the major incident management process. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("majorIncidentStatus")]
        public RequestMajorIncidentStatus? MajorIncidentStatus { get; internal set; }

        /// <summary>
        /// The person to whom the request is to be assigned. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("member")]
        public Person? Member { get; internal set; }

        /// <summary>
        /// Empty when the status of the request is <c>completed</c>. The next target equals the response target when a response target exists and the response target is less than the desired completion. Otherwise, the next target equals the desired completion when a desired completion exists. Otherwise, if the status is <c>waiting_for_customer</c> the next target is <c>clock_stopped</c> when an affected SLA is linked to the request which Accountability field is set to <c>provider</c> or <c>supplier</c>. Otherwise, if the status is <c>waiting_for_customer</c> the next target is <c>best_effort</c>. Otherwise the next target is the resolution target when a resolution target exists. In all other cases, the next target is <c>best_effort</c>. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("nextTargetAt")]
        public DateTime? NextTargetAt { get; internal set; }

        [XurrentField("notes")]
        internal PagedResponse<Note>? NotesCollection { get; set; }
        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ReadOnlyDataCollection<Note>? Notes { get => NotesCollection?.Data is null ? null : new ReadOnlyDataCollection<Note>(NotesCollection.Data); }

        /// <summary>
        /// Automatically set when the request is saved for the first time to the organization that the person, who is selected in the Requested for field, belongs.
        /// </summary>
        [XurrentField("organization")]
        public Organization? Organization { get; internal set; }

        /// <summary>
        /// The number of minutes the member is expected to spend working on the request.
        /// </summary>
        [XurrentField("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// Used to link the request to a problem.
        /// </summary>
        [XurrentField("problem")]
        public Problem? Problem { get; internal set; }

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
        /// Used to link the request to a project.
        /// </summary>
        [XurrentField("project")]
        public Project? Project { get; internal set; }

        /// <summary>
        /// Whether the provider currently indicates not to be accountable.
        /// </summary>
        [XurrentField("providerNotAccountable")]
        public bool? ProviderNotAccountable { get; internal set; }

        /// <summary>
        /// Whether the provider has at any point in time indicated not to be accountable.
        /// </summary>
        [XurrentField("providerWasNotAccountable")]
        public bool? ProviderWasNotAccountable { get; internal set; }

        /// <summary>
        /// Automatically set to the number of times that the status of the request has changed from <c>completed</c> to a different value in the account from which the request data is retrieved. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("reopenCount")]
        public long? ReopenCount { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI.
        /// </summary>
        [XurrentField("requestId")]
        public string? RequestId { get; internal set; }

        /// <summary>
        /// The person who submitted the request.
        /// </summary>
        [XurrentField("requestedBy")]
        public Person? RequestedBy { get; internal set; }

        /// <summary>
        /// The person for whom the request was submitted. The person selected in the Requested by field is automatically selected in this field, but another person can be selected if the request is submitted for another person.
        /// </summary>
        [XurrentField("requestedFor")]
        public Person? RequestedFor { get; internal set; }

        /// <summary>
        /// Automatically set to the most stringent resolution target of the request's affected SLAs, which Accountability field is not set to <c>sla_not_affected</c> and which are linked to an SLA for which the person who is selected in the Requested for field has coverage.
        /// </summary>
        [XurrentField("requesterResolutionTargetAt")]
        public DateTime? RequesterResolutionTargetAt { get; internal set; }

        /// <summary>
        /// The number of minutes it took to complete this request, which is calculated as the difference between the <c>createdAt</c> and <c>completedAt</c> values.
        /// </summary>
        [XurrentField("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// Automatically indicates when the current assignment team needs to have completed the request. The target displayed in this field is the most stringent resolution target of the affected SLAs that are related to the request and for which the current assignment team is responsible.
        /// </summary>
        [XurrentField("resolutionTargetAt")]
        public DateTime? ResolutionTargetAt { get; internal set; }

        /// <summary>
        /// Automatically indicates when the current assignment team needs to have responded to the request. The target displayed in this field is the most stringent response target of the affected SLAs that are related to the request and for which the current assignment team is responsible.
        /// </summary>
        [XurrentField("responseTargetAt")]
        public DateTime? ResponseTargetAt { get; internal set; }

        /// <summary>
        /// A request can be marked as reviewed by the problem manager of the service of the service instance that is linked to the request. Marking a request as reviewed excludes it from the 'Requests for Problem Identification' view.<br />
        /// This field is automatically set to <c>true</c> when the Service instance field is empty, when the request is linked to a problem or workflow, or when the Grouping field is set to <c>grouped</c>. This field is also set to <c>true</c> when the completion_reason is <c>solved</c> and the impact is different from <c>top</c>.<br />
        /// </summary>
        [XurrentField("reviewed")]
        public bool? Reviewed { get; internal set; }

        /// <summary>
        /// The Satisfaction field is set when a requester uses the hyperlinks defined in the 'Request Set to Completed' email template to indicate whether or not he/she is satisfied with the manner in which a request has been handled.
        /// </summary>
        [XurrentField("satisfaction")]
        public FeedbackSatisfaction? Satisfaction { get; internal set; }

        /// <summary>
        /// The date and time the requester indicated satisfaction.
        /// </summary>
        [XurrentField("satisfactionAt")]
        public DateTime? SatisfactionAt { get; internal set; }

        /// <summary>
        /// The service instance in which the cause of the incident resides, for which the change is requested, or about which information is needed.
        /// </summary>
        [XurrentField("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

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
        /// Used to select the current status of the request. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("status")]
        public RequestStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the request.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// AI Summary created for the current request account. Be aware that the AI summary might not always be fully up to date, as it is generated manually in the user interface.
        /// </summary>
        [XurrentField("summary")]
        public string? Summary { get; internal set; }

        /// <summary>
        /// The supplier organization that has been asked to assist with the request. The supplier organization is automatically selected in this field after a service instance has been selected that is provided by an external service provider organization. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The identifier under which the request has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("supplierRequestID")]
        public string? SupplierRequestID { get; internal set; }

        [XurrentField("tags")]
        internal PagedResponse<Tag>? TagsCollection { get; set; }
        /// <summary>
        /// Tags applied to the current request account.
        /// </summary>
        public ReadOnlyDataCollection<Tag>? Tags { get => TagsCollection?.Data is null ? null : new ReadOnlyDataCollection<Tag>(TagsCollection.Data); }

        /// <summary>
        /// The task that caused the request to be automatically generated.
        /// </summary>
        [XurrentField("task")]
        public WorkflowTask? Task { get; internal set; }

        /// <summary>
        /// The team to which the request is to be assigned. By default, the first line team of the service instance that is related to the request will be selected. If a first line team has not been specified for the service instance, the support team of the service instance will be selected instead. This field is account specific, which means that its value can be different for the same request, depending on the account that has been specified in the <c>x-xurrent-account</c> header of the API call.
        /// </summary>
        [XurrentField("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The link to the request template that was last applied to the request.
        /// </summary>
        [XurrentField("template")]
        public RequestTemplate? Template { get; internal set; }

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
        /// Whether the request has been marked as urgent.
        /// </summary>
        [XurrentField("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// Used to specify the date and time at which the status of the request is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [XurrentField("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

        [XurrentField("watches")]
        internal PagedResponse<Watch>? WatchesCollection { get; set; }
        /// <summary>
        /// List of all people watching the request.
        /// </summary>
        public ReadOnlyDataCollection<Watch>? Watches { get => WatchesCollection?.Data is null ? null : new ReadOnlyDataCollection<Watch>(WatchesCollection.Data); }

        /// <summary>
        /// Used to link the request to a workflow.
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
            if (data is Request request)
            {
                AffectedSlasCollection?.Data?.AddRange(request.AffectedSlas);
                AutomationRulesCollection?.Data?.AddRange(request.AutomationRules);
                ConfigurationItemsCollection?.Data?.AddRange(request.ConfigurationItems);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(request.CustomFieldsAttachments);
                GroupedRequestsCollection?.Data?.AddRange(request.GroupedRequests);
                KnowledgeArticlesCollection?.Data?.AddRange(request.KnowledgeArticles);
                NotesCollection?.Data?.AddRange(request.Notes);
                SprintBacklogItemsCollection?.Data?.AddRange(request.SprintBacklogItems);
                TagsCollection?.Data?.AddRange(request.Tags);
                TimeEntriesCollection?.Data?.AddRange(request.TimeEntries);
                WatchesCollection?.Data?.AddRange(request.Watches);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AffectedSlasCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AffectedSlasCollection.GetPageInfo("affectedSlas", depth))
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

            if (GroupedRequestsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in GroupedRequestsCollection.GetPageInfo("groupedRequests", depth))
                    yield return pageInfo;

            if (KnowledgeArticlesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in KnowledgeArticlesCollection.GetPageInfo("knowledgeArticles", depth))
                    yield return pageInfo;

            if (NotesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in NotesCollection.GetPageInfo("notes", depth))
                    yield return pageInfo;

            if (SprintBacklogItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SprintBacklogItemsCollection.GetPageInfo("sprintBacklogItems", depth))
                    yield return pageInfo;

            if (TagsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TagsCollection.GetPageInfo("tags", depth))
                    yield return pageInfo;

            if (TimeEntriesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TimeEntriesCollection.GetPageInfo("timeEntries", depth))
                    yield return pageInfo;

            if (WatchesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in WatchesCollection.GetPageInfo("watches", depth))
                    yield return pageInfo;
        }
    }
}
