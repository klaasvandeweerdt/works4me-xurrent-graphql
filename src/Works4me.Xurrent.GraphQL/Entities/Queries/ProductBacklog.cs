using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/productbacklog/">ProductBacklog</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ProductBacklog")]
    public sealed class ProductBacklog : IDataItem, INode, IRecord
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
        /// Description of the product backlog.
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        [XurrentField("descriptionAttachments")]
        internal PagedResponse<Attachment>? DescriptionAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? DescriptionAttachments { get => DescriptionAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(DescriptionAttachmentsCollection.Data); }

        /// <summary>
        /// Whether the backlog may not be used to place items on.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        [XurrentField("items")]
        internal PagedResponse<IProductBacklogItem>? ItemsCollection { get; set; }
        /// <summary>
        /// Items on this backlog.
        /// </summary>
        public ReadOnlyDataCollection<IProductBacklogItem>? Items { get => ItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<IProductBacklogItem>(ItemsCollection.Data); }

        /// <summary>
        /// Name of the product backlog.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// Person responsible for maximizing the value of the work done based on this product backlog.
        /// </summary>
        [XurrentField("productOwner")]
        public Person? ProductOwner { get; internal set; }

        /// <summary>
        /// Optional request template that should be used as default when creating new requests directly on this product backlog.
        /// </summary>
        [XurrentField("requestTemplate")]
        public RequestTemplate? RequestTemplate { get; internal set; }

        [XurrentField("scrumWorkspaces")]
        internal PagedResponse<ScrumWorkspace>? ScrumWorkspacesCollection { get; set; }
        /// <summary>
        /// Scrum workspaces taking items from this backlog when planning their sprints.
        /// </summary>
        public ReadOnlyDataCollection<ScrumWorkspace>? ScrumWorkspaces { get => ScrumWorkspacesCollection?.Data is null ? null : new ReadOnlyDataCollection<ScrumWorkspace>(ScrumWorkspacesCollection.Data); }

        /// <summary>
        /// Optional service instance that should be used as default when creating new requests directly on this product backlog.
        /// </summary>
        [XurrentField("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

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
            if (data is ProductBacklog productBacklog)
            {
                DescriptionAttachmentsCollection?.Data?.AddRange(productBacklog.DescriptionAttachments);
                ItemsCollection?.Data?.AddRange(productBacklog.Items);
                ScrumWorkspacesCollection?.Data?.AddRange(productBacklog.ScrumWorkspaces);
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

            if (ItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ItemsCollection.GetPageInfo("items", depth))
                    yield return pageInfo;

            if (ScrumWorkspacesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ScrumWorkspacesCollection.GetPageInfo("scrumWorkspaces", depth))
                    yield return pageInfo;
        }
    }
}
