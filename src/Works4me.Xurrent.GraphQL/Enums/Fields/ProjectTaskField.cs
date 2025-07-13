using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTask">ProjectTask</see> fields.
    /// </summary>
    public enum ProjectTaskField
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
        /// The deadline field.
        /// </summary>
        [XurrentEnum("deadline")]
        Deadline,

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
        /// The note behavior field.
        /// </summary>
        [XurrentEnum("noteBehavior")]
        NoteBehavior,

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
        /// The project field.
        /// </summary>
        [XurrentEnum("project")]
        Project,

        /// <summary>
        /// The project task id field.
        /// </summary>
        [XurrentEnum("projectTaskId")]
        ProjectTaskId,

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
        /// The skill pool field.
        /// </summary>
        [XurrentEnum("skillPool")]
        SkillPool,

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
        WorkHoursAre24x7
    }
}
