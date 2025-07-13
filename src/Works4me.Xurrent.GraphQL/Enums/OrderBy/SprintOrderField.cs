using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Sprint can be ordered on.
    /// </summary>
    public enum SprintOrderField
    {
        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>EndAt</c>.
        /// </summary>
        [XurrentEnum("endAt")]
        EndAt,

        /// <summary>
        /// Order by <c>Number</c>.
        /// </summary>
        [XurrentEnum("number")]
        Number,

        /// <summary>
        /// Order by <c>ScrumWorkspaceName</c>.
        /// </summary>
        [XurrentEnum("scrumWorkspaceName")]
        ScrumWorkspaceName,

        /// <summary>
        /// Order by <c>StartAt</c>.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt,

        /// <summary>
        /// Order by <c>Status</c>.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
