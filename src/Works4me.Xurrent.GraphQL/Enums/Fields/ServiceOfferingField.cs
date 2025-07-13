using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ServiceOffering">ServiceOffering</see> fields.
    /// </summary>
    public enum ServiceOfferingField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The availability field.
        /// </summary>
        [XurrentEnum("availability")]
        Availability,

        /// <summary>
        /// The charge type case field.
        /// </summary>
        [XurrentEnum("chargeTypeCase")]
        ChargeTypeCase,

        /// <summary>
        /// The charge type high field.
        /// </summary>
        [XurrentEnum("chargeTypeHigh")]
        ChargeTypeHigh,

        /// <summary>
        /// The charge type low field.
        /// </summary>
        [XurrentEnum("chargeTypeLow")]
        ChargeTypeLow,

        /// <summary>
        /// The charge type medium field.
        /// </summary>
        [XurrentEnum("chargeTypeMedium")]
        ChargeTypeMedium,

        /// <summary>
        /// The charge type rfc field.
        /// </summary>
        [XurrentEnum("chargeTypeRfc")]
        ChargeTypeRfc,

        /// <summary>
        /// The charge type rfi field.
        /// </summary>
        [XurrentEnum("chargeTypeRfi")]
        ChargeTypeRfi,

        /// <summary>
        /// The charge type top field.
        /// </summary>
        [XurrentEnum("chargeTypeTop")]
        ChargeTypeTop,

        /// <summary>
        /// The charges field.
        /// </summary>
        [XurrentEnum("charges")]
        Charges,

        /// <summary>
        /// The continuity field.
        /// </summary>
        [XurrentEnum("continuity")]
        Continuity,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The default effort class field.
        /// </summary>
        [XurrentEnum("defaultEffortClass")]
        DefaultEffortClass,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The limitations field.
        /// </summary>
        [XurrentEnum("limitations")]
        Limitations,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The penalties field.
        /// </summary>
        [XurrentEnum("penalties")]
        Penalties,

        /// <summary>
        /// The performance field.
        /// </summary>
        [XurrentEnum("performance")]
        Performance,

        /// <summary>
        /// The prerequisites field.
        /// </summary>
        [XurrentEnum("prerequisites")]
        Prerequisites,

        /// <summary>
        /// The rate case field.
        /// </summary>
        [XurrentEnum("rateCase")]
        RateCase,

        /// <summary>
        /// The rate case currency field.
        /// </summary>
        [XurrentEnum("rateCaseCurrency")]
        RateCaseCurrency,

        /// <summary>
        /// The rate high field.
        /// </summary>
        [XurrentEnum("rateHigh")]
        RateHigh,

        /// <summary>
        /// The rate high currency field.
        /// </summary>
        [XurrentEnum("rateHighCurrency")]
        RateHighCurrency,

        /// <summary>
        /// The rate low field.
        /// </summary>
        [XurrentEnum("rateLow")]
        RateLow,

        /// <summary>
        /// The rate low currency field.
        /// </summary>
        [XurrentEnum("rateLowCurrency")]
        RateLowCurrency,

        /// <summary>
        /// The rate medium field.
        /// </summary>
        [XurrentEnum("rateMedium")]
        RateMedium,

        /// <summary>
        /// The rate medium currency field.
        /// </summary>
        [XurrentEnum("rateMediumCurrency")]
        RateMediumCurrency,

        /// <summary>
        /// The rate rfc field.
        /// </summary>
        [XurrentEnum("rateRfc")]
        RateRfc,

        /// <summary>
        /// The rate rfc currency field.
        /// </summary>
        [XurrentEnum("rateRfcCurrency")]
        RateRfcCurrency,

        /// <summary>
        /// The rate rfi field.
        /// </summary>
        [XurrentEnum("rateRfi")]
        RateRfi,

        /// <summary>
        /// The rate rfi currency field.
        /// </summary>
        [XurrentEnum("rateRfiCurrency")]
        RateRfiCurrency,

        /// <summary>
        /// The rate top field.
        /// </summary>
        [XurrentEnum("rateTop")]
        RateTop,

        /// <summary>
        /// The rate top currency field.
        /// </summary>
        [XurrentEnum("rateTopCurrency")]
        RateTopCurrency,

        /// <summary>
        /// The recovery point objective field.
        /// </summary>
        [XurrentEnum("recoveryPointObjective")]
        RecoveryPointObjective,

        /// <summary>
        /// The recovery time objective field.
        /// </summary>
        [XurrentEnum("recoveryTimeObjective")]
        RecoveryTimeObjective,

        /// <summary>
        /// The reliability field.
        /// </summary>
        [XurrentEnum("reliability")]
        Reliability,

        /// <summary>
        /// The report frequency field.
        /// </summary>
        [XurrentEnum("reportFrequency")]
        ReportFrequency,

        /// <summary>
        /// The resolution target case field.
        /// </summary>
        [XurrentEnum("resolutionTargetCase")]
        ResolutionTargetCase,

        /// <summary>
        /// The resolution target case in days field.
        /// </summary>
        [XurrentEnum("resolutionTargetCaseInDays")]
        ResolutionTargetCaseInDays,

        /// <summary>
        /// The resolution target high field.
        /// </summary>
        [XurrentEnum("resolutionTargetHigh")]
        ResolutionTargetHigh,

        /// <summary>
        /// The resolution target high in days field.
        /// </summary>
        [XurrentEnum("resolutionTargetHighInDays")]
        ResolutionTargetHighInDays,

        /// <summary>
        /// The resolution target low field.
        /// </summary>
        [XurrentEnum("resolutionTargetLow")]
        ResolutionTargetLow,

        /// <summary>
        /// The resolution target low in days field.
        /// </summary>
        [XurrentEnum("resolutionTargetLowInDays")]
        ResolutionTargetLowInDays,

        /// <summary>
        /// The resolution target medium field.
        /// </summary>
        [XurrentEnum("resolutionTargetMedium")]
        ResolutionTargetMedium,

        /// <summary>
        /// The resolution target medium in days field.
        /// </summary>
        [XurrentEnum("resolutionTargetMediumInDays")]
        ResolutionTargetMediumInDays,

        /// <summary>
        /// The resolution target notification scheme high field.
        /// </summary>
        [XurrentEnum("resolutionTargetNotificationSchemeHigh")]
        ResolutionTargetNotificationSchemeHigh,

        /// <summary>
        /// The resolution target notification scheme low field.
        /// </summary>
        [XurrentEnum("resolutionTargetNotificationSchemeLow")]
        ResolutionTargetNotificationSchemeLow,

        /// <summary>
        /// The resolution target notification scheme medium field.
        /// </summary>
        [XurrentEnum("resolutionTargetNotificationSchemeMedium")]
        ResolutionTargetNotificationSchemeMedium,

        /// <summary>
        /// The resolution target notification scheme top field.
        /// </summary>
        [XurrentEnum("resolutionTargetNotificationSchemeTop")]
        ResolutionTargetNotificationSchemeTop,

        /// <summary>
        /// The resolution target rfc field.
        /// </summary>
        [XurrentEnum("resolutionTargetRfc")]
        ResolutionTargetRfc,

        /// <summary>
        /// The resolution target rfc in days field.
        /// </summary>
        [XurrentEnum("resolutionTargetRfcInDays")]
        ResolutionTargetRfcInDays,

        /// <summary>
        /// The resolution target rfi field.
        /// </summary>
        [XurrentEnum("resolutionTargetRfi")]
        ResolutionTargetRfi,

        /// <summary>
        /// The resolution target rfi in days field.
        /// </summary>
        [XurrentEnum("resolutionTargetRfiInDays")]
        ResolutionTargetRfiInDays,

        /// <summary>
        /// The resolution target top field.
        /// </summary>
        [XurrentEnum("resolutionTargetTop")]
        ResolutionTargetTop,

        /// <summary>
        /// The resolution target top in days field.
        /// </summary>
        [XurrentEnum("resolutionTargetTopInDays")]
        ResolutionTargetTopInDays,

        /// <summary>
        /// The resolutions within target field.
        /// </summary>
        [XurrentEnum("resolutionsWithinTarget")]
        ResolutionsWithinTarget,

        /// <summary>
        /// The response target case field.
        /// </summary>
        [XurrentEnum("responseTargetCase")]
        ResponseTargetCase,

        /// <summary>
        /// The response target case in days field.
        /// </summary>
        [XurrentEnum("responseTargetCaseInDays")]
        ResponseTargetCaseInDays,

        /// <summary>
        /// The response target high field.
        /// </summary>
        [XurrentEnum("responseTargetHigh")]
        ResponseTargetHigh,

        /// <summary>
        /// The response target high in days field.
        /// </summary>
        [XurrentEnum("responseTargetHighInDays")]
        ResponseTargetHighInDays,

        /// <summary>
        /// The response target low field.
        /// </summary>
        [XurrentEnum("responseTargetLow")]
        ResponseTargetLow,

        /// <summary>
        /// The response target low in days field.
        /// </summary>
        [XurrentEnum("responseTargetLowInDays")]
        ResponseTargetLowInDays,

        /// <summary>
        /// The response target medium field.
        /// </summary>
        [XurrentEnum("responseTargetMedium")]
        ResponseTargetMedium,

        /// <summary>
        /// The response target medium in days field.
        /// </summary>
        [XurrentEnum("responseTargetMediumInDays")]
        ResponseTargetMediumInDays,

        /// <summary>
        /// The response target notification scheme high field.
        /// </summary>
        [XurrentEnum("responseTargetNotificationSchemeHigh")]
        ResponseTargetNotificationSchemeHigh,

        /// <summary>
        /// The response target notification scheme low field.
        /// </summary>
        [XurrentEnum("responseTargetNotificationSchemeLow")]
        ResponseTargetNotificationSchemeLow,

        /// <summary>
        /// The response target notification scheme medium field.
        /// </summary>
        [XurrentEnum("responseTargetNotificationSchemeMedium")]
        ResponseTargetNotificationSchemeMedium,

        /// <summary>
        /// The response target notification scheme top field.
        /// </summary>
        [XurrentEnum("responseTargetNotificationSchemeTop")]
        ResponseTargetNotificationSchemeTop,

        /// <summary>
        /// The response target rfc field.
        /// </summary>
        [XurrentEnum("responseTargetRfc")]
        ResponseTargetRfc,

        /// <summary>
        /// The response target rfc in days field.
        /// </summary>
        [XurrentEnum("responseTargetRfcInDays")]
        ResponseTargetRfcInDays,

        /// <summary>
        /// The response target rfi field.
        /// </summary>
        [XurrentEnum("responseTargetRfi")]
        ResponseTargetRfi,

        /// <summary>
        /// The response target rfi in days field.
        /// </summary>
        [XurrentEnum("responseTargetRfiInDays")]
        ResponseTargetRfiInDays,

        /// <summary>
        /// The response target top field.
        /// </summary>
        [XurrentEnum("responseTargetTop")]
        ResponseTargetTop,

        /// <summary>
        /// The response target top in days field.
        /// </summary>
        [XurrentEnum("responseTargetTopInDays")]
        ResponseTargetTopInDays,

        /// <summary>
        /// The responses within target field.
        /// </summary>
        [XurrentEnum("responsesWithinTarget")]
        ResponsesWithinTarget,

        /// <summary>
        /// The review frequency field.
        /// </summary>
        [XurrentEnum("reviewFrequency")]
        ReviewFrequency,

        /// <summary>
        /// The service field.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// The service hours field.
        /// </summary>
        [XurrentEnum("serviceHours")]
        ServiceHours,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The status field.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// The summary field.
        /// </summary>
        [XurrentEnum("summary")]
        Summary,

        /// <summary>
        /// The support hours case field.
        /// </summary>
        [XurrentEnum("supportHoursCase")]
        SupportHoursCase,

        /// <summary>
        /// The support hours high field.
        /// </summary>
        [XurrentEnum("supportHoursHigh")]
        SupportHoursHigh,

        /// <summary>
        /// The support hours low field.
        /// </summary>
        [XurrentEnum("supportHoursLow")]
        SupportHoursLow,

        /// <summary>
        /// The support hours medium field.
        /// </summary>
        [XurrentEnum("supportHoursMedium")]
        SupportHoursMedium,

        /// <summary>
        /// The support hours rfc field.
        /// </summary>
        [XurrentEnum("supportHoursRfc")]
        SupportHoursRfc,

        /// <summary>
        /// The support hours rfi field.
        /// </summary>
        [XurrentEnum("supportHoursRfi")]
        SupportHoursRfi,

        /// <summary>
        /// The support hours top field.
        /// </summary>
        [XurrentEnum("supportHoursTop")]
        SupportHoursTop,

        /// <summary>
        /// The termination field.
        /// </summary>
        [XurrentEnum("termination")]
        Termination,

        /// <summary>
        /// The time zone field.
        /// </summary>
        [XurrentEnum("timeZone")]
        TimeZone,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The waiting for customer follow up field.
        /// </summary>
        [XurrentEnum("waitingForCustomerFollowUp")]
        WaitingForCustomerFollowUp
    }
}
