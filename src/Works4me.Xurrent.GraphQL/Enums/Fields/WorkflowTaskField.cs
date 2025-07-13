using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTask">WorkflowTask</see> fields.
    /// </summary>
    public enum WorkflowTaskField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

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
        /// The anticipated assignment at field.
        /// </summary>
        [XurrentEnum("anticipatedAssignmentAt")]
        AnticipatedAssignmentAt,

        /// <summary>
        /// The assigned at field.
        /// </summary>
        [XurrentEnum("assignedAt")]
        AssignedAt,

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
        /// The completion target at field.
        /// </summary>
        [XurrentEnum("completionTargetAt")]
        CompletionTargetAt,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The custom fields field.
        /// </summary>
        [XurrentEnum("customFields")]
        CustomFields,

        /// <summary>
        /// The failure task field.
        /// </summary>
        [XurrentEnum("failureTask")]
        FailureTask,

        /// <summary>
        /// The finished at field.
        /// </summary>
        [XurrentEnum("finishedAt")]
        FinishedAt,

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
        /// The instructions field.
        /// </summary>
        [XurrentEnum("instructions")]
        Instructions,

        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [XurrentEnum("lifeCycleState")]
        LifeCycleState,

        /// <summary>
        /// The member field.
        /// </summary>
        [XurrentEnum("member")]
        Member,

        /// <summary>
        /// The note behavior field.
        /// </summary>
        [XurrentEnum("noteBehavior")]
        NoteBehavior,

        /// <summary>
        /// The order line field.
        /// </summary>
        [XurrentEnum("orderLine")]
        OrderLine,

        /// <summary>
        /// The pdf design field.
        /// </summary>
        [XurrentEnum("pdfDesign")]
        PdfDesign,

        /// <summary>
        /// The phase field.
        /// </summary>
        [XurrentEnum("phase")]
        Phase,

        /// <summary>
        /// The planned duration field.
        /// </summary>
        [XurrentEnum("plannedDuration")]
        PlannedDuration,

        /// <summary>
        /// The planned effort field.
        /// </summary>
        [XurrentEnum("plannedEffort")]
        PlannedEffort,

        /// <summary>
        /// The provider not accountable field.
        /// </summary>
        [XurrentEnum("providerNotAccountable")]
        ProviderNotAccountable,

        /// <summary>
        /// The rejection count field.
        /// </summary>
        [XurrentEnum("rejectionCount")]
        RejectionCount,

        /// <summary>
        /// The request field.
        /// </summary>
        [XurrentEnum("request")]
        Request,

        /// <summary>
        /// The request service instance field.
        /// </summary>
        [XurrentEnum("requestServiceInstance")]
        RequestServiceInstance,

        /// <summary>
        /// The request template field.
        /// </summary>
        [XurrentEnum("requestTemplate")]
        RequestTemplate,

        /// <summary>
        /// The required approvals field.
        /// </summary>
        [XurrentEnum("requiredApprovals")]
        RequiredApprovals,

        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [XurrentEnum("resolutionDuration")]
        ResolutionDuration,

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
        /// The start at field.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt,

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
        /// The task id field.
        /// </summary>
        [XurrentEnum("taskId")]
        TaskId,

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
        /// The work hours are 24x7 field.
        /// </summary>
        [XurrentEnum("workHoursAre24x7")]
        WorkHoursAre24x7,

        /// <summary>
        /// The workflow field.
        /// </summary>
        [XurrentEnum("workflow")]
        Workflow
    }
}
