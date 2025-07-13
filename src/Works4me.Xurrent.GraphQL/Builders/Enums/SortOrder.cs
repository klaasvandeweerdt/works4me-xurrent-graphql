using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Sort order for the web request.
    /// </summary>
    public enum SortOrder
    {
        /// <summary>
        /// The items are sorted in ascending order.
        /// </summary>
        [XurrentEnum("asc")]
        Ascending,

        /// <summary>
        /// The items are sorted in descending order.
        /// </summary>
        [XurrentEnum("desc")]
        Descending
    }
}
