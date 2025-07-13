using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Sprint records are returned.
    /// </summary>
    public enum SprintFilterField
    {
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// End at in supplied range.
        /// </summary>
        [XurrentEnum("endAt")]
        EndAt,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Scrum workspace.
        /// </summary>
        [XurrentEnum("scrumWorkspace")]
        ScrumWorkspace,

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
        /// Start at in supplied range.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt,

        /// <summary>
        /// Filter on Status.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
