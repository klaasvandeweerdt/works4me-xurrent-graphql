using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields CiStagedChange can be ordered on.
    /// </summary>
    public enum CiStagedChangeOrderField
    {
        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>ReviewedAt</c>.
        /// </summary>
        [XurrentEnum("reviewedAt")]
        ReviewedAt,

        /// <summary>
        /// Order by <c>Source</c>.
        /// </summary>
        [XurrentEnum("source")]
        Source,

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
