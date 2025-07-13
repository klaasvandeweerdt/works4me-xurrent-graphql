namespace Works4me.Xurrent.GraphQL.Builders
{
    /// <summary>
    /// Represents pagination state information for a specific field in a GraphQL query or response.
    /// </summary>
    internal sealed class ExecutionPageInfo
    {
        /// <summary>
        /// Gets the name of the field associated with this pagination info.
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// Gets the depth in the query hierarchy at which this pagination info applies.
        /// </summary>
        public int Depth { get; }

        /// <summary>
        /// Gets the end cursor to use for fetching the next page, if available.
        /// </summary>
        public string? EndCursor { get; }

        /// <summary>
        /// Gets a value indicating whether there are more pages available for this field.
        /// </summary>
        public bool HasNextPage { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionPageInfo"/> class.
        /// </summary>
        /// <param name="fieldName">The name of the field associated with this pagination info.</param>
        /// <param name="depth">The depth in the query hierarchy.</param>
        /// <param name="endCursor">The end cursor for pagination.</param>
        /// <param name="hasNextPage">True if there are additional pages to fetch; otherwise, false.</param>
        public ExecutionPageInfo(string fieldName, int depth, string? endCursor, bool hasNextPage)
        {
            FieldName = fieldName;
            Depth = depth;
            EndCursor = endCursor;
            HasNextPage = hasNextPage;
        }
    }
}
