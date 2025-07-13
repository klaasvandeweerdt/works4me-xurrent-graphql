using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/attachmentstorage/">AttachmentStorage</see> in Xurrent.
    /// </summary>
    [XurrentEntity("AttachmentStorage")]
    public sealed class AttachmentStorage : IDataItem
    {
        /// <summary>
        /// The permitted file extensions for uploads.
        /// </summary>
        [XurrentField("allowedExtensions", IsDefaultQueryProperty = true)]
        public IReadOnlyList<string>? AllowedExtensions { get; internal set; }

        /// <summary>
        /// Type of storage facility in use. One of:<br />
        ///  • <c>local</c>: On-premise environment storage.<br />
        ///  • <c>s3</c>: Cloud environment storage.<br />
        /// </summary>
        [XurrentField("provider", IsDefaultQueryProperty = true)]
        public string? Provider { get; internal set; }

        /// <summary>
        /// The mandatory fields and their values that should be added to an upload POST to the <c>uploadUri</c>.
        /// </summary>
        [XurrentField("providerParameters", IsDefaultQueryProperty = true)]
        public JsonElement? ProviderParameters { get; internal set; }

        /// <summary>
        /// The maximum size (in bytes) for uploads.
        /// </summary>
        [XurrentField("sizeLimit", IsDefaultQueryProperty = true)]
        public long? SizeLimit { get; internal set; }

        /// <summary>
        /// The URI that attachments should be uploaded to.
        /// </summary>
        [XurrentField("uploadUri", IsDefaultQueryProperty = true)]
        public Uri? UploadUri { get; internal set; }

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
