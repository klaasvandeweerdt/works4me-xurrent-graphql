using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/syncset/">SyncSet</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("SyncSet")]
    public sealed class SyncSet : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Description of the sync set.
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        [XurrentField("descriptionAttachments")]
        internal PagedResponse<Attachment>? DescriptionAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the <c>description</c> field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? DescriptionAttachments { get => DescriptionAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(DescriptionAttachmentsCollection.Data); }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The latest completed snapshot of this sync set.
        /// </summary>
        [XurrentField("lastSnapshot")]
        public Snapshot? LastSnapshot { get; internal set; }

        /// <summary>
        /// The name of the sync set.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Record types included in the sync set. The types match the values supported for the <a href="https://developer.xurrent.com/v1/import/#parameters"><c>type</c> parameter of CSV import</a>.
        /// </summary>
        [XurrentField("resolvedTypes")]
        public IReadOnlyList<string>? ResolvedTypes { get; internal set; }

        [XurrentField("selectedRecords")]
        internal PagedResponse<IRecord>? SelectedRecordsCollection { get; set; }
        /// <summary>
        /// Individual records selected to be included in the sync set.
        /// </summary>
        public ReadOnlyDataCollection<IRecord>? SelectedRecords { get => SelectedRecordsCollection?.Data is null ? null : new ReadOnlyDataCollection<IRecord>(SelectedRecordsCollection.Data); }

        /// <summary>
        /// Record types for which all records are included in the sync set. The types match the values supported for the <a href="https://developer.xurrent.com/v1/import/#parameters"><c>type</c> parameter of CSV import</a>.
        /// </summary>
        [XurrentField("types")]
        public IReadOnlyList<string>? Types { get; internal set; }

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
            if (data is SyncSet syncSet)
            {
                DescriptionAttachmentsCollection?.Data?.AddRange(syncSet.DescriptionAttachments);
                SelectedRecordsCollection?.Data?.AddRange(syncSet.SelectedRecords);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (DescriptionAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in DescriptionAttachmentsCollection.GetPageInfo("descriptionAttachments", depth))
                    yield return pageInfo;

            if (SelectedRecordsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SelectedRecordsCollection.GetPageInfo("selectedRecords", depth))
                    yield return pageInfo;
        }
    }
}
