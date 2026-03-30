using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="CiStagedChange">CiStagedChange</see> fields.
    /// </summary>
    public enum CiStagedChangeField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The automation rule field.
        /// </summary>
        [XurrentEnum("automationRule")]
        AutomationRule,

        /// <summary>
        /// The ci field.
        /// </summary>
        [XurrentEnum("ci")]
        Ci,

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
        /// The current values field.
        /// </summary>
        [XurrentEnum("currentValues")]
        CurrentValues,

        /// <summary>
        /// The delta field.
        /// </summary>
        [XurrentEnum("delta")]
        Delta,

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
        /// The proposed values field.
        /// </summary>
        [XurrentEnum("proposedValues")]
        ProposedValues,

        /// <summary>
        /// The reviewed at field.
        /// </summary>
        [XurrentEnum("reviewedAt")]
        ReviewedAt,

        /// <summary>
        /// The reviewed by field.
        /// </summary>
        [XurrentEnum("reviewedBy")]
        ReviewedBy,

        /// <summary>
        /// The reviewer note field.
        /// </summary>
        [XurrentEnum("reviewerNote")]
        ReviewerNote,

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
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
