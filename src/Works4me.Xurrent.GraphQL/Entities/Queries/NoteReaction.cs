using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/notereaction/">NoteReaction</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("NoteReaction")]
    public sealed class NoteReaction : IDataItem, INode
    {
        /// <summary>
        /// The date and time at which the note reaction was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Note this note reaction belongs to.
        /// </summary>
        [XurrentField("note")]
        public Note? Note { get; internal set; }

        /// <summary>
        /// Person who added this note reaction.
        /// </summary>
        [XurrentField("person")]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The type of reaction added to the note. Valid values are:<br />
        ///   • 👍.<br />
        ///   • 👎.<br />
        ///   • 😀.<br />
        ///   • 😕.<br />
        ///   • 🎉.<br />
        ///   • ❤️.<br />
        /// </summary>
        [XurrentField("reaction")]
        public string? Reaction { get; internal set; }

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
