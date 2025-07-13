using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which AutomationRule records are returned.
    /// </summary>
    public enum AutomationRuleFilterField
    {
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Filter on Project task template.
        /// </summary>
        [XurrentEnum("projectTaskTemplate")]
        ProjectTaskTemplate,

        /// <summary>
        /// Filter on Project template.
        /// </summary>
        [XurrentEnum("projectTemplate")]
        ProjectTemplate,

        /// <summary>
        /// Filter on Request template.
        /// </summary>
        [XurrentEnum("requestTemplate")]
        RequestTemplate,

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
        /// Filter on Task template.
        /// </summary>
        [XurrentEnum("taskTemplate")]
        WorkflowTaskTemplate,

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
