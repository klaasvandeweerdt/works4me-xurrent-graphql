using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/broadcasttranslation/">BroadcastTranslation</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("BroadcastTranslation")]
    public sealed class BroadcastTranslation : IDataItem, INode
    {
        /// <summary>
        /// The date and time at which the broadcast translation was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The language of the broadcast message.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/language/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("language")]
        public string? Language { get; internal set; }

        /// <summary>
        /// Content of the broadcast in the language.
        /// </summary>
        [XurrentField("message")]
        public string? Message { get; internal set; }

        [XurrentField("messageAttachments")]
        internal PagedResponse<Attachment>? MessageAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the <c>message</c> field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? MessageAttachments { get => MessageAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(MessageAttachmentsCollection.Data); }

        /// <summary>
        /// The date and time of the last update of the  broadcast translation. If it has no updates it contains the <c>createdAt</c> value.
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
            if (data is BroadcastTranslation broadcastTranslation)
            {
                MessageAttachmentsCollection?.Data?.AddRange(broadcastTranslation.MessageAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (MessageAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in MessageAttachmentsCollection.GetPageInfo("messageAttachments", depth))
                    yield return pageInfo;
        }
    }
}
