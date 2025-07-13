using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Workflow">Workflow</see> fields.
    /// </summary>
    public enum WorkflowField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The actual effort field.
        /// </summary>
        [XurrentEnum("actualEffort")]
        ActualEffort,

        /// <summary>
        /// The actual vs planned effort percentage field.
        /// </summary>
        [XurrentEnum("actualVsPlannedEffortPercentage")]
        ActualVsPlannedEffortPercentage,

        /// <summary>
        /// The category field.
        /// </summary>
        [XurrentEnum("category")]
        Category,

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
        /// The justification field.
        /// </summary>
        [XurrentEnum("justification")]
        Justification,

        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [XurrentEnum("lifeCycleState")]
        LifeCycleState,

        /// <summary>
        /// The manager field.
        /// </summary>
        [XurrentEnum("manager")]
        Manager,

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
        /// The release field.
        /// </summary>
        [XurrentEnum("release")]
        Release,

        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [XurrentEnum("resolutionDuration")]
        ResolutionDuration,

        /// <summary>
        /// The service field.
        /// </summary>
        [XurrentEnum("service")]
        Service,

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
        /// The workflow id field.
        /// </summary>
        [XurrentEnum("workflowId")]
        WorkflowId,

        /// <summary>
        /// The workflow type field.
        /// </summary>
        [XurrentEnum("workflowType")]
        WorkflowType
    }
}
