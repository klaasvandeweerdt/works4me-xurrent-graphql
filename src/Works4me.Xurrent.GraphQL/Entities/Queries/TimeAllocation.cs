using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timeallocation/">TimeAllocation</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("TimeAllocation")]
    public sealed class TimeAllocation : IDataItem, IHasTranslations, INode, IRecord
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
        /// Whether a person who spent on the time allocation needs to select a customer organization, and if this is the case, whether this person may only select from the customer organizations linked to the time allocation or is allowed to select any customer organization.
        /// </summary>
        [XurrentField("customerCategory")]
        public TimeAllocationCustomerCategory? CustomerCategory { get; internal set; }

        [XurrentField("customers")]
        internal PagedResponse<Organization>? CustomersCollection { get; set; }
        /// <summary>
        /// Customer organizations of the time allocation.
        /// </summary>
        public ReadOnlyDataCollection<Organization>? Customers { get => CustomersCollection?.Data is null ? null : new ReadOnlyDataCollection<Organization>(CustomersCollection.Data); }

        /// <summary>
        /// Whether the Description field should be available, and if so, whether it should be required, in the time entries to which the time allocation is related.
        /// </summary>
        [XurrentField("descriptionCategory")]
        public TimeAllocationDescriptionCategory? DescriptionCategory { get; internal set; }

        /// <summary>
        /// Whether the time allocation may no longer be related to any more organizations.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on this time allocation.
        /// </summary>
        [XurrentField("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// Which group to include the time allocation in.
        /// </summary>
        [XurrentField("group")]
        public string? Group { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The name of the time allocation.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        [XurrentField("organizations")]
        internal PagedResponse<Organization>? OrganizationsCollection { get; set; }
        /// <summary>
        /// Organizations of the time allocation.
        /// </summary>
        public ReadOnlyDataCollection<Organization>? Organizations { get => OrganizationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Organization>(OrganizationsCollection.Data); }

        /// <summary>
        /// Whether a Person who spent on the time allocation needs to select a service, and if this is the case, whether this person may only select from the services linked to the time allocation or is allowed to select any service.
        /// </summary>
        [XurrentField("serviceCategory")]
        public TimeAllocationServiceCategory? ServiceCategory { get; internal set; }

        [XurrentField("services")]
        internal PagedResponse<Service>? ServicesCollection { get; set; }
        /// <summary>
        /// Services of the time allocation.
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
            if (data is TimeAllocation timeAllocation)
            {
                CustomersCollection?.Data?.AddRange(timeAllocation.Customers);
                OrganizationsCollection?.Data?.AddRange(timeAllocation.Organizations);
                ServicesCollection?.Data?.AddRange(timeAllocation.Services);
                TranslationsCollection?.Data?.AddRange(timeAllocation.Translations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (CustomersCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomersCollection.GetPageInfo("customers", depth))
                    yield return pageInfo;

            if (OrganizationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in OrganizationsCollection.GetPageInfo("organizations", depth))
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
