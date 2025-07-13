using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/configurationitem/">ConfigurationItem</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ConfigurationItem")]
    public sealed class ConfigurationItem : IDataItem, IHasInvoices, IHasLifeCycleState, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Alternate names the configuration item is also known by.
        /// </summary>
        [XurrentField("alternateNames")]
        public IReadOnlyList<string>? AlternateNames { get; internal set; }

        /// <summary>
        /// Number under which the configuration item has been registered in the financial application (e.g. SAP).
        /// </summary>
        [XurrentField("assetID")]
        public string? AssetID { get; internal set; }

        [XurrentField("ciRelations")]
        internal PagedResponse<ConfigurationItemRelation>? CiRelationsCollection { get; set; }
        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        public ReadOnlyDataCollection<ConfigurationItemRelation>? CiRelations { get => CiRelationsCollection?.Data is null ? null : new ReadOnlyDataCollection<ConfigurationItemRelation>(CiRelationsCollection.Data); }

        [XurrentField("contracts")]
        internal PagedResponse<Contract>? ContractsCollection { get; set; }
        /// <summary>
        /// All contracts of this configuration item.
        /// </summary>
        public ReadOnlyDataCollection<Contract>? Contracts { get => ContractsCollection?.Data is null ? null : new ReadOnlyDataCollection<Contract>(ContractsCollection.Data); }

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
        /// The date at which the support for this configuration item ends.
        /// </summary>
        [XurrentField("endOfSupportDate")]
#if NET6_0_OR_GREATER
        public DateOnly? EndOfSupportDate { get; internal set; }
#else
        public DateTime? EndOfSupportDate { get; internal set; }
