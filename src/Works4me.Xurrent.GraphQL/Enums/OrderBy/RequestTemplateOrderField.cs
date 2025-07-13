using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields RequestTemplate can be ordered on.
    /// </summary>
    public enum RequestTemplateOrderField
    {
        /// <summary>
        /// Order by <c>Category</c>.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Disabled</c>.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Order by <c>EndUsers</c>.
        /// </summary>
        [XurrentEnum("endUsers")]
        EndUsers,

        /// <summary>
        /// Order by <c>Impact</c>.
        /// </summary>
        [XurrentEnum("impact")]
        Impact,

        /// <summary>
        /// Order by <c>ServiceName</c>.
        /// </summary>
        [XurrentEnum("serviceName")]
        ServiceName,

        /// <summary>
        /// Order by <c>Specialists</c>.
        /// </summary>
        [XurrentEnum("specialists")]
        Specialists,

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
