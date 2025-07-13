using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Archive">Archive</see> fields.
    /// </summary>
    public enum ArchiveField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The archived field.
        /// </summary>
        [XurrentEnum("archived")]
        Archived,

        /// <summary>
        /// The archived by field.
        /// </summary>
        [XurrentEnum("archivedBy")]
        ArchivedBy,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id
    }
}
