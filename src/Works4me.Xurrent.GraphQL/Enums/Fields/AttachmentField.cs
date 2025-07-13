using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Attachment">Attachment</see> fields.
    /// </summary>
    public enum AttachmentField
    {
        /// <summary>
        /// The expiring url field.
        /// </summary>
        [XurrentEnum("expiringUrl")]
        ExpiringUrl,

        /// <summary>
        /// The filename field.
        /// </summary>
        [XurrentEnum("filename")]
        Filename,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The inline field.
        /// </summary>
        [XurrentEnum("inline")]
        Inline,

        /// <summary>
        /// The key field.
        /// </summary>
        [XurrentEnum("key")]
        Key,

        /// <summary>
        /// The size field.
        /// </summary>
        [XurrentEnum("size")]
        Size
    }
}
