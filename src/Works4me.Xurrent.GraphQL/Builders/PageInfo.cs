using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Builders
{
    /// <summary>
    /// Represents paging cursor information for a GraphQL connection.
    /// </summary>
    internal sealed class PageInfo
    {
        /// <summary>
        /// Gets or sets the opaque cursor to use for fetching the next page.
        /// </summary>
        [XurrentField("endCursor")]
        public string? EndCursor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether there is another page of data.
        /// </summary>
        [XurrentField("hasNextPage")]
        public bool HasNextPage { get; set; }
    }
}
