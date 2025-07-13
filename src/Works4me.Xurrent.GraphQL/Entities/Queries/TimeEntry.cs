using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timeentry/">TimeEntry</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("TimeEntry")]
    public sealed class TimeEntry : IDataItem, IHasLifeCycleState, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider. Some examples of activities are standard requests, a high impact incident or a request for information. The Activity ID can be used to support integrations between the billing system of the service provider and the Xurrent account in which the activities are performed.
        /// </summary>
        [XurrentField("activityID")]
        public string? ActivityID { get; internal set; }

        /// <summary>
        /// The Agreement ID is the unique identifier by which all the activities that are performed through the coverage of the SLA are known in the billing system of the service provider. The agreement ID can be used to support integrations between the billing system of the service provider and the Xurrent account in which the activities are performed.
        /// </summary>
        [XurrentField("agreementID")]
        public string? AgreementID { get; internal set; }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// </summary>
        [XurrentField("assignment")]
        public IHasTimeEntries? Assignment { get; internal set; }

        /// <summary>
        /// For a Time and Materials activity the charge is calculated by multiplying the time spent by the charge rate of the person’s who spent the time based on the selected effort class. For a Fixed Price activity the charge is the amount defined for the fixed price activity in the service offering (of the billable SLA related to the request).
        /// </summary>
        [XurrentField("charge")]
        public decimal? Charge { get; internal set; }

        /// <summary>
        /// The currency of the charge field value of the time entry.
        /// </summary>
        [XurrentField("chargeCurrency")]
        public Currency? ChargeCurrency { get; internal set; }

        /// <summary>
        /// Shows the charging rate per hour and is defined by the effort class that was selected when the person registered the time entry.
        /// </summary>
        [XurrentField("chargeRate")]
        public decimal? ChargeRate { get; internal set; }

        /// <summary>
        /// The charge type field defines how the activity must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeType")]
        public ServiceOfferingChargeType? ChargeType { get; internal set; }

        /// <summary>
        /// Whether the time entry should be considered a correction for a time entry that was registered for a date that has already been locked.
        /// </summary>
        [XurrentField("correction")]
        public bool? Correction { get; internal set; }

        /// <summary>
        /// The cost of the time entry. It is calculated by multiplying the time spent by the cost per hour of the person who spent the time.
        /// </summary>
        [XurrentField("cost")]
        public decimal? Cost { get; internal set; }

        /// <summary>
        /// The currency of the cost value of the time entry.
        /// </summary>
        [XurrentField("costCurrency")]
        public Currency? CostCurrency { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The organization for which the time was spent.
        /// </summary>
        [XurrentField("customer")]
        public Organization? Customer { get; internal set; }

        /// <summary>
        /// The date on which the time was spent.
        /// </summary>
        [XurrentField("date")]
#if NET6_0_OR_GREATER
        public DateOnly? Date { get; internal set; }
#else
        public DateTime? Date { get; internal set; }
#endif

        /// <summary>
        /// Automatically checked after the time entry has been deleted. The data of a deleted time entry that is older than 3 months can no longer be retrieved.
        /// </summary>
        [XurrentField("deleted")]
        public bool? Deleted { get; internal set; }

        /// <summary>
        /// A short description of the time spent. This field is available and required only when the Description required box is checked in the selected time allocation.
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        /// <summary>
        /// The effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        [XurrentField("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [XurrentField("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The note the time entry is linked to.
        /// </summary>
        [XurrentField("note")]
        public Note? Note { get; internal set; }

        /// <summary>
        /// The organization to which the person was linked when the time entry was created.
        /// </summary>
        [XurrentField("organization")]
        public Organization? Organization { get; internal set; }

        /// <summary>
        /// The person who spent the time.
        /// </summary>
        [XurrentField("person")]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The Rate ID is the unique identifier by which an effort class that is linked to a time entry when an activity was performed through the coverage of the SLA is known in the billing system of the service provider. The effort class represents the type of effort that was performed when working on an activity. Some examples of effort classes are 'Billable - Normal Hours', 'Billable overtime', 'Non Billable' or 'Senior System Engineer'. The Rate ID can be used to support integrations between the billing system of the service provider and the Xurrent account in which the activities are performed. In the billing system the Rate IDs will be linked to the rates that have been agreed on in the service contract.
        /// </summary>
        [XurrentField("rateID")]
        public string? RateID { get; internal set; }

        /// <summary>
        /// The service for which the time was spent.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

        /// <summary>
        /// The service instance for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        [XurrentField("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

        /// <summary>
        /// The service level agreement for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        [XurrentField("serviceLevelAgreement")]
        public ServiceLevelAgreement? ServiceLevelAgreement { get; internal set; }

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
        /// The start time of the work.
        /// </summary>
        [XurrentField("startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// Team the person of the time entry was a member of while the work was performed.
        /// </summary>
        [XurrentField("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The time allocation on which the time was spent. Only the time allocations that are linked to the person’s organization can be selected.
        /// </summary>
        [XurrentField("timeAllocation")]
        public TimeAllocation? TimeAllocation { get; internal set; }

        /// <summary>
        /// The number of minutes that was spent on the selected time allocation. The number of minutes is allowed to be negative only when the correction field is set to <c>true</c>.
        /// </summary>
        [XurrentField("timeSpent")]
        public long? TimeSpent { get; internal set; }

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
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
