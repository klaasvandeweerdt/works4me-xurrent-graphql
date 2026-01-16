using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTemplate">WorkflowTemplate</see> fields.
    /// </summary>
    public enum WorkflowTemplateField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The assign relations to workflow manager field.
        /// </summary>
        [XurrentEnum("assignRelationsToWorkflowManager")]
        AssignRelationsToWorkflowManager,

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
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

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
        /// The justification field.
        /// </summary>
        [XurrentEnum("justification")]
        Justification,

        /// <summary>
        /// The note field.
        /// </summary>
        [XurrentEnum("note")]
        Note,

        /// <summary>
        /// The prevent request completion field.
        /// </summary>
        [XurrentEnum("preventRequestCompletion")]
        PreventRequestCompletion,

        /// <summary>
        /// The recurrence field.
        /// </summary>
        [XurrentEnum("recurrence")]
        Recurrence,

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
        UpdatedAt,

        /// <summary>
        /// The workflow manager field.
        /// </summary>
        [XurrentEnum("workflowManager")]
        WorkflowManager,

        /// <summary>
        /// The workflow type field.
        /// </summary>
        [XurrentEnum("workflowType")]
        WorkflowType,

    }
}
