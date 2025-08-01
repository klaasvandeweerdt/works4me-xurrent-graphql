﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/affectedsla/">AffectedSla</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("AffectedSla")]
    public sealed class AffectedSla : IDataItem, INode
    {
        /// <summary>
        /// The Accountability field is set to <c>provider</c> when the service instance of the affected SLA is the same as the service instance of the request to which the affected SLA is linked. It is set to <c>supplier</c> when the service instance of the request is situated lower in the service hierarchy than the service instance of the affected SLA. It is set to <c>sla_not_affected</c> when the provider of the service instance that is linked to the affected SLA no longer has a responsibility for completing the request.
        /// </summary>
        [XurrentField("accountability")]
        public AffectedSlaAccountability? Accountability { get; internal set; }

        /// <summary>
        /// The current date and time is filled out in the Actual resolution field when the status of the request has been set to "Completed".
        /// </summary>
        [XurrentField("actualResolutionAt")]
        public DateTime? ActualResolutionAt { get; internal set; }

        /// <summary>
        /// The Actual resolution duration field value is automatically calculated using the date and time in the Started field, the date and time in the Actual resolution field, and the calendar selected in the Support hours field of the affected SLA.
        /// </summary>
        [XurrentField("actualResolutionDuration")]
        public long? ActualResolutionDuration { get; internal set; }

        /// <summary>
        /// The Actual response field is empty when the service instance (SI) that is selected in the request is the same as the related SI, and the request has not yet been saved with one of the following status values since this SI was linked to it:
        /// </summary>
        [XurrentField("actualResponseAt")]
        public DateTime? ActualResponseAt { get; internal set; }

        /// <summary>
        /// The Actual response duration field value is automatically calculated using the date and time in the Started field, the date and time in the Actual response field, and the calendar selected in the Support hours field of the affected SLA.
        /// </summary>
        [XurrentField("actualResponseDuration")]
        public long? ActualResponseDuration { get; internal set; }

        /// <summary>
        /// The date and time at which the affected SLA was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The Desired completion field is the desired completion of the request that the affected SLA is linked to.
        /// </summary>
        [XurrentField("desiredCompletionAt")]
        public DateTime? DesiredCompletionAt { get; internal set; }

        /// <summary>
        /// The Downtime duration field value is automatically calculated using the date and time in the Downtime start field, the date and time in the Downtime end field, and the calendar selected in the Service hours field of the affected SLA.
        /// </summary>
        [XurrentField("downtimeDuration")]
        public long? DowntimeDuration { get; internal set; }

        /// <summary>
        /// The Downtime end field is automatically set to the value in the Downtime end field of the request to which the affected SLA is linked.
        /// </summary>
        [XurrentField("downtimeEndAt")]
        public DateTime? DowntimeEndAt { get; internal set; }

        /// <summary>
        /// The Downtime start field is automatically set to the value in the Downtime start field of the request to which the affected SLA is linked.
        /// </summary>
        [XurrentField("downtimeStartAt")]
        public DateTime? DowntimeStartAt { get; internal set; }

        /// <summary>
        /// The First line team field is automatically set to the team that, at the time the affected SLA was created, was selected in the First line team field of the related service instance.
        /// </summary>
        [XurrentField("firstLineTeam")]
        public Team? FirstLineTeam { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The Impact field is automatically set to the impact selected in the request, provided that the service instance (SI) that is selected in the request is the same as the related SI.
        /// </summary>
        [XurrentField("impact")]
        public RequestImpact? Impact { get; internal set; }

        /// <summary>
        /// The Maximum resolution duration field is automatically set to the value that was specified, at the time the impact level was assigned to the affected SLA, in the Resolution target field for this impact level in the service offering of the related service level agreement.
        /// </summary>
        [XurrentField("maximumResolutionDuration")]
        public long? MaximumResolutionDuration { get; internal set; }

        /// <summary>
        /// The Maximum resolution duration in days field is automatically set to the value that was specified, at the time the impact level was assigned to the affected SLA, in the Resolution target in days field for this impact level in the service offering of the related service level agreement.
        /// </summary>
        [XurrentField("maximumResolutionDurationInDays")]
        public long? MaximumResolutionDurationInDays { get; internal set; }

        /// <summary>
        /// The Maximum response duration field is automatically set to the value that was specified, at the time the impact level was assigned to the affected SLA, in the Response target field for this impact level in the service offering of the related service level agreement.
        /// </summary>
        [XurrentField("maximumResponseDuration")]
        public long? MaximumResponseDuration { get; internal set; }

        /// <summary>
        /// The Maximum response duration in days field is automatically set to the value that was specified, at the time the impact level was assigned to the affected SLA, in the Response target in days field for this impact level in the service offering of the related service level agreement.
        /// </summary>
        [XurrentField("maximumResponseDurationInDays")]
        public long? MaximumResponseDurationInDays { get; internal set; }

        /// <summary>
        /// The Next target field value is empty when the Accountability field is set to <c>sla_not_affected</c> or when the Actual resolution field contains a value. It is set to <c>clock_stopped</c> when the clock has been stopped for the affected SLA. The next target equals the response target when a response target exists and the Actual response field is still empty. Otherwise, the next target equals the desired completion when a desired completion exists and a resolution target exists and the desired completion is greater than the resolution target. Otherwise the next target is the resolution target when a resolution target exists. In all other cases, the next target is <c>best_effort</c>.
        /// </summary>
        [XurrentField("nextTargetAt")]
        public DateTime? NextTargetAt { get; internal set; }

        /// <summary>
        /// Whether the provider currently indicates not to be accountable.
        /// </summary>
        [XurrentField("providerNotAccountable")]
        public bool? ProviderNotAccountable { get; internal set; }

        /// <summary>
        /// Whether the provider has at any point in time indicated not to be accountable.
        /// </summary>
        [XurrentField("providerWasNotAccountable")]
        public bool? ProviderWasNotAccountable { get; internal set; }

        /// <summary>
        /// The Request field is automatically set to the request for which the affected SLA was generated.
        /// </summary>
        [XurrentField("request")]
        public Request? Request { get; internal set; }

        /// <summary>
        /// The Resolution target field value is automatically calculated using the date and time in the Started field, the value in Maximum resolution duration field, and the calendar selected in the Support hours field of the affected SLA.
        /// </summary>
        [XurrentField("resolutionTargetAt")]
        public DateTime? ResolutionTargetAt { get; internal set; }

        /// <summary>
        /// The Response target field value is automatically calculated using the date and time in the Started field, the value in the Maximum response duration field, and the calendar selected in the Support hours field of the affected SLA.
        /// </summary>
        [XurrentField("responseTargetAt")]
        public DateTime? ResponseTargetAt { get; internal set; }

        /// <summary>
        /// If the impact of the affected SLA is "Top - Service Down for Several Users", the Service hours field is automatically set to the service hours calendar of the service offering of the related service level agreement.
        /// </summary>
        [XurrentField("serviceHours")]
        public Calendar? ServiceHours { get; internal set; }

        /// <summary>
        /// The Service instance field is automatically set to the Service Instance that, at the time the affected SLA was created, was selected in the Service instance field of the related service level agreement.
        /// </summary>
        [XurrentField("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

        /// <summary>
        /// The Service level agreement field is automatically set to the service level agreement that is considered affected.
        /// </summary>
        [XurrentField("serviceLevelAgreement")]
        public ServiceLevelAgreement? ServiceLevelAgreement { get; internal set; }

        /// <summary>
        /// The Standard service request field is automatically set to the standard service request that is linked to the service offering of the service level agreement and which response and resolution targets were used to calculate the <c>responseTargetAt</c> and <c>resolutionTargetAt</c> for the affected SLA.
        /// </summary>
        [XurrentField("standardServiceRequest")]
        public StandardServiceRequest? StandardServiceRequest { get; internal set; }

        /// <summary>
        /// The date and time at which the clock was started for the calculation of the affected SLA's response and resolution targets and durations.
        /// </summary>
        [XurrentField("startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the clock was stopped for the calculation of the affected SLA's response and resolution durations.
        /// </summary>
        [XurrentField("stoppedClockAt")]
        public DateTime? StoppedClockAt { get; internal set; }

        /// <summary>
        /// The Stopped clock duration field value is automatically calculated using the date and time at which the clock was stopped, the date and time at which the clock was started again, the calendar selected in the Support hours field of the affected SLA, and the previous value to which this field was set.
        /// </summary>
        [XurrentField("stoppedClockDuration")]
        public long? StoppedClockDuration { get; internal set; }

        /// <summary>
        /// A list of time periods between which the clock was stopped for this affected SLA.
        /// </summary>
        [XurrentField("stoppedClockPeriods")]
        public IReadOnlyList<Period>? StoppedClockPeriods { get; internal set; }

        /// <summary>
        /// The Supplier field is automatically set to the Organization that, at the time the affected SLA was created, was selected in the Service provider field of the related service instance. This field is only filled out, however, if this service provider is an external organization.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The Support hours field is automatically set to the support hours Calendar that was selected for the impact level specified above in the service offering of the related service level agreement.
        /// </summary>
        [XurrentField("supportHours")]
        public Calendar? SupportHours { get; internal set; }

        /// <summary>
        /// The Support team field is automatically set to the team that, at the time the affected SLA was created, was selected in the Support team field of the related service instance.
        /// </summary>
        [XurrentField("supportTeam")]
        public Team? SupportTeam { get; internal set; }

        /// <summary>
        /// The Time zone field is automatically set to the value that was specified, at the time the affected SLA was created, in the service offering of the related service level agreement.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the affected SLA. If the affected SLA has no updates it contains the <c>createdAt</c> value.
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
