using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskTemplateRelation">ProjectTaskTemplateRelation</see> fields.
    /// </summary>
    public enum ProjectTaskTemplateRelationField
    {
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
        TaskTemplate
    }
}
