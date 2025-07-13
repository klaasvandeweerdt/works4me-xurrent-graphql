using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ShopArticleCategory">ShopArticleCategory</see> fields.
    /// </summary>
    public enum ShopArticleCategoryField
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
        /// The full description field.
        /// </summary>
        [XurrentEnum("fullDescription")]
        FullDescription,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The parent field.
        /// </summary>
        [XurrentEnum("parent")]
        Parent,

        /// <summary>
        /// The picture uri field.
        /// </summary>
        [XurrentEnum("pictureUri")]
        PictureUri,

        /// <summary>
        /// The short description field.
        /// </summary>
        [XurrentEnum("shortDescription")]
        ShortDescription,

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
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
