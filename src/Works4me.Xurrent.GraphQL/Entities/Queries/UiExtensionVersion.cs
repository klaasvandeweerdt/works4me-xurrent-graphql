using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/uiextensionversion/">UiExtensionVersion</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("UiExtensionVersion")]
    public sealed class UiExtensionVersion : IDataItem, INode
    {
        /// <summary>
        /// The date and time at which this version of the UI extension was activated.
        /// </summary>
        [XurrentField("activatedAt")]
        public DateTime? ActivatedAt { get; internal set; }

        /// <summary>
        /// The date and time at which this version of the UI extension was archived.
        /// </summary>
        [XurrentField("archivedAt")]
        public DateTime? ArchivedAt { get; internal set; }

        /// <summary>
        /// The date and time at which this version of the UI extension was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The CSS stylesheet.
        /// </summary>
        [XurrentField("css")]
        public string? Css { get; internal set; }

        /// <summary>
        /// The Form Definition.
        /// </summary>
        [XurrentField("formDefinition")]
        public JsonElement? FormDefinition { get; internal set; }

        /// <summary>
        /// The HTML code.
        /// </summary>
        [XurrentField("html")]
        public string? Html { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The Javascript code.
        /// </summary>
        [XurrentField("javascript")]
        public string? Javascript { get; internal set; }

        /// <summary>
        /// Indicates the location in the life-cycle.
        /// </summary>
        [XurrentField("status")]
        public UiExtensionVersionStatus? Status { get; internal set; }

        /// <summary>
        /// UI extension this version belongs to.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of this version of the UI extension. If this version of the UI extension has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The version number (1..) of this version of the UI extension.
        /// </summary>
        [XurrentField("versionNr")]
        public long? VersionNr { get; internal set; }

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
