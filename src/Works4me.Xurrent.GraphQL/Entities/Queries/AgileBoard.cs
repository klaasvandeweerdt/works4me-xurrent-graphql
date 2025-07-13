using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/agileboard/">AgileBoard</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("AgileBoard")]
    public sealed class AgileBoard : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        [XurrentField("columns")]
        internal PagedResponse<AgileBoardColumn>? ColumnsCollection { get; set; }
        /// <summary>
        /// Columns of this agile board.
        /// </summary>
        public ReadOnlyDataCollection<AgileBoardColumn>? Columns { get => ColumnsCollection?.Data is null ? null : new ReadOnlyDataCollection<AgileBoardColumn>(ColumnsCollection.Data); }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Scrum sprint the agile board is currently linked to.
        /// </summary>
        [XurrentField("currentSprint")]
        public Sprint? CurrentSprint { get; internal set; }

        [XurrentField("customerRepresentativeSlas")]
        internal PagedResponse<ServiceLevelAgreement>? CustomerRepresentativeSlasCollection { get; set; }
        /// <summary>
        /// Customer representatives of these service level agreements can view this board in Self Service.
        /// </summary>
        public ReadOnlyDataCollection<ServiceLevelAgreement>? CustomerRepresentativeSlas { get => CustomerRepresentativeSlasCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceLevelAgreement>(CustomerRepresentativeSlasCollection.Data); }

        /// <summary>
        /// Description of the agile board.
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        [XurrentField("descriptionAttachments")]
        internal PagedResponse<Attachment>? DescriptionAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? DescriptionAttachments { get => DescriptionAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(DescriptionAttachmentsCollection.Data); }

        /// <summary>
        /// Whether the board may not be used to place items on.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Manager of the agile board.
        /// </summary>
        [XurrentField("manager")]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// Name of the agile board.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

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
            if (data is AgileBoard agileBoard)
            {
                ColumnsCollection?.Data?.AddRange(agileBoard.Columns);
                CustomerRepresentativeSlasCollection?.Data?.AddRange(agileBoard.CustomerRepresentativeSlas);
                DescriptionAttachmentsCollection?.Data?.AddRange(agileBoard.DescriptionAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ColumnsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ColumnsCollection.GetPageInfo("columns", depth))
                    yield return pageInfo;

            if (CustomerRepresentativeSlasCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomerRepresentativeSlasCollection.GetPageInfo("customerRepresentativeSlas", depth))
                    yield return pageInfo;

            if (DescriptionAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in DescriptionAttachmentsCollection.GetPageInfo("descriptionAttachments", depth))
                    yield return pageInfo;
        }
    }
}
