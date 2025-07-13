using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ShortUrl">ShortUrl</see> fields.
    /// </summary>
    public enum ShortUrlField
    {
        /// <summary>
        /// The access token field.
        /// </summary>
        [XurrentEnum("accessToken")]
        AccessToken,

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
        /// The data type field.
        /// </summary>
        [XurrentEnum("dataType")]
        DataType,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The shortened url field.
        /// </summary>
        [XurrentEnum("shortUrl")]
        ShortenedUrl,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The uri field.
        /// </summary>
        [XurrentEnum("uri")]
        Uri
    }
}
