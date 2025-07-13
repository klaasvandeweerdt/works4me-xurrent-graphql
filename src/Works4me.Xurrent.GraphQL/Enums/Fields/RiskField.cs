using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Risk">Risk</see> fields.
    /// </summary>
    public enum RiskField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The closed at field.
        /// </summary>
        [XurrentEnum("closedAt")]
        ClosedAt,

        /// <summary>
        /// The closure reason field.
        /// </summary>
        [XurrentEnum("closureReason")]
        ClosureReason,

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
        /// The mitigation target at field.
        /// </summary>
        [XurrentEnum("mitigationTargetAt")]
        MitigationTargetAt,

        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [XurrentEnum("resolutionDuration")]
        ResolutionDuration,

        /// <summary>
        /// The risk id field.
        /// </summary>
        [XurrentEnum("riskId")]
        RiskId,

        /// <summary>
        /// The severity field.
        /// </summary>
        [XurrentEnum("severity")]
        Severity,

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
        /// The ui extension field.
        /// </summary>
        [XurrentEnum("uiExtension")]
        UiExtension,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
