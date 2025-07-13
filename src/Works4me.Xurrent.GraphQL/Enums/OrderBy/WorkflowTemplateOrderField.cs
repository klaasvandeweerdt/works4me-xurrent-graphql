using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields WorkflowTemplate can be ordered on.
    /// </summary>
    public enum WorkflowTemplateOrderField
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
        /// Order by <c>Impact</c>.
        /// </summary>
        [XurrentEnum("impact")]
        Impact,

        /// <summary>
        /// Order by <c>Justification</c>.
        /// </summary>
        [XurrentEnum("justification")]
        Justification,

        /// <summary>
        /// Order by <c>ServiceName</c>.
        /// </summary>
        [XurrentEnum("serviceName")]
        ServiceName,

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
