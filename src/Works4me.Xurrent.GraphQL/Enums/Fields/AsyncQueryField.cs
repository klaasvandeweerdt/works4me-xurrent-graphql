using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AsyncQuery">AsyncQuery</see> fields.
    /// </summary>
    public enum AsyncQueryField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

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
        /// The error count field.
        /// </summary>
        [XurrentEnum("errorCount")]
        ErrorCount,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The person field.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// The result count field.
        /// </summary>
        [XurrentEnum("resultCount")]
        ResultCount,

        /// <summary>
        /// The result url field.
        /// </summary>
        [XurrentEnum("resultUrl")]
        ResultUrl,

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
