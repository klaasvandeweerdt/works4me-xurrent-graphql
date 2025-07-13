using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/serviceinstance/">ServiceInstance</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ServiceInstance")]
    public sealed class ServiceInstance : IDataItem, IHasTranslations, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        [XurrentField("childServiceInstances")]
        internal PagedResponse<ServiceInstance>? ChildServiceInstancesCollection { get; set; }
        /// <summary>
        /// Children of the service instance.
        /// </summary>
        public ReadOnlyDataCollection<ServiceInstance>? ChildServiceInstances { get => ChildServiceInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceInstance>(ChildServiceInstancesCollection.Data); }

        [XurrentField("configurationItems")]
        internal PagedResponse<ConfigurationItem>? ConfigurationItemsCollection { get; set; }
        /// <summary>
        /// Configuration items of the service instance.
        /// </summary>
        public ReadOnlyDataCollection<ConfigurationItem>? ConfigurationItems { get => ConfigurationItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<ConfigurationItem>(ConfigurationItemsCollection.Data); }

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
        /// Used to select the team that will automatically be selected in the Team field of requests to which the service instance is linked after they have been submitted using Self Service or when they are generated using the Requests API, Mail API or Events API.
        /// </summary>
        [XurrentField("firstLineTeam")]
        public Team? FirstLineTeam { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The maintenance window defines the periods in which workflow tasks with an impact related to this service instance may be implemented.
        /// </summary>
        [XurrentField("maintenanceWindow")]
        public Calendar? MaintenanceWindow { get; internal set; }

        /// <summary>
        /// The name of the service instance.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        [XurrentField("parentServiceInstances")]
        internal PagedResponse<ServiceInstance>? ParentServiceInstancesCollection { get; set; }
        /// <summary>
        /// Parents of the service instance.
        /// </summary>
        public ReadOnlyDataCollection<ServiceInstance>? ParentServiceInstances { get => ParentServiceInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceInstance>(ParentServiceInstancesCollection.Data); }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// Any additional information about the service instance that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks { get; internal set; }

        [XurrentField("remarksAttachments")]
        internal PagedResponse<Attachment>? RemarksAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? RemarksAttachments { get => RemarksAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(RemarksAttachmentsCollection.Data); }

        /// <summary>
        /// The service which functionality the service instance provides.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

        [XurrentField("serviceLevelAgreements")]
        internal PagedResponse<ServiceLevelAgreement>? ServiceLevelAgreementsCollection { get; set; }
        /// <summary>
        /// Service level agreements of the service instance.
        /// </summary>
        public ReadOnlyDataCollection<ServiceLevelAgreement>? ServiceLevelAgreements { get => ServiceLevelAgreementsCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceLevelAgreement>(ServiceLevelAgreementsCollection.Data); }

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
        /// The current status of the service instance.
        /// </summary>
        [XurrentField("status")]
        public ServiceInstanceStatus? Status { get; internal set; }

        /// <summary>
        /// The team that will, by default, be selected in the Team field of a request when the service instance is manually selected in the Service instance field of the request, or when the service instance is applied from the Service Hierarchy Browser.
        /// </summary>
        [XurrentField("supportTeam")]
        public Team? SupportTeam { get; internal set; }

        /// <summary>
        /// The time zone that applies to the selected maintenance window.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

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
            if (data is ServiceInstance serviceInstance)
            {
                ChildServiceInstancesCollection?.Data?.AddRange(serviceInstance.ChildServiceInstances);
                ConfigurationItemsCollection?.Data?.AddRange(serviceInstance.ConfigurationItems);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(serviceInstance.CustomFieldsAttachments);
                ParentServiceInstancesCollection?.Data?.AddRange(serviceInstance.ParentServiceInstances);
                RemarksAttachmentsCollection?.Data?.AddRange(serviceInstance.RemarksAttachments);
                ServiceLevelAgreementsCollection?.Data?.AddRange(serviceInstance.ServiceLevelAgreements);
                TranslationsCollection?.Data?.AddRange(serviceInstance.Translations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ChildServiceInstancesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ChildServiceInstancesCollection.GetPageInfo("childServiceInstances", depth))
                    yield return pageInfo;

            if (ConfigurationItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ConfigurationItemsCollection.GetPageInfo("configurationItems", depth))
                    yield return pageInfo;

            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;

            if (ParentServiceInstancesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ParentServiceInstancesCollection.GetPageInfo("parentServiceInstances", depth))
                    yield return pageInfo;

            if (RemarksAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RemarksAttachmentsCollection.GetPageInfo("remarksAttachments", depth))
                    yield return pageInfo;

            if (ServiceLevelAgreementsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceLevelAgreementsCollection.GetPageInfo("serviceLevelAgreements", depth))
                    yield return pageInfo;

            if (TranslationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TranslationsCollection.GetPageInfo("translations", depth))
                    yield return pageInfo;
        }
    }
}
