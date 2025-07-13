using System.Collections.Generic;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Defines methods for items that can be merged and paged within GraphQL responses.
    /// </summary>
    public interface IDataItem
    {
        /// <summary>
        /// Returns a key used for merging paged or partial data responses.
        /// </summary>
        /// <returns>A string representing the merge key for this item.</returns>
        internal string GetMergeKey();

        /// <summary>
        /// Merges connection data from the specified <paramref name="data"/> item into this item.
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into this item.</param>
        internal void MergeConnectionData(IDataItem data);

        /// <summary>
        /// Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        /// <returns>An enumerable of <see cref="ExecutionPageInfo"/> objects for each paged child collection.</returns>
        internal IEnumerable<ExecutionPageInfo> GetPageInfo(int depth);
    }
}
