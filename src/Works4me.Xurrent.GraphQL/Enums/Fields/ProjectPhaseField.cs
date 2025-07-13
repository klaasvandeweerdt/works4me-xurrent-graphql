using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectPhase">ProjectPhase</see> fields.
    /// </summary>
    public enum ProjectPhaseField
    {
        /// <summary>
        /// The completed at field.
        /// </summary>
        [XurrentEnum("completedAt")]
        CompletedAt,

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
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The position field.
        /// </summary>
        [XurrentEnum("position")]
        Position,

        /// <summary>
        /// The started at field.
        /// </summary>
        [XurrentEnum("startedAt")]
        StartedAt,

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
