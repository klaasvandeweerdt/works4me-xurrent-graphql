using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Problem">Problem</see> fields.
    /// </summary>
    public enum ProblemField
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
        /// The analysis target at field.
        /// </summary>
        [XurrentEnum("analysisTargetAt")]
        AnalysisTargetAt,

        /// <summary>
        /// The category field.
        /// </summary>
        [XurrentEnum("category")]
        Category,

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
        /// The knowledge article field.
        /// </summary>
        [XurrentEnum("knowledgeArticle")]
        KnowledgeArticle,

        /// <summary>
        /// The known error field.
        /// </summary>
        [XurrentEnum("knownError")]
        KnownError,

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
        /// The member field.
        /// </summary>
        [XurrentEnum("member")]
        Member,

        /// <summary>
        /// The planned effort field.
        /// </summary>
        [XurrentEnum("plannedEffort")]
        PlannedEffort,

        /// <summary>
        /// The problem id field.
        /// </summary>
        [XurrentEnum("problemId")]
        ProblemId,

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
        /// The solved at field.
        /// </summary>
        [XurrentEnum("solvedAt")]
        SolvedAt,

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
        /// The ui extension field.
        /// </summary>
        [XurrentEnum("uiExtension")]
        UiExtension,

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
        /// The workaround field.
        /// </summary>
        [XurrentEnum("workaround")]
        Workaround,

        /// <summary>
        /// The workflow field.
        /// </summary>
        [XurrentEnum("workflow")]
        Workflow
    }
}
