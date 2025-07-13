using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/organization/">Organization</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Organization")]
    public sealed class Organization : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        [XurrentField("addresses")]
        internal PagedResponse<Address>? AddressesCollection { get; set; }
        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public ReadOnlyDataCollection<Address>? Addresses { get => AddressesCollection?.Data is null ? null : new ReadOnlyDataCollection<Address>(AddressesCollection.Data); }

        /// <summary>
        /// Whether the organization needs to be treated as a separate entity from a reporting perspective. This checkbox is only available for internal organizations.
        /// </summary>
        [XurrentField("businessUnit")]
        public bool? BusinessUnit { get; internal set; }

        /// <summary>
        /// Refers to itself if the organization is a business unit, or refers to the business unit that the organization belongs to.
        /// </summary>
        [XurrentField("businessUnitOrganization")]
        public Organization? BusinessUnitOrganization { get; internal set; }

        [XurrentField("childOrganizations")]
        internal PagedResponse<Organization>? ChildOrganizationsCollection { get; set; }
        /// <summary>
        /// Child organizations of this organization, i.e. organizations that have this organization as their parent.
        /// </summary>
        public ReadOnlyDataCollection<Organization>? ChildOrganizations { get => ChildOrganizationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Organization>(ChildOrganizationsCollection.Data); }

        [XurrentField("contacts")]
        internal PagedResponse<Contact>? ContactsCollection { get; set; }
        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        public ReadOnlyDataCollection<Contact>? Contacts { get => ContactsCollection?.Data is null ? null : new ReadOnlyDataCollection<Contact>(ContactsCollection.Data); }

        [XurrentField("contracts")]
        internal PagedResponse<Contract>? ContractsCollection { get; set; }
        /// <summary>
        /// Contracts of this organization.
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
        /// Whether the organization may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Whether end users from this organization should be prevented from seeing information of other end users.
        /// </summary>
        [XurrentField("endUserPrivacy")]
        public bool? EndUserPrivacy { get; internal set; }

        /// <summary>
        /// The unique identifier by which the organization is known in the financial system.
        /// </summary>
        [XurrentField("financialID")]
        public string? FinancialID { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The manager of the organization.
        /// </summary>
        [XurrentField("manager")]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// The full name of the organization.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Refers to the order template that is used for purchases of people defined in this organization or its descendants.
        /// </summary>
        [XurrentField("orderTemplate")]
        public RequestTemplate? OrderTemplate { get; internal set; }

        /// <summary>
        /// The organization's parent organization.
        /// </summary>
        [XurrentField("parent")]
        public Organization? Parent { get; internal set; }

        [XurrentField("people")]
        internal PagedResponse<Person>? PeopleCollection { get; set; }
        /// <summary>
        /// People of this organization.
        /// </summary>
        public ReadOnlyDataCollection<Person>? People { get => PeopleCollection?.Data is null ? null : new ReadOnlyDataCollection<Person>(PeopleCollection.Data); }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// Which region the organization belongs to.<br />
        /// Examples of commonly used region names are:<br />
        /// • Asia Pacific (APAC).<br />
        /// • Europe, Middle East &amp; Africa (EMEA).<br />
        /// • North America (NA).<br />
        /// </summary>
        [XurrentField("region")]
        public string? Region { get; internal set; }

        /// <summary>
        /// Any additional information about the organization that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks { get; internal set; }

        [XurrentField("remarksAttachments")]
        internal PagedResponse<Attachment>? RemarksAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? RemarksAttachments { get => RemarksAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(RemarksAttachmentsCollection.Data); }

        [XurrentField("risks")]
        internal PagedResponse<Risk>? RisksCollection { get; set; }
        /// <summary>
        /// Risks of this organization.
        /// </summary>
        public ReadOnlyDataCollection<Risk>? Risks { get => RisksCollection?.Data is null ? null : new ReadOnlyDataCollection<Risk>(RisksCollection.Data); }

        [XurrentField("serviceLevelAgreements")]
        internal PagedResponse<ServiceLevelAgreement>? ServiceLevelAgreementsCollection { get; set; }
        /// <summary>
        /// Service level agreements which coverage field is set to <c>organizations</c> and which cover the organization.
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
        /// The person who acts as the substitute of the organization's manager.
        /// </summary>
        [XurrentField("substitute")]
        public Person? Substitute { get; internal set; }

        [XurrentField("timeAllocations")]
        internal PagedResponse<TimeAllocation>? TimeAllocationsCollection { get; set; }
        /// <summary>
        /// Time allocations of this organization.
        /// </summary>
        public ReadOnlyDataCollection<TimeAllocation>? TimeAllocations { get => TimeAllocationsCollection?.Data is null ? null : new ReadOnlyDataCollection<TimeAllocation>(TimeAllocationsCollection.Data); }

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
            if (data is Organization organization)
            {
                AddressesCollection?.Data?.AddRange(organization.Addresses);
                ChildOrganizationsCollection?.Data?.AddRange(organization.ChildOrganizations);
                ContactsCollection?.Data?.AddRange(organization.Contacts);
                ContractsCollection?.Data?.AddRange(organization.Contracts);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(organization.CustomFieldsAttachments);
                PeopleCollection?.Data?.AddRange(organization.People);
                RemarksAttachmentsCollection?.Data?.AddRange(organization.RemarksAttachments);
                RisksCollection?.Data?.AddRange(organization.Risks);
                ServiceLevelAgreementsCollection?.Data?.AddRange(organization.ServiceLevelAgreements);
                TimeAllocationsCollection?.Data?.AddRange(organization.TimeAllocations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AddressesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AddressesCollection.GetPageInfo("addresses", depth))
                    yield return pageInfo;

            if (ChildOrganizationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ChildOrganizationsCollection.GetPageInfo("childOrganizations", depth))
                    yield return pageInfo;

            if (ContactsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ContactsCollection.GetPageInfo("contacts", depth))
                    yield return pageInfo;

            if (ContractsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ContractsCollection.GetPageInfo("contracts", depth))
                    yield return pageInfo;

            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;

            if (PeopleCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PeopleCollection.GetPageInfo("people", depth))
                    yield return pageInfo;

            if (RemarksAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RemarksAttachmentsCollection.GetPageInfo("remarksAttachments", depth))
                    yield return pageInfo;

            if (RisksCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RisksCollection.GetPageInfo("risks", depth))
                    yield return pageInfo;

            if (ServiceLevelAgreementsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceLevelAgreementsCollection.GetPageInfo("serviceLevelAgreements", depth))
                    yield return pageInfo;

            if (TimeAllocationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TimeAllocationsCollection.GetPageInfo("timeAllocations", depth))
                    yield return pageInfo;
        }
    }
}
