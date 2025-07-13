using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskAssignment">ProjectTaskAssignment</see> fields.
    /// </summary>
    public enum ProjectTaskAssignmentField
    {
        /// <summary>
        /// The assignee field.
        /// </summary>
        [XurrentEnum("assignee")]
        Assignee,

        /// <summary>
        /// The attachment field.
        /// </summary>
        [XurrentEnum("attachment")]
        Attachment,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The planned effort field.
        /// </summary>
        [XurrentEnum("plannedEffort")]
        PlannedEffort,

        /// <summary>
        /// The status field.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The waiting until field.
        /// </summary>
        [XurrentEnum("waitingUntil")]
        WaitingUntil
    }
}