#endif

        /// <summary>
        /// The internal organization which budget is used to pay for the configuration item. If the CI is leased or rented, the organization that pays the lease or rent is selected in this field. When creating a new CI and a value is not specified for this field, it is set to the financial owner of the CI's product.
        /// </summary>
        [XurrentField("financialOwner")]
        public Organization? FinancialOwner { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The date on which the expense for the configuration item (CI) was incurred or, if the CI is depreciated over time, the date on which the depreciation was started. This is typically the invoice date.
        /// </summary>
        [XurrentField("inUseSince")]
#if NET6_0_OR_GREATER
        public DateOnly? InUseSince { get; internal set; }
#else
        public DateTime? InUseSince { get; internal set; }
#endif

        [XurrentField("invoices")]
        internal PagedResponse<Invoice>? InvoicesCollection { get; set; }
        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Invoice>? Invoices { get => InvoicesCollection?.Data is null ? null : new ReadOnlyDataCollection<Invoice>(InvoicesCollection.Data); }

        /// <summary>
        /// The label that is attached to the configuration item (CI). A label is automatically generated using the same prefix of other CIs of the same product category, followed by the next available number as the suffix.
        /// </summary>
        [XurrentField("label")]
        public string? Label { get; internal set; }

        /// <summary>
        /// The date and time at which the configuration item was last seen.
        /// </summary>
        [XurrentField("lastSeenAt")]
        public DateTime? LastSeenAt { get; internal set; }

        /// <summary>
        /// The date through which the temporary software license certificate is valid. The license certificate expires at the end of this day.
        /// </summary>
        [XurrentField("licenseExpiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? LicenseExpiryDate { get; internal set; }
#else
        public DateTime? LicenseExpiryDate { get; internal set; }
#endif

        /// <summary>
        /// The type of license that the license certificate covers.
        /// </summary>
        [XurrentField("licenseType")]
        public CiLicenseType? LicenseType { get; internal set; }

        [XurrentField("licensedSites")]
        internal PagedResponse<Site>? LicensedSitesCollection { get; set; }
        /// <summary>
        /// Sites at which the software that is covered by the license certificate may be used.
        /// </summary>
        public ReadOnlyDataCollection<Site>? LicensedSites { get => LicensedSitesCollection?.Data is null ? null : new ReadOnlyDataCollection<Site>(LicensedSitesCollection.Data); }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The name or number of the room in which the CI is located, if it concerns a hardware CI.
        /// </summary>
        [XurrentField("location")]
        public string? Location { get; internal set; }

        /// <summary>
        /// The name of the configuration item (CI). When creating a new CI and a value is not specified for this field, it is set to the name of the CI's product.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The total number of processor cores that are installed in the server.
        /// </summary>
        [XurrentField("nrOfCores")]
        public long? NrOfCores { get; internal set; }

        /// <summary>
        /// The number of licenses that the license certificate covers.
        /// </summary>
        [XurrentField("nrOfLicenses")]
        public long? NrOfLicenses { get; internal set; }

        /// <summary>
        /// The number of processors that are installed in the server.
        /// </summary>
        [XurrentField("nrOfProcessors")]
        public long? NrOfProcessors { get; internal set; }

        /// <summary>
        /// The (software) configuration item representing the operating system of this configuration item.
        /// </summary>
        [XurrentField("operatingSystem")]
        public ConfigurationItem? OperatingSystem { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        [XurrentField("problems")]
        internal PagedResponse<Problem>? ProblemsCollection { get; set; }
        /// <summary>
        /// All problems of this configuration item.
        /// </summary>
        public ReadOnlyDataCollection<Problem>? Problems { get => ProblemsCollection?.Data is null ? null : new ReadOnlyDataCollection<Problem>(ProblemsCollection.Data); }

        /// <summary>
        /// Related product.
        /// </summary>
        [XurrentField("product")]
        public Product? Product { get; internal set; }

        /// <summary>
        /// The amount of RAM (in GB) of this configuration item.
        /// </summary>
        [XurrentField("ramAmount")]
        public decimal? RamAmount { get; internal set; }

        /// <summary>
        /// Recurrence for maintenance of the configuration item.
        /// </summary>
        [XurrentField("recurrence")]
        public Recurrence? Recurrence { get; internal set; }

        /// <summary>
        /// Any additional information about the configuration item that might prove useful. When creating a new CI and a value is not specified for this field, it is set to the remarks of the CI's product.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks { get; internal set; }

        [XurrentField("remarksAttachments")]
        internal PagedResponse<Attachment>? RemarksAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? RemarksAttachments { get => RemarksAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(RemarksAttachmentsCollection.Data); }

        [XurrentField("requests")]
        internal PagedResponse<Request>? RequestsCollection { get; set; }
        /// <summary>
        /// All requests of this configuration item.
        /// </summary>
        public ReadOnlyDataCollection<Request>? Requests { get => RequestsCollection?.Data is null ? null : new ReadOnlyDataCollection<Request>(RequestsCollection.Data); }

        /// <summary>
        /// The Rule set field is automatically set to the rule set of the product category, except when the CI is a license certificate, in which case the rule set is <c>license_certificate</c>.
        /// </summary>
        [XurrentField("ruleSet")]
        public ProductCategoryRuleSet? RuleSet { get; internal set; }

        /// <summary>
        /// Serial number of the configuration item. The concatenation of <c>product</c>'s' <c>brand</c> and <c>serialNr</c> must be unique within a Xurrent account.
        /// </summary>
        [XurrentField("serialNr")]
        public string? SerialNr { get; internal set; }

        /// <summary>
        /// Which service instance(s) the configuration item is, or will be, a part of. When creating a new CI and a value is not specified for this field, it is set to the service of the CI's product.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

        [XurrentField("serviceInstances")]
        internal PagedResponse<ServiceInstance>? ServiceInstancesCollection { get; set; }
        /// <summary>
        /// All service instances of this configuration item.
        /// </summary>
        public ReadOnlyDataCollection<ServiceInstance>? ServiceInstances { get => ServiceInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceInstance>(ServiceInstancesCollection.Data); }

        /// <summary>
        /// Where the CI is located, if it concerns a hardware CI.
        /// </summary>
        [XurrentField("site")]
        public Site? Site { get; internal set; }

        /// <summary>
        /// <c>true</c> for license certificates that may only be used at one or more specific locations.
        /// </summary>
        [XurrentField("siteLicense")]
        public bool? SiteLicense { get; internal set; }

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
        /// The appropriate status for the configuration item (CI).
        /// </summary>
        [XurrentField("status")]
        public CiStatus? Status { get; internal set; }

        /// <summary>
        /// The supplier from which the configuration item (CI) has been obtained. When creating a new CI and a value is not specified for this field, it is set to the supplier of the CI's product.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The account of the team that supports this configuration item.
        /// </summary>
        [XurrentField("supportAccount")]
        public Account? SupportAccount { get; internal set; }

        /// <summary>
        /// The team responsible for supporting the configuration item and maintaining its information in the configuration management database (CMDB). When creating a new CI and a value is not specified for this field, it is set to the support team of the CI's product. Optional when status of CI equals "Removed", required otherwise.
        /// </summary>
        [XurrentField("supportTeam")]
        public Team? SupportTeam { get; internal set; }

        /// <summary>
        /// System identifier of the configuration item.
        /// </summary>
        [XurrentField("systemID")]
        public string? SystemID { get; internal set; }

        /// <summary>
        /// <c>true</c> for license certificates that are not valid indefinitely.
        /// </summary>
        [XurrentField("temporaryLicense")]
        public bool? TemporaryLicense { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        [XurrentField("users")]
        internal PagedResponse<Person>? UsersCollection { get; set; }
        /// <summary>
        /// All users of this configuration item.
        /// </summary>
        public ReadOnlyDataCollection<Person>? Users { get => UsersCollection?.Data is null ? null : new ReadOnlyDataCollection<Person>(UsersCollection.Data); }

        /// <summary>
        /// The date through which the warranty coverage for the configuration item is valid. The warranty expires at the end of this day.
        /// </summary>
        [XurrentField("warrantyExpiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? WarrantyExpiryDate { get; internal set; }
#else
        public DateTime? WarrantyExpiryDate { get; internal set; }
#endif

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [XurrentField("workflowManager")]
        public Person? WorkflowManager { get; internal set; }

        /// <summary>
        /// The workflow template that is used to periodically maintain the configuration item.
        /// </summary>
        [XurrentField("workflowTemplate")]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }

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
            if (data is ConfigurationItem configurationItem)
            {
                CiRelationsCollection?.Data?.AddRange(configurationItem.CiRelations);
                ContractsCollection?.Data?.AddRange(configurationItem.Contracts);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(configurationItem.CustomFieldsAttachments);
                InvoicesCollection?.Data?.AddRange(configurationItem.Invoices);
                LicensedSitesCollection?.Data?.AddRange(configurationItem.LicensedSites);
                ProblemsCollection?.Data?.AddRange(configurationItem.Problems);
                RemarksAttachmentsCollection?.Data?.AddRange(configurationItem.RemarksAttachments);
                RequestsCollection?.Data?.AddRange(configurationItem.Requests);
                ServiceInstancesCollection?.Data?.AddRange(configurationItem.ServiceInstances);
                UsersCollection?.Data?.AddRange(configurationItem.Users);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (CiRelationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CiRelationsCollection.GetPageInfo("ciRelations", depth))
                    yield return pageInfo;

            if (ContractsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ContractsCollection.GetPageInfo("contracts", depth))
                    yield return pageInfo;

            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;

            if (InvoicesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InvoicesCollection.GetPageInfo("invoices", depth))
                    yield return pageInfo;

            if (LicensedSitesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in LicensedSitesCollection.GetPageInfo("licensedSites", depth))
                    yield return pageInfo;

            if (ProblemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ProblemsCollection.GetPageInfo("problems", depth))
                    yield return pageInfo;

            if (RemarksAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RemarksAttachmentsCollection.GetPageInfo("remarksAttachments", depth))
                    yield return pageInfo;

            if (RequestsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RequestsCollection.GetPageInfo("requests", depth))
                    yield return pageInfo;

            if (ServiceInstancesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceInstancesCollection.GetPageInfo("serviceInstances", depth))
                    yield return pageInfo;

            if (UsersCollection is not null)
                foreach (ExecutionPageInfo pageInfo in UsersCollection.GetPageInfo("users", depth))
                    yield return pageInfo;
        }
    }
}
