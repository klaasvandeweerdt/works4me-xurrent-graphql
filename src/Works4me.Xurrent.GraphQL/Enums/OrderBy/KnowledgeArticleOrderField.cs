using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields KnowledgeArticle can be ordered on.
    /// </summary>
    public enum KnowledgeArticleOrderField
    {
        /// <summary>
        /// Order by <c>CoveredSpecialists</c>.
        /// </summary>
        [XurrentEnum("coveredSpecialists")]
        CoveredSpecialists,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>CreatedByName</c>.
        /// </summary>
        [XurrentEnum("createdByName")]
        CreatedByName,

        /// <summary>
        /// Order by <c>EndUsers</c>.
        /// </summary>
        [XurrentEnum("endUsers")]
        EndUsers,

        /// <summary>
        /// Order by <c>InternalSpecialists</c>.
        /// </summary>
        [XurrentEnum("internalSpecialists")]
        InternalSpecialists,

        /// <summary>
        /// Order by <c>KeyContacts</c>.
        /// </summary>
        [XurrentEnum("keyContacts")]
        KeyContacts,

        /// <summary>
        /// Order by <c>Public</c>.
        /// </summary>
        [XurrentEnum("public")]
        Public,

        /// <summary>
        /// Order by <c>ServiceName</c>.
        /// </summary>
        [XurrentEnum("serviceName")]
        ServiceName,

        /// <summary>
        /// Order by <c>Status</c>.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Order by <c>Subject</c>.
        /// </summary>
        [XurrentEnum("subject")]
        Subject,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
