using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/seraaistudioproposedchange/">SeraAiStudioProposedChange</see> in Xurrent.
    /// </summary>
    [XurrentEntity("SeraAiStudioProposedChange")]
    public sealed class SeraAiStudioProposedChange : IDataItem
    {
        /// <summary>
        /// Identifier of this passage within the current review. Pass it as accepted or rejected when resolving the review. Stable only for as long as the review is open.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public long Id { get; internal set; }

        /// <summary>
        /// Short explanation of why this passage was changed.
        /// </summary>
        [XurrentField("note")]
        public string? Note { get; internal set; }

        /// <summary>
        /// The passage as the customer submitted it. Empty when the validation service is proposing to add text that was not there.
        /// </summary>
        [XurrentField("original")]
        public string? Original { get; internal set; }

        /// <summary>
        /// The passage as the validation service proposes it. Empty when the validation service is proposing to remove the original text.
        /// </summary>
        [XurrentField("proposed")]
        public string? Proposed { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id.ToString(CultureInfo.InvariantCulture);
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
