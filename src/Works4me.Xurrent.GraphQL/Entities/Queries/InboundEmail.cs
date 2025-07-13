using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/inboundemail/">InboundEmail</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("InboundEmail")]
    public sealed class InboundEmail : IDataItem, INode
    {
        /// <summary>
        /// The account that received the inbound email.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The first 255 characters of the body of the inbound email.
        /// </summary>
        [XurrentField("bodyStart")]
        public string? BodyStart { get; internal set; }

        /// <summary>
        /// The value of the CC field of the inbound email.
        /// </summary>
        [XurrentField("cc")]
        public string? Cc { get; internal set; }

        /// <summary>
        /// The date and time at which the inbound email was received.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// When the inbound email did not process successfully, contains the reason why processing failed.
        /// </summary>
        [XurrentField("failureReason")]
        public string? FailureReason { get; internal set; }

        /// <summary>
        /// The sender of the inbound email.
        /// </summary>
        [XurrentField("from")]
        public string? From { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The value of the Message-ID header of the inbound email.
        /// </summary>
        [XurrentField("messageId")]
        public string? MessageId { get; internal set; }

        /// <summary>
        /// The note that was created from the inbound email.
        /// </summary>
        [XurrentField("note")]
        public Note? Note { get; internal set; }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        [XurrentField("record")]
        public IHasNotes? Record { get; internal set; }

        /// <summary>
        /// Expiring URL to download the source of the inbound email.
        /// </summary>
        [XurrentField("sourceUri")]
        public Uri? SourceUri { get; internal set; }

        /// <summary>
        /// The subject of the inbound email.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The recipient of the inbound email.
        /// </summary>
        [XurrentField("to")]
        public string? To { get; internal set; }

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
