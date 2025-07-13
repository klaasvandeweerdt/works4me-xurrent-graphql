using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Request">Request</see> fields.
    /// </summary>
    public enum RequestField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The addressed field.
        /// </summary>
        [XurrentEnum("addressed")]
        Addressed,

        /// <summary>
        /// The agile board field.
        /// </summary>
        [XurrentEnum("agileBoard")]
        AgileBoard,

        /// <summary>
        /// The agile board column field.
        /// </summary>
        [XurrentEnum("agileBoardColumn")]
        AgileBoardColumn,

        /// <summary>
        /// The agile board column position field.
        /// </summary>
        [XurrentEnum("agileBoardColumnPosition")]
        AgileBoardColumnPosition,

        /// <summary>
        /// The assignment count field.
        /// </summary>
        [XurrentEnum("assignmentCount")]
        AssignmentCount,

        /// <summary>
        /// The category field.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// The checked items field.
        /// </summary>
        [XurrentEnum("checkedItems")]
        CheckedItems,

        /// <summary>
        /// The closure code field.
        /// </summary>
        [XurrentEnum("closureCode")]
        ClosureCode,

        /// <summary>
        /// The completed at field.
        /// </summary>
        [XurrentEnum("completedAt")]
        CompletedAt,

        /// <summary>
        /// The completion reason field.
        /// </summary>
        [XurrentEnum("completionReason")]
        CompletionReason,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The created by field.
        /// </summary>
        [XurrentEnum("createdBy")]
        CreatedBy,

        /// <summary>
        /// The custom fields field.
        /// </summary>
        [XurrentEnum("customFields")]
        CustomFields,

        /// <summary>
        /// The desired completion at field.
        /// </summary>
        [XurrentEnum("desiredCompletionAt")]
        DesiredCompletionAt,

        /// <summary>
        /// The downtime end at field.
        /// </summary>
        [XurrentEnum("downtimeEndAt")]
        DowntimeEndAt,

        /// <summary>
        /// The downtime start at field.
        /// </summary>
        [XurrentEnum("downtimeStartAt")]
        DowntimeStartAt,

        /// <summary>
        /// The feedback field.
        /// </summary>
        [XurrentEnum("feedback")]
        Feedback,

        /// <summary>
        /// The feedback on knowledge article field.
        /// </summary>
        [XurrentEnum("feedbackOnKnowledgeArticle")]
        FeedbackOnKnowledgeArticle,

        /// <summary>
        /// The grouped into field.
        /// </summary>
        [XurrentEnum("groupedInto")]
        GroupedInto,

        /// <summary>
        /// The grouping field.
        /// </summary>
        [XurrentEnum("grouping")]
        Grouping,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The impact field.
        /// </summary>
        [XurrentEnum("impact")]
        Impact,

        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [XurrentEnum("lifeCycleState")]
        LifeCycleState,

        /// <summary>
        /// The major incident status field.
        /// </summary>
        [XurrentEnum("majorIncidentStatus")]
        MajorIncidentStatus,

        /// <summary>
        /// The member field.
        /// </summary>
        [XurrentEnum("member")]
        Member,

        /// <summary>
        /// The next target at field.
        /// </summary>
        [XurrentEnum("nextTargetAt")]
        NextTargetAt,

        /// <summary>
        /// The organization field.
        /// </summary>
        [XurrentEnum("organization")]
        Organization,

        /// <summary>
        /// The planned effort field.
        /// </summary>
        [XurrentEnum("plannedEffort")]
        PlannedEffort,

        /// <summary>
        /// The problem field.
        /// </summary>
        [XurrentEnum("problem")]
        Problem,

        /// <summary>
        /// The product backlog field.
        /// </summary>
        [XurrentEnum("productBacklog")]
        ProductBacklog,

        /// <summary>
        /// The product backlog estimate field.
        /// </summary>
        [XurrentEnum("productBacklogEstimate")]
        ProductBacklogEstimate,

        /// <summary>
        /// The product backlog position field.
        /// </summary>
        [XurrentEnum("productBacklogPosition")]
        ProductBacklogPosition,

        /// <summary>
        /// The project field.
        /// </summary>
        [XurrentEnum("project")]
        Project,

        /// <summary>
        /// The provider not accountable field.
        /// </summary>
        [XurrentEnum("providerNotAccountable")]
        ProviderNotAccountable,

        /// <summary>
        /// The provider was not accountable field.
        /// </summary>
        [XurrentEnum("providerWasNotAccountable")]
        ProviderWasNotAccountable,

        /// <summary>
        /// The reopen count field.
        /// </summary>
        [XurrentEnum("reopenCount")]
        ReopenCount,

        /// <summary>
        /// The request id field.
        /// </summary>
        [XurrentEnum("requestId")]
        RequestId,

        /// <summary>
        /// The requested by field.
        /// </summary>
        [XurrentEnum("requestedBy")]
        RequestedBy,

        /// <summary>
        /// The requested for field.
        /// </summary>
        [XurrentEnum("requestedFor")]
        RequestedFor,

        /// <summary>
        /// The requester resolution target at field.
        /// </summary>
        [XurrentEnum("requesterResolutionTargetAt")]
        RequesterResolutionTargetAt,

        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [XurrentEnum("resolutionDuration")]
        ResolutionDuration,

        /// <summary>
        /// The resolution target at field.
        /// </summary>
        [XurrentEnum("resolutionTargetAt")]
        ResolutionTargetAt,

        /// <summary>
        /// The response target at field.
        /// </summary>
        [XurrentEnum("responseTargetAt")]
        ResponseTargetAt,

        /// <summary>
        /// The reviewed field.
        /// </summary>
        [XurrentEnum("reviewed")]
        Reviewed,

        /// <summary>
        /// The satisfaction field.
        /// </summary>
        [XurrentEnum("satisfaction")]
        Satisfaction,

        /// <summary>
        /// The satisfaction at field.
        /// </summary>
        [XurrentEnum("satisfactionAt")]
        SatisfactionAt,

        /// <summary>
        /// The service instance field.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The status field.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// The subject field.
        /// </summary>
        [XurrentEnum("subject")]
        Subject,

        /// <summary>
        /// The summary field.
        /// </summary>
        [XurrentEnum("summary")]
        Summary,

        /// <summary>
        /// The supplier field.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// The supplier request id field.
        /// </summary>
        [XurrentEnum("supplierRequestID")]
        SupplierRequestID,

        /// <summary>
        /// The task field.
        /// </summary>
        [XurrentEnum("task")]
        Task,

        /// <summary>
        /// The team field.
        /// </summary>
        [XurrentEnum("team")]
        Team,

        /// <summary>
        /// The template field.
        /// </summary>
        [XurrentEnum("template")]
        Template,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The urgent field.
        /// </summary>
        [XurrentEnum("urgent")]
        Urgent,

        /// <summary>
        /// The waiting until field.
        /// </summary>
        [XurrentEnum("waitingUntil")]
        WaitingUntil,

        /// <summary>
        /// The workflow field.
        /// </summary>
        [XurrentEnum("workflow")]
        Workflow
    }
}
