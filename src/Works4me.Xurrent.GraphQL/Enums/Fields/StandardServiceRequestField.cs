using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="StandardServiceRequest">StandardServiceRequest</see> fields.
    /// </summary>
    public enum StandardServiceRequestField
    {
        /// <summary>
        /// The charge type field.
        /// </summary>
        [XurrentEnum("chargeType")]
        ChargeType,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The rate field.
        /// </summary>
        [XurrentEnum("rate")]
        Rate,

        /// <summary>
        /// The rate currency field.
        /// </summary>
        [XurrentEnum("rateCurrency")]
        RateCurrency,

        /// <summary>
        /// The request template field.
        /// </summary>
        [XurrentEnum("requestTemplate")]
        RequestTemplate,

        /// <summary>
        /// The resolution target field.
        /// </summary>
        [XurrentEnum("resolutionTarget")]
        ResolutionTarget,

        /// <summary>
        /// The resolution target best effort field.
        /// </summary>
        [XurrentEnum("resolutionTargetBestEffort")]
        ResolutionTargetBestEffort,

        /// <summary>
        /// The resolution target in days field.
        /// </summary>
        [XurrentEnum("resolutionTargetInDays")]
        ResolutionTargetInDays,

        /// <summary>
        /// The resolution target notification scheme field.
        /// </summary>
        [XurrentEnum("resolutionTargetNotificationScheme")]
        ResolutionTargetNotificationScheme,

        /// <summary>
        /// The response target field.
        /// </summary>
        [XurrentEnum("responseTarget")]
        ResponseTarget,

        /// <summary>
        /// The response target best effort field.
        /// </summary>
        [XurrentEnum("responseTargetBestEffort")]
        ResponseTargetBestEffort,

        /// <summary>
        /// The response target in days field.
        /// </summary>
        [XurrentEnum("responseTargetInDays")]
        ResponseTargetInDays,

        /// <summary>
        /// The response target notification scheme field.
        /// </summary>
        [XurrentEnum("responseTargetNotificationScheme")]
        ResponseTargetNotificationScheme,

        /// <summary>
        /// The service offering field.
        /// </summary>
        [XurrentEnum("serviceOffering")]
        ServiceOffering,

        /// <summary>
        /// The support hours field.
        /// </summary>
        [XurrentEnum("supportHours")]
        SupportHours,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
