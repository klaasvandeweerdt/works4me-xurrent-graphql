using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/slacoveragegroup/">SlaCoverageGroup</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("SlaCoverageGroup")]
    public sealed class SlaCoverageGroup : IDataItem, INode, IRecord
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
        /// Any additional information about the SLA coverage group.
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        [XurrentField("descriptionAttachments")]
        internal PagedResponse<Attachment>? DescriptionAttachmentsCollection { get; set; }
        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? DescriptionAttachments { get => DescriptionAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(DescriptionAttachmentsCollection.Data); }

        /// <summary>
        /// Whether the SLA coverage group may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The name of the SLA coverage group.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        [XurrentField("people")]
        internal PagedResponse<Person>? PeopleCollection { get; set; }
        /// <summary>
        /// People of the SLA coverage group.
        /// </summary>
        public ReadOnlyDataCollection<Person>? People { get => PeopleCollection?.Data is null ? null : new ReadOnlyDataCollection<Person>(PeopleCollection.Data); }

        /// <summary>
        /// The phrase used to filter the people.
        /// </summary>
        [XurrentField("searchPhrase")]
        public string? SearchPhrase { get; internal set; }

        [XurrentField("slas")]
        internal PagedResponse<ServiceLevelAgreement>? SlasCollection { get; set; }
        /// <summary>
        /// Service level agreements linked to the SLA coverage group.
        /// </summary>
        public ReadOnlyDataCollection<ServiceLevelAgreement>? Slas { get => SlasCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceLevelAgreement>(SlasCollection.Data); }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

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
            if (data is SlaCoverageGroup slaCoverageGroup)
            {
                DescriptionAttachmentsCollection?.Data?.AddRange(slaCoverageGroup.DescriptionAttachments);
                PeopleCollection?.Data?.AddRange(slaCoverageGroup.People);
                SlasCollection?.Data?.AddRange(slaCoverageGroup.Slas);
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

            if (PeopleCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PeopleCollection.GetPageInfo("people", depth))
                    yield return pageInfo;

            if (SlasCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SlasCollection.GetPageInfo("slas", depth))
                    yield return pageInfo;
        }
    }
}
