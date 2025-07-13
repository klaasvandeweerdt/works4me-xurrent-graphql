using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represents the standard payload returned by a GraphQL mutation, including success state, client mutation ID, and errors.
    /// </summary>
    [XurrentEntity("")]
    internal sealed class MutationPayload : IDataItem
    {
        /// <summary>
        /// Gets a value indicating whether the mutation was successful.
        /// </summary>
        [XurrentField("success")]
        public bool? Success { get; internal set; }

        /// <summary>
        /// Gets the client mutation ID used to correlate mutation requests and responses.
        /// </summary>
        [XurrentField("clientMutationId", IsDefaultQueryProperty = true)]
        public bool? ClientMutationId { get; internal set; }

        /// <summary>
        /// Gets the list of validation errors returned by the mutation, if any.
        /// </summary>
        [XurrentField("errors", IsDefaultQueryProperty = true)]
        public IReadOnlyList<ValidationError>? Errors { get; internal set; }

        /// <summary>
        /// Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.
        /// </summary>
        /// <returns>A string representing the merge key for this payload instance.</returns>
        string IDataItem.GetMergeKey()
        {
            return GetHashCode().ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Merges connection data from the specified <paramref name="data"/> item into this payload instance.
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> whose connection data should be merged.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
        }

        /// <summary>
        /// Returns an empty enumeration, as mutation payloads do not support pagination.
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        /// <returns>An empty <see cref="IEnumerable{ExecutionPageInfo}"/>.</returns>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
