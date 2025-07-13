using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/servicelevelagreement/">ServiceLevelAgreement</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ServiceLevelAgreement")]
    public sealed class ServiceLevelAgreement : IDataItem, IHasInvoices, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider. This contains the activityIDs related to request categories.
        /// </summary>
        [XurrentField("activityID")]
        public ActivityID? ActivityID { get; internal set; }

        /// <summary>
        /// The Agreement ID is the unique identifier by which all the activities that are performed through the coverage of the SLA are known in the billing system of the service provider.
        /// </summary>
        [XurrentField("agreementID")]
        public string? AgreementID { get; internal set; }

        /// <summary>
        /// Used to specify how people who are to be covered by the service level agreement are to be selected.
        /// </summary>
        [XurrentField("coverage")]
        public SlaCoverage? Coverage { get; internal set; }

        [XurrentField("coverageGroups")]
        internal PagedResponse<SlaCoverageGroup>? CoverageGroupsCollection { get; set; }
        /// <summary>
        /// Coverage groups of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>coverage_groups</c>.
        /// </summary>
        public ReadOnlyDataCollection<SlaCoverageGroup>? CoverageGroups { get => CoverageGroupsCollection?.Data is null ? null : new ReadOnlyDataCollection<SlaCoverageGroup>(CoverageGroupsCollection.Data); }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The organization that pays for the agreement.
        /// </summary>
        [XurrentField("customer")]
        public Organization? Customer { get; internal set; }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        [XurrentField("customerAccount")]
        public Account? CustomerAccount { get; internal set; }

        [XurrentField("customerRepresentatives")]
        internal PagedResponse<Person>? CustomerRepresentativesCollection { get; set; }
        /// <summary>
        /// The people who represent the customer organization for the service level agreement.
        /// </summary>
        public ReadOnlyDataCollection<Person>? CustomerRepresentatives { get => CustomerRepresentativesCollection?.Data is null ? null : new ReadOnlyDataCollection<Person>(CustomerRepresentativesCollection.Data); }

        [XurrentField("effortClassRateIDs")]
        internal PagedResponse<EffortClassRateID>? EffortClassRateIDsCollection { get; set; }
        /// <summary>
        /// The Rate IDs are the unique identifiers by which an effort class that is linked to a time entry when an activity was performed through the coverage of the SLA is known in the billing system of the service provider.
        /// </summary>
        public ReadOnlyDataCollection<EffortClassRateID>? EffortClassRateIDs { get => EffortClassRateIDsCollection?.Data is null ? null : new ReadOnlyDataCollection<EffortClassRateID>(EffortClassRateIDsCollection.Data); }

        /// <summary>
        /// The date through which the agreement will be active. The agreement expires at the end of this day if it is not renewed before then. When the agreement has expired, its status will automatically be set to <c>expired</c>.
        /// </summary>
        [XurrentField("expiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? ExpiryDate { get; internal set; }
#else
        public DateTime? ExpiryDate { get; internal set; }
#endif

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        [XurrentField("invoices")]
        internal PagedResponse<Invoice>? InvoicesCollection { get; set; }
        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Invoice>? Invoices { get => InvoicesCollection?.Data is null ? null : new ReadOnlyDataCollection<Invoice>(InvoicesCollection.Data); }

        /// <summary>
        /// The name of the service level agreement.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The last day on which the service provider organization can still be contacted to terminate the agreement to ensure that it expires on the intended expiry date. The notice date field is left empty, and the expiry date field is filled out, when the agreement is to expire on a specific date and no notice needs to be given to terminate it.
        /// </summary>
        [XurrentField("noticeDate")]
#if NET6_0_OR_GREATER
        public DateOnly? NoticeDate { get; internal set; }
#else
        public DateTime? NoticeDate { get; internal set; }
#endif

        [XurrentField("organizations")]
        internal PagedResponse<Organization>? OrganizationsCollection { get; set; }
        /// <summary>
        /// Organizations of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>organizations_and_descendants</c>, <c>organizations</c> or <c>organizations_and_sites</c>.
        /// </summary>
        public ReadOnlyDataCollection<Organization>? Organizations { get => OrganizationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Organization>(OrganizationsCollection.Data); }

        [XurrentField("people")]
        internal PagedResponse<Person>? PeopleCollection { get; set; }
        /// <summary>
        /// People of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>people</c>.
        /// </summary>
        public ReadOnlyDataCollection<Person>? People { get => PeopleCollection?.Data is null ? null : new ReadOnlyDataCollection<Person>(PeopleCollection.Data); }

        /// <summary>
        /// Any additional information about the service level agreement that might prove useful.
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
        /// The service instance that will be used to provide the service to the customer of the service level agreement. Only service instances that are linked to the same service as the selected service offering can be selected.
        /// </summary>
        [XurrentField("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

        [XurrentField("serviceInstances")]
        internal PagedResponse<ParentServiceInstance>? ServiceInstancesCollection { get; set; }
        /// <summary>
        /// The service instances that consume the service instance for which the service level agreement is registered. Only available for service level agreements where the <c>coverage</c> field is set to <c>service_instances</c>.
        /// </summary>
        public ReadOnlyDataCollection<ParentServiceInstance>? ServiceInstances { get => ServiceInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<ParentServiceInstance>(ServiceInstancesCollection.Data); }

        /// <summary>
        /// The person of the service provider organization who acts as the service level manager for the customer of the service level agreement.
        /// </summary>
        [XurrentField("serviceLevelManager")]
        public Person? ServiceLevelManager { get; internal set; }

        /// <summary>
        /// Service offering that specifies the conditions that apply to the service level agreement.
        /// </summary>
        [XurrentField("serviceOffering")]
        public ServiceOffering? ServiceOffering { get; internal set; }

        [XurrentField("sites")]
        internal PagedResponse<Site>? SitesCollection { get; set; }
        /// <summary>
        /// Sites of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>sites</c> or <c>organizations_and_sites</c>.
        /// </summary>
        public ReadOnlyDataCollection<Site>? Sites { get => SitesCollection?.Data is null ? null : new ReadOnlyDataCollection<Site>(SitesCollection.Data); }

        [XurrentField("skillPools")]
        internal PagedResponse<SkillPool>? SkillPoolsCollection { get; set; }
        /// <summary>
        /// Skill pools of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>skill_pools</c>.
        /// </summary>
        public ReadOnlyDataCollection<SkillPool>? SkillPools { get => SkillPoolsCollection?.Data is null ? null : new ReadOnlyDataCollection<SkillPool>(SkillPoolsCollection.Data); }

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

        [XurrentField("standardServiceRequestActivityIDs")]
        internal PagedResponse<StandardServiceRequestActivityID>? StandardServiceRequestActivityIDsCollection { get; set; }
        /// <summary>
        /// Represents the activityIDs for standard service requests. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        public ReadOnlyDataCollection<StandardServiceRequestActivityID>? StandardServiceRequestActivityIDs { get => StandardServiceRequestActivityIDsCollection?.Data is null ? null : new ReadOnlyDataCollection<StandardServiceRequestActivityID>(StandardServiceRequestActivityIDsCollection.Data); }

        /// <summary>
        /// The first day during which the agreement is active.
        /// </summary>
        [XurrentField("startDate")]
#if NET6_0_OR_GREATER
        public DateOnly? StartDate { get; internal set; }
#else
        public DateTime? StartDate { get; internal set; }
#endif

        /// <summary>
        /// The current status of the agreement.
        /// </summary>
        [XurrentField("status")]
        public AgreementStatus? Status { get; internal set; }

        /// <summary>
        /// The support domain account that offers the support to users covered by this the service level agreement.
        /// </summary>
        [XurrentField("supportDomain")]
        public Account? SupportDomain { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether knowledge articles from the service provider should be exposed to the people covered by the service instances related to the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>service_instances</c>.
        /// </summary>
        [XurrentField("useKnowledgeFromServiceProvider")]
        public bool? UseKnowledgeFromServiceProvider { get; internal set; }

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
            if (data is ServiceLevelAgreement serviceLevelAgreement)
            {
                CoverageGroupsCollection?.Data?.AddRange(serviceLevelAgreement.CoverageGroups);
                CustomerRepresentativesCollection?.Data?.AddRange(serviceLevelAgreement.CustomerRepresentatives);
                EffortClassRateIDsCollection?.Data?.AddRange(serviceLevelAgreement.EffortClassRateIDs);
                InvoicesCollection?.Data?.AddRange(serviceLevelAgreement.Invoices);
                OrganizationsCollection?.Data?.AddRange(serviceLevelAgreement.Organizations);
                PeopleCollection?.Data?.AddRange(serviceLevelAgreement.People);
                RemarksAttachmentsCollection?.Data?.AddRange(serviceLevelAgreement.RemarksAttachments);
                ServiceInstancesCollection?.Data?.AddRange(serviceLevelAgreement.ServiceInstances);
                SitesCollection?.Data?.AddRange(serviceLevelAgreement.Sites);
                SkillPoolsCollection?.Data?.AddRange(serviceLevelAgreement.SkillPools);
                StandardServiceRequestActivityIDsCollection?.Data?.AddRange(serviceLevelAgreement.StandardServiceRequestActivityIDs);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (CoverageGroupsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CoverageGroupsCollection.GetPageInfo("coverageGroups", depth))
                    yield return pageInfo;

            if (CustomerRepresentativesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomerRepresentativesCollection.GetPageInfo("customerRepresentatives", depth))
                    yield return pageInfo;

            if (EffortClassRateIDsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in EffortClassRateIDsCollection.GetPageInfo("effortClassRateIDs", depth))
                    yield return pageInfo;

            if (InvoicesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InvoicesCollection.GetPageInfo("invoices", depth))
                    yield return pageInfo;

            if (OrganizationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in OrganizationsCollection.GetPageInfo("organizations", depth))
                    yield return pageInfo;

            if (PeopleCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PeopleCollection.GetPageInfo("people", depth))
                    yield return pageInfo;

            if (RemarksAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RemarksAttachmentsCollection.GetPageInfo("remarksAttachments", depth))
                    yield return pageInfo;

            if (ServiceInstancesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceInstancesCollection.GetPageInfo("serviceInstances", depth))
                    yield return pageInfo;

            if (SitesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SitesCollection.GetPageInfo("sites", depth))
                    yield return pageInfo;

            if (SkillPoolsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SkillPoolsCollection.GetPageInfo("skillPools", depth))
                    yield return pageInfo;

            if (StandardServiceRequestActivityIDsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in StandardServiceRequestActivityIDsCollection.GetPageInfo("standardServiceRequestActivityIDs", depth))
                    yield return pageInfo;
        }
    }
}
