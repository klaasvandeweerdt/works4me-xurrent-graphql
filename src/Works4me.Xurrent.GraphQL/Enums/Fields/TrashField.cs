using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Trash">Trash</see> fields.
    /// </summary>
    public enum TrashField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

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
        /// The trashed field.
        /// </summary>
        [XurrentEnum("trashed")]
        Trashed,

        /// <summary>
        /// The trashed by field.
        /// </summary>
        [XurrentEnum("trashedBy")]
        TrashedBy
    }
}
