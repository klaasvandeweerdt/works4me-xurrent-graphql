using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTaskTemplateRelation">WorkflowTaskTemplateRelation</see> fields.
    /// </summary>
    public enum WorkflowTaskTemplateRelationField
    {
        /// <summary>
        /// The failure task template field.
        /// </summary>
        [XurrentEnum("failureTaskTemplate")]
        FailureTaskTemplate,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The phase field.
        /// </summary>
        [XurrentEnum("phase")]
        Phase,

        /// <summary>
        /// The task template field.
        /// </summary>
        [XurrentEnum("taskTemplate")]
        TaskTemplate,

        /// <summary>
        /// The workflow template field.
        /// </summary>
        [XurrentEnum("workflowTemplate")]
        WorkflowTemplate
    }
}
