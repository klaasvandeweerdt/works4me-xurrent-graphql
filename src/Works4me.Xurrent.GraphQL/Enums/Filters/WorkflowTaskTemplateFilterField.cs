using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which TaskTemplate records are returned.
    /// </summary>
    public enum WorkflowTaskTemplateFilterField
    {
        /// <summary>
        /// Filter on Assignee.
        /// </summary>
        [XurrentEnum("assignee")]
        Assignee,

        /// <summary>
        /// Filter on Category.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Include only if Disabled matches supplied value.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Impact.
        /// </summary>
        [XurrentEnum("impact")]
        Impact,

        /// <summary>
        /// Include only if Provider not accountable matches supplied value.
        /// </summary>
        [XurrentEnum("providerNotAccountable")]
        ProviderNotAccountable,

        /// <summary>
        /// Filter on Skill pool.
        /// </summary>
        [XurrentEnum("skillPool")]
        SkillPool,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Filter on Source ID.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Filter on Subject.
        /// </summary>
        [XurrentEnum("subject")]
        Subject,

        /// <summary>
        /// Filter on Team.
        /// </summary>
        [XurrentEnum("team")]
        Team,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Filter on Workflow template.
        /// </summary>
        [XurrentEnum("workflowTemplate")]
        WorkflowTemplate
    }
}
