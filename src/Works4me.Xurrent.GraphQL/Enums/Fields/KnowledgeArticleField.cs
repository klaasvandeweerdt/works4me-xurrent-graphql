using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="KnowledgeArticle">KnowledgeArticle</see> fields.
    /// </summary>
    public enum KnowledgeArticleField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The archive date field.
        /// </summary>
        [XurrentEnum("archiveDate")]
        ArchiveDate,

        /// <summary>
        /// The covered specialists field.
        /// </summary>
        [XurrentEnum("coveredSpecialists")]
        CoveredSpecialists,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The created by field.
        /// </summary>
        [XurrentEnum("createdBy")]
        CreatedBy,

        /// <summary>
        /// The custom fields field.
        /// </summary>
        [XurrentEnum("customFields")]
        CustomFields,

        /// <summary>
        /// The description field.
        /// </summary>
        [XurrentEnum("description")]
        Description,

        /// <summary>
        /// The end users field.
        /// </summary>
        [XurrentEnum("endUsers")]
        EndUsers,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The instructions field.
        /// </summary>
        [XurrentEnum("instructions")]
        Instructions,

        /// <summary>
        /// The internal specialists field.
        /// </summary>
        [XurrentEnum("internalSpecialists")]
        InternalSpecialists,

        /// <summary>
        /// The key contacts field.
        /// </summary>
        [XurrentEnum("keyContacts")]
        KeyContacts,

        /// <summary>
        /// The keywords field.
        /// </summary>
        [XurrentEnum("keywords")]
        Keywords,

        /// <summary>
        /// The public field.
        /// </summary>
        [XurrentEnum("public")]
        Public,

        /// <summary>
        /// The service field.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The status field.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// The subject field.
        /// </summary>
        [XurrentEnum("subject")]
        Subject,

        /// <summary>
        /// The template field.
        /// </summary>
        [XurrentEnum("template")]
        Template,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The updated by field.
        /// </summary>
        [XurrentEnum("updatedBy")]
        UpdatedBy
    }
}
