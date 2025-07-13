using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="BroadcastTranslation">BroadcastTranslation</see> fields.
    /// </summary>
    public enum BroadcastTranslationField
    {
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
        /// The language field.
        /// </summary>
        [XurrentEnum("language")]
        Language,

        /// <summary>
        /// The message field.
        /// </summary>
        [XurrentEnum("message")]
        Message,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
