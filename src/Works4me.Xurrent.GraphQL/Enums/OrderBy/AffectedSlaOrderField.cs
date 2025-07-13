using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields AffectedSla can be ordered on.
    /// </summary>
    public enum AffectedSlaOrderField
    {
        /// <summary>
        /// Order by <c>Accountability</c>.
        /// </summary>
        [XurrentEnum("accountability")]
        Accountability,

        /// <summary>
        /// Order by <c>ActualResolutionAt</c>.
        /// </summary>
        [XurrentEnum("actualResolutionAt")]
        ActualResolutionAt,

        /// <summary>
        /// Order by <c>ActualResolutionDuration</c>.
        /// </summary>
        [XurrentEnum("actualResolutionDuration")]
        ActualResolutionDuration,

        /// <summary>
        /// Order by <c>ActualResponseAt</c>.
        /// </summary>
        [XurrentEnum("actualResponseAt")]
        ActualResponseAt,

        /// <summary>
        /// Order by <c>ActualResponseDuration</c>.
        /// </summary>
        [XurrentEnum("actualResponseDuration")]
        ActualResponseDuration,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Impact</c>.
        /// </summary>
        [XurrentEnum("impact")]
        Impact,

        /// <summary>
        /// Order by <c>RequestId</c>.
        /// </summary>
        [XurrentEnum("requestId")]
        RequestId,

        /// <summary>
        /// Order by <c>RequestSubject</c>.
        /// </summary>
        [XurrentEnum("requestSubject")]
        RequestSubject,

        /// <summary>
        /// Order by <c>ResolutionTargetAt</c>.
        /// </summary>
        [XurrentEnum("resolutionTargetAt")]
        ResolutionTargetAt,

        /// <summary>
        /// Order by <c>ResponseTargetAt</c>.
        /// </summary>
        [XurrentEnum("responseTargetAt")]
        ResponseTargetAt,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
