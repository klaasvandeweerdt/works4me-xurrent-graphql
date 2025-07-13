using System.Collections.Generic;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Builders
{
    /// <summary>
    /// Represents a paged GraphQL response for a connection query, including data nodes and page information.
    /// </summary>
    /// <typeparam name="TEntity">The entity type for each node in the connection.</typeparam>
    internal sealed class PagedResponse<TEntity> 
        where TEntity : IDataItem
    {
        /// <summary>
        /// Gets or sets the collection of data nodes returned in the current page.
        /// </summary>
        [XurrentField("nodes")]
        public DataCollection<TEntity> Data { get; set; } = new();

        /// <summary>
        /// Gets or sets the paging information for the current page.
        /// </summary>
        [XurrentField("pageInfo")]
        public PageInfo PageInfo { get; set; } = new();

        /// <summary>
        /// Gets the pagination info for this response and all nested child entities at the specified depth.
        /// </summary>
        /// <param name="fieldName">The name of the field for which paging info is being retrieved.</param>
        /// <param name="depth">The current depth in the query tree.</param>
        /// <returns>An <see cref="IEnumerable{ExecutionPageInfo}"/> representing pagination info for this and all child entities.</returns>
        public IEnumerable<ExecutionPageInfo> GetPageInfo(string fieldName, int depth)
        {
            yield return new ExecutionPageInfo(fieldName, depth, PageInfo.EndCursor, PageInfo.HasNextPage);

            foreach (TEntity child in Data)
            {
                foreach (ExecutionPageInfo childInfo in child.GetPageInfo(depth + 1))
                {
                    yield return childInfo;
                }
            }
        }
    }
}
