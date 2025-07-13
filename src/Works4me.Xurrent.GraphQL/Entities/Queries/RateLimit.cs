using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/ratelimit/">RateLimit</see> in Xurrent.
    /// </summary>
    [XurrentEntity("RateLimit")]
    public sealed class RateLimit : IDataItem
    {
        /// <summary>
        /// The point cost for the current call that counts against the query cost rate limit.
        /// </summary>
        [XurrentField("cost", IsDefaultQueryProperty = true)]
        public long? Cost { get; internal set; }

        /// <summary>
        /// The maximum number of points the client is permitted to consume in a 60-minutes window.
        /// </summary>
        [XurrentField("limit", IsDefaultQueryProperty = true)]
        public long? Limit { get; internal set; }

        /// <summary>
        /// The number of points remaining in the current query cost rate limit window.
        /// </summary>
        [XurrentField("remaining", IsDefaultQueryProperty = true)]
        public long? Remaining { get; internal set; }

        /// <summary>
        /// The time at which the current query cost rate limit window resets in <a href="https://en.wikipedia.org/wiki/Unix_time">UTC epoch seconds</a>.
        /// </summary>
        [XurrentField("resetAt", IsDefaultQueryProperty = true)]
        public long? ResetAt { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return GetHashCode().ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
