using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields ShortUrl can be ordered on.
    /// </summary>
    public enum ShortUrlOrderField
    {
        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>CreatedByName</c>.
        /// </summary>
        [XurrentEnum("createdByName")]
        CreatedByName,

        /// <summary>
        /// Order by <c>DataType</c>.
        /// </summary>
        [XurrentEnum("dataType")]
        DataType,

        /// <summary>
        /// Order by <c>Uri</c>.
        /// </summary>
        [XurrentEnum("uri")]
        Uri
    }
}
