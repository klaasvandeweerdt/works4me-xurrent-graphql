using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/service/">Service</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Service")]
    public sealed class Service : IDataItem, IHasTranslations, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The person who is responsible for ensuring that the availability targets specified in the active SLAs for the service are met.
        /// </summary>
        [XurrentField("availabilityManager")]
        public Person? AvailabilityManager { get; internal set; }

        /// <summary>
        /// The person who is responsible for ensuring that the service is not affected by incidents that are caused by capacity shortages.
        /// </summary>
        [XurrentField("capacityManager")]
        public Person? CapacityManager { get; internal set; }

        /// <summary>
        /// The person who is responsible for coordinating the changes of the service.
        /// </summary>
        [XurrentField("changeManager")]
        public Person? ChangeManager { get; internal set; }

        /// <summary>
        /// The person who is responsible for creating and maintaining the continuity plans for the service's instances that have an active SLA with a continuity target.
        /// </summary>
        [XurrentField("continuityManager")]
        public Person? ContinuityManager { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [XurrentField("customFields")]
        internal CustomFieldCollection? CustomFieldCollection { get; set; }
        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public IReadOnlyCustomFieldCollection? CustomFields { get => CustomFieldCollection is null ? null : new ReadOnlyCustomFieldCollection(CustomFieldCollection); }

        [XurrentField("customFieldsAttachments")]
        internal PagedResponse<Attachment>? CustomFieldsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? CustomFieldsAttachments { get => CustomFieldsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(CustomFieldsAttachmentsCollection.Data); }

        /// <summary>
        /// A high-level description of the service's core functionality.
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
        /// Whether the service may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The team that will, by default, be selected in the First line team field of a new service instance when it is being registered for the service.
        /// </summary>
        [XurrentField("firstLineTeam")]
        public Team? FirstLineTeam { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// A comma-separated list of words that can be used to find the service via search.
        /// </summary>
        [XurrentField("keywords")]
        public string? Keywords { get; internal set; }

        /// <summary>
        /// The person who is responsible for the quality of the knowledge articles for the service.
        /// </summary>
        [XurrentField("knowledgeManager")]
        public Person? KnowledgeManager { get; internal set; }

        /// <summary>
        /// The name of the service. The service name may be followed by the name of its core application placed between brackets.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// The person who is responsible for coordinating the problems that directly affect the service.
        /// </summary>
        [XurrentField("problemManager")]
        public Person? ProblemManager { get; internal set; }

        /// <summary>
        /// The person who is responsible for coordinating the releases of the service.
        /// </summary>
        [XurrentField("releaseManager")]
        public Person? ReleaseManager { get; internal set; }

        [XurrentField("serviceInstances")]
        internal PagedResponse<ServiceInstance>? ServiceInstancesCollection { get; set; }
        /// <summary>
        /// Service instances related to this service.
        /// </summary>
        public ReadOnlyDataCollection<ServiceInstance>? ServiceInstances { get => ServiceInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceInstance>(ServiceInstancesCollection.Data); }

        [XurrentField("serviceLevelAgreements")]
        internal PagedResponse<ServiceLevelAgreement>? ServiceLevelAgreementsCollection { get; set; }
        /// <summary>
        /// Service level agreements related to this service through the service offering.
        /// </summary>
        public ReadOnlyDataCollection<ServiceLevelAgreement>? ServiceLevelAgreements { get => ServiceLevelAgreementsCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceLevelAgreement>(ServiceLevelAgreementsCollection.Data); }

        [XurrentField("serviceOfferings")]
        internal PagedResponse<ServiceOffering>? ServiceOfferingsCollection { get; set; }
        /// <summary>
        /// Service offerings related to this service.
        /// </summary>
        public ReadOnlyDataCollection<ServiceOffering>? ServiceOfferings { get => ServiceOfferingsCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceOffering>(ServiceOfferingsCollection.Data); }

        /// <summary>
        /// The person who is responsible for ensuring that the service level targets specified in the SLAs for the service are met.
        /// </summary>
        [XurrentField("serviceOwner")]
        public Person? ServiceOwner { get; internal set; }

        /// <summary>
        /// The organization that provides the service.
        /// </summary>
        [XurrentField("serviceProvider")]
        public Organization? ServiceProvider { get; internal set; }

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
        /// The team  that will, by default, be selected in the Support team field of a service instance when one is registered for the service. Similarly, this team will be selected in the Team field of a problem when the service is related to it.
        /// </summary>
        [XurrentField("supportTeam")]
        public Team? SupportTeam { get; internal set; }

        /// <summary>
        /// Survey used to measure customer rating of this service.
        /// </summary>
        [XurrentField("survey")]
        public Survey? Survey { get; internal set; }

        [XurrentField("translations")]
        internal PagedResponse<Translation>? TranslationsCollection { get; set; }
        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Translation>? Translations { get => TranslationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Translation>(TranslationsCollection.Data); }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

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
            if (data is Service service)
            {
                CustomFieldsAttachmentsCollection?.Data?.AddRange(service.CustomFieldsAttachments);
                DescriptionAttachmentsCollection?.Data?.AddRange(service.DescriptionAttachments);
                ServiceInstancesCollection?.Data?.AddRange(service.ServiceInstances);
                ServiceLevelAgreementsCollection?.Data?.AddRange(service.ServiceLevelAgreements);
                ServiceOfferingsCollection?.Data?.AddRange(service.ServiceOfferings);
                TranslationsCollection?.Data?.AddRange(service.Translations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;

            if (DescriptionAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in DescriptionAttachmentsCollection.GetPageInfo("descriptionAttachments", depth))
                    yield return pageInfo;

            if (ServiceInstancesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceInstancesCollection.GetPageInfo("serviceInstances", depth))
                    yield return pageInfo;

            if (ServiceLevelAgreementsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceLevelAgreementsCollection.GetPageInfo("serviceLevelAgreements", depth))
                    yield return pageInfo;

            if (ServiceOfferingsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceOfferingsCollection.GetPageInfo("serviceOfferings", depth))
                    yield return pageInfo;

            if (TranslationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TranslationsCollection.GetPageInfo("translations", depth))
                    yield return pageInfo;
        }
    }
}
