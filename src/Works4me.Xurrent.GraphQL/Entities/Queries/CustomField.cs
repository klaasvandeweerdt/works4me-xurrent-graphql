using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/customfield/">CustomField</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("CustomField")]
    public sealed class CustomField : IDataItem
    {
        /// <summary>
        /// Id of the field as defined for the UI Extension.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Value of the field.<br />
        ///  • For <c>select</c> fields the value is the HTML <c>value</c> defined for the value (not the value shown to the user).<br />
        ///  • For <c>...-suggest</c> fields the value is the node ID of the selected record.<br />
        ///  • For <c>custom-suggest</c> fields the value is the node ID of the selected record. When multiple records are selected the value is an array of node IDs.<br />
        /// </summary>
        [XurrentField("value", IsDefaultQueryProperty = true)]
        public JsonElement? Value { get; set; }

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
