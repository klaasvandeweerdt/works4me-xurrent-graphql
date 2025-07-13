using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which WorkflowTemplate records are returned.
    /// </summary>
    public enum WorkflowTemplateFilterField
    {
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
        /// Filter on Justification.
        /// </summary>
        [XurrentEnum("justification")]
        Justification,

        /// <summary>
        /// Filter on Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

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
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Filter on Type.
        /// </summary>
        [XurrentEnum("workflowType")]
        WorkflowType
    }
}
