using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskTemplateAssignment">ProjectTaskTemplateAssignment</see> fields.
    /// </summary>
    public enum ProjectTaskTemplateAssignmentField
    {
        /// <summary>
        /// The assignee field.
        /// </summary>
        [XurrentEnum("assignee")]
        Assignee,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The planned effort field.
        /// </summary>
        [XurrentEnum("plannedEffort")]
        PlannedEffort
    }
}
