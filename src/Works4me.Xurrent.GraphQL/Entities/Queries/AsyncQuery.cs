using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/asyncquery/">AsyncQuery</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("AsyncQuery")]
    public sealed class AsyncQuery : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the async query was set to the status <c>completed</c>.
        /// </summary>
        [XurrentField("completedAt")]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The number of errors encountered during the execution.
        /// </summary>
        [XurrentField("errorCount")]
        public long? ErrorCount { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The person or application who created the async query.
        /// </summary>
        [XurrentField("person")]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The number of affected records.
        /// </summary>
        [XurrentField("resultCount")]
        public long? ResultCount { get; internal set; }

        /// <summary>
        /// Expiring link to the JSON result of the async query. It is available once the async query execution has been completed.
        /// </summary>
        [XurrentField("resultUrl")]
        public Uri? ResultUrl { get; internal set; }

        /// <summary>
        /// The date and time at which the async query was set to status <c>in_progress</c>.
        /// </summary>
        [XurrentField("startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// The current status of the async query. Valid values are:<br />
        ///   • <c>queued</c>: The async query has been received and is waiting to be executed.<br />
        ///   • <c>in_progress</c>: The async query is being executed.<br />
        ///   • <c>completed</c>: The async query execution has been completed. Results can be found by downloading the <c>result_url</c>.<br />
        /// </summary>
        [XurrentField("status")]
        public AsyncQueryStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
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
