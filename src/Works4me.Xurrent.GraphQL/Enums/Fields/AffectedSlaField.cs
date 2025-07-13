using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AffectedSla">AffectedSla</see> fields.
    /// </summary>
    public enum AffectedSlaField
    {
        /// <summary>
        /// The accountability field.
        /// </summary>
        [XurrentEnum("accountability")]
        Accountability,

        /// <summary>
        /// The actual resolution at field.
        /// </summary>
        [XurrentEnum("actualResolutionAt")]
        ActualResolutionAt,

        /// <summary>
        /// The actual resolution duration field.
        /// </summary>
        [XurrentEnum("actualResolutionDuration")]
        ActualResolutionDuration,

        /// <summary>
        /// The actual response at field.
        /// </summary>
        [XurrentEnum("actualResponseAt")]
        ActualResponseAt,

        /// <summary>
        /// The actual response duration field.
        /// </summary>
        [XurrentEnum("actualResponseDuration")]
        ActualResponseDuration,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The desired completion at field.
        /// </summary>
        [XurrentEnum("desiredCompletionAt")]
        DesiredCompletionAt,

        /// <summary>
        /// The downtime duration field.
        /// </summary>
        [XurrentEnum("downtimeDuration")]
        DowntimeDuration,

        /// <summary>
        /// The downtime end at field.
        /// </summary>
        [XurrentEnum("downtimeEndAt")]
        DowntimeEndAt,

        /// <summary>
        /// The downtime start at field.
        /// </summary>
        [XurrentEnum("downtimeStartAt")]
        DowntimeStartAt,

        /// <summary>
        /// The first line team field.
        /// </summary>
        [XurrentEnum("firstLineTeam")]
        FirstLineTeam,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The impact field.
        /// </summary>
        [XurrentEnum("impact")]
        Impact,

        /// <summary>
        /// The maximum resolution duration field.
        /// </summary>
        [XurrentEnum("maximumResolutionDuration")]
        MaximumResolutionDuration,

        /// <summary>
        /// The maximum resolution duration in days field.
        /// </summary>
        [XurrentEnum("maximumResolutionDurationInDays")]
        MaximumResolutionDurationInDays,

        /// <summary>
        /// The maximum response duration field.
        /// </summary>
        [XurrentEnum("maximumResponseDuration")]
        MaximumResponseDuration,

        /// <summary>
        /// The maximum response duration in days field.
        /// </summary>
        [XurrentEnum("maximumResponseDurationInDays")]
        MaximumResponseDurationInDays,

        /// <summary>
        /// The next target at field.
        /// </summary>
        [XurrentEnum("nextTargetAt")]
        NextTargetAt,

        /// <summary>
        /// The provider not accountable field.
        /// </summary>
        [XurrentEnum("providerNotAccountable")]
        ProviderNotAccountable,

        /// <summary>
        /// The provider was not accountable field.
        /// </summary>
        [XurrentEnum("providerWasNotAccountable")]
        ProviderWasNotAccountable,

        /// <summary>
        /// The request field.
        /// </summary>
        [XurrentEnum("request")]
        Request,

        /// <summary>
        /// The resolution target at field.
        /// </summary>
        [XurrentEnum("resolutionTargetAt")]
        ResolutionTargetAt,

        /// <summary>
        /// The response target at field.
        /// </summary>
        [XurrentEnum("responseTargetAt")]
        ResponseTargetAt,

        /// <summary>
        /// The service hours field.
        /// </summary>
        [XurrentEnum("serviceHours")]
        ServiceHours,

        /// <summary>
        /// The service instance field.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// The service level agreement field.
        /// </summary>
        [XurrentEnum("serviceLevelAgreement")]
        ServiceLevelAgreement,

        /// <summary>
        /// The standard service request field.
        /// </summary>
        [XurrentEnum("standardServiceRequest")]
        StandardServiceRequest,

        /// <summary>
        /// The started at field.
        /// </summary>
        [XurrentEnum("startedAt")]
        StartedAt,

        /// <summary>
        /// The stopped clock at field.
        /// </summary>
        [XurrentEnum("stoppedClockAt")]
        StoppedClockAt,

        /// <summary>
        /// The stopped clock duration field.
        /// </summary>
        [XurrentEnum("stoppedClockDuration")]
        StoppedClockDuration,

        /// <summary>
        /// The stopped clock periods field.
        /// </summary>
        [XurrentEnum("stoppedClockPeriods")]
        StoppedClockPeriods,

        /// <summary>
        /// The supplier field.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// The support hours field.
        /// </summary>
        [XurrentEnum("supportHours")]
        SupportHours,

        /// <summary>
        /// The support team field.
        /// </summary>
        [XurrentEnum("supportTeam")]
        SupportTeam,

        /// <summary>
        /// The time zone field.
        /// </summary>
        [XurrentEnum("timeZone")]
        TimeZone,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
