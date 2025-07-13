using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which RequestTemplate records are returned.
    /// </summary>
    public enum RequestTemplateFilterField
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
        /// Include only if End users matches supplied value.
        /// </summary>
        [XurrentEnum("endUsers")]
        EndUsers,

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
        /// Filter on Member.
        /// </summary>
        [XurrentEnum("member")]
        Member,

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
        /// Include only if Specialists matches supplied value.
        /// </summary>
        [XurrentEnum("specialists")]
        Specialists,

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
        /// Filter on UI extension.
        /// </summary>
        [XurrentEnum("uiExtension")]
        UiExtension,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Filter on Workflow manager.
        /// </summary>
        [XurrentEnum("workflowManager")]
        WorkflowManager,

        /// <summary>
        /// Filter on Workflow template.
        /// </summary>
        [XurrentEnum("workflowTemplate")]
        WorkflowTemplate
    }
}
