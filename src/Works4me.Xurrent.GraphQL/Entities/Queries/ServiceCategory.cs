using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/servicecategory/">ServiceCategory</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ServiceCategory")]
    public sealed class ServiceCategory : IDataItem, IHasTranslations, INode, IRecord
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
        /// A high-level description of the type of services that are included in the service category.
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        [XurrentField("descriptionAttachments")]
        internal PagedResponse<Attachment>? DescriptionAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? DescriptionAttachments { get => DescriptionAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(DescriptionAttachmentsCollection.Data); }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The name of the service category.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        [XurrentField("services")]
        internal PagedResponse<Service>? ServicesCollection { get; set; }
        /// <summary>
        /// Services of the service category.
        /// </summary>
        public ReadOnlyDataCollection<Service>? Services { get => ServicesCollection?.Data is null ? null : new ReadOnlyDataCollection<Service>(ServicesCollection.Data); }

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

        [XurrentField("translations")]
        internal PagedResponse<Translation>? TranslationsCollection { get; set; }
        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Translation>? Translations { get => TranslationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Translation>(TranslationsCollection.Data); }

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
            if (data is ServiceCategory serviceCategory)
            {
                DescriptionAttachmentsCollection?.Data?.AddRange(serviceCategory.DescriptionAttachments);
                ServicesCollection?.Data?.AddRange(serviceCategory.Services);
                TranslationsCollection?.Data?.AddRange(serviceCategory.Translations);
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

            if (ServicesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServicesCollection.GetPageInfo("services", depth))
                    yield return pageInfo;

            if (TranslationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TranslationsCollection.GetPageInfo("translations", depth))
                    yield return pageInfo;
        }
    }
}
