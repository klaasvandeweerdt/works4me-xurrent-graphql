using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/serviceoffering/">ServiceOffering</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ServiceOffering")]
    public sealed class ServiceOffering : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The duration, expressed as percentage of the total number of service hours, during which the service is to be available to customers with an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("availability")]
        public decimal? Availability { get; internal set; }

        /// <summary>
        /// Defines how a Case must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeCase")]
        public ServiceOfferingChargeType? ChargeTypeCase { get; internal set; }

        /// <summary>
        /// Defines how a high incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeHigh")]
        public ServiceOfferingChargeType? ChargeTypeHigh { get; internal set; }

        /// <summary>
        /// Defines how a low incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeLow")]
        public ServiceOfferingChargeType? ChargeTypeLow { get; internal set; }

        /// <summary>
        /// Defines how a medium incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeMedium")]
        public ServiceOfferingChargeType? ChargeTypeMedium { get; internal set; }

        /// <summary>
        /// Defines how a RFC must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeRfc")]
        public ServiceOfferingChargeType? ChargeTypeRfc { get; internal set; }

        /// <summary>
        /// Defines how a RFI must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeRfi")]
        public ServiceOfferingChargeType? ChargeTypeRfi { get; internal set; }

        /// <summary>
        /// Defines how a top incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeTop")]
        public ServiceOfferingChargeType? ChargeTypeTop { get; internal set; }

        /// <summary>
        /// The amount that the service provider will charge the customer for the delivery of the service per charge driver, per charge term.
        /// </summary>
        [XurrentField("charges")]
        public string? Charges { get; internal set; }

        [XurrentField("chargesAttachments")]
        internal PagedResponse<Attachment>? ChargesAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Charges field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? ChargesAttachments { get => ChargesAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(ChargesAttachmentsCollection.Data); }

        /// <summary>
        /// The continuity measures for the service offering.
        /// </summary>
        [XurrentField("continuity")]
        public string? Continuity { get; internal set; }

        [XurrentField("continuityAttachments")]
        internal PagedResponse<Attachment>? ContinuityAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Continuity field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? ContinuityAttachments { get => ContinuityAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(ContinuityAttachmentsCollection.Data); }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a request with an active affected SLA based on the service offering.
        /// </summary>
        [XurrentField("defaultEffortClass")]
        public EffortClass? DefaultEffortClass { get; internal set; }

        [XurrentField("effortClassRates")]
        internal PagedResponse<EffortClassRate>? EffortClassRatesCollection { get; set; }
        /// <summary>
        /// Effort class rates of the service offering.
        /// </summary>
        public ReadOnlyDataCollection<EffortClassRate>? EffortClassRates { get => EffortClassRatesCollection?.Data is null ? null : new ReadOnlyDataCollection<EffortClassRate>(EffortClassRatesCollection.Data); }

        [XurrentField("effortClasses")]
        internal PagedResponse<EffortClass>? EffortClassesCollection { get; set; }
        /// <summary>
        /// Effort classes of the service offering.
        /// </summary>
        public ReadOnlyDataCollection<EffortClass>? EffortClasses { get => EffortClassesCollection?.Data is null ? null : new ReadOnlyDataCollection<EffortClass>(EffortClassesCollection.Data); }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The limitations that apply to the service level agreements that are based on the service offering.
        /// </summary>
        [XurrentField("limitations")]
        public string? Limitations { get; internal set; }

        [XurrentField("limitationsAttachments")]
        internal PagedResponse<Attachment>? LimitationsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Limitations field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? LimitationsAttachments { get => LimitationsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(LimitationsAttachmentsCollection.Data); }

        /// <summary>
        /// The name of the service offering.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Used to specify what the penalties will be for the service provider organization if a service level target has been breached.
        /// </summary>
        [XurrentField("penalties")]
        public string? Penalties { get; internal set; }

        [XurrentField("penaltiesAttachments")]
        internal PagedResponse<Attachment>? PenaltiesAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Penalties field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? PenaltiesAttachments { get => PenaltiesAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(PenaltiesAttachmentsCollection.Data); }

        /// <summary>
        /// Used to describe the transaction(s) and the maximum time these transaction(s) can take to complete.
        /// </summary>
        [XurrentField("performance")]
        public string? Performance { get; internal set; }

        [XurrentField("performanceAttachments")]
        internal PagedResponse<Attachment>? PerformanceAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Performance field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? PerformanceAttachments { get => PerformanceAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(PerformanceAttachmentsCollection.Data); }

        /// <summary>
        /// Used to specify which requirements need to be met by the customer in order for the customer to be able to benefit from the service. The service provider cannot be held accountable for breaches of the service level targets caused by a failure of the customer to meet one or more of these prerequisites.
        /// </summary>
        [XurrentField("prerequisites")]
        public string? Prerequisites { get; internal set; }

        [XurrentField("prerequisitesAttachments")]
        internal PagedResponse<Attachment>? PrerequisitesAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Prerequisites field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? PrerequisitesAttachments { get => PrerequisitesAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(PrerequisitesAttachmentsCollection.Data); }

        /// <summary>
        /// Defines the fixed price rate for a Case.
        /// </summary>
        [XurrentField("rateCase")]
        public decimal? RateCase { get; internal set; }

        /// <summary>
        /// Defines the currency for the fixed price rate of a Case.
        /// </summary>
        [XurrentField("rateCaseCurrency")]
        public Currency? RateCaseCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a high incident.
        /// </summary>
        [XurrentField("rateHigh")]
        public decimal? RateHigh { get; internal set; }

        /// <summary>
        /// Defines the currency for the fixed price rate of a high incident.
        /// </summary>
        [XurrentField("rateHighCurrency")]
        public Currency? RateHighCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a low incident.
        /// </summary>
        [XurrentField("rateLow")]
        public decimal? RateLow { get; internal set; }

        /// <summary>
        /// Defines the currency for the fixed price rate of a low incident.
        /// </summary>
        [XurrentField("rateLowCurrency")]
        public Currency? RateLowCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a medium incident.
        /// </summary>
        [XurrentField("rateMedium")]
        public decimal? RateMedium { get; internal set; }

        /// <summary>
        /// Defines the currency for the fixed price rate of a medium incident.
        /// </summary>
        [XurrentField("rateMediumCurrency")]
        public Currency? RateMediumCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a RFC.
        /// </summary>
        [XurrentField("rateRfc")]
        public decimal? RateRfc { get; internal set; }

        /// <summary>
        /// Defines the currency for the fixed price rate of a RFC.
        /// </summary>
        [XurrentField("rateRfcCurrency")]
        public Currency? RateRfcCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a RFI.
        /// </summary>
        [XurrentField("rateRfi")]
        public decimal? RateRfi { get; internal set; }

        /// <summary>
        /// Defines the currency for the fixed price rate of a RFI.
        /// </summary>
        [XurrentField("rateRfiCurrency")]
        public Currency? RateRfiCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a top incident.
        /// </summary>
        [XurrentField("rateTop")]
        public decimal? RateTop { get; internal set; }

        /// <summary>
        /// Defines the currency for the fixed price rate of a top incident.
        /// </summary>
        [XurrentField("rateTopCurrency")]
        public Currency? RateTopCurrency { get; internal set; }

        /// <summary>
        /// The Recovery Point Objective (RPO) is the maximum targeted duration in minutes in which data (transactions) might be lost from an IT service due to a major incident.
        /// </summary>
        [XurrentField("recoveryPointObjective")]
        public long? RecoveryPointObjective { get; internal set; }

        /// <summary>
        /// The Recovery Time Objective (RTO) is the maximum targeted duration in minutes in which a business process must be restored after a disaster (or disruption) in order to avoid unacceptable consequences associated with a break in business continuity.
        /// </summary>
        [XurrentField("recoveryTimeObjective")]
        public long? RecoveryTimeObjective { get; internal set; }

        /// <summary>
        /// Used to specify the maximum number of times per month that the service may become unavailable to customers with an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("reliability")]
        public string? Reliability { get; internal set; }

        /// <summary>
        /// Used to specify how often the representative of a customer of an active SLA that is based on the service offering will receive a report comparing the service level targets specified in the service offering with the actual level of service provided.
        /// </summary>
        [XurrentField("reportFrequency")]
        public ServiceOfferingReportFrequency? ReportFrequency { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the category "Case" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetCase")]
        public long? ResolutionTargetCase { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the category "Case" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetCaseInDays")]
        public long? ResolutionTargetCaseInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the impact value "High - Service Degraded for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetHigh")]
        public long? ResolutionTargetHigh { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the impact value "High - Service Degraded for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetHighInDays")]
        public long? ResolutionTargetHighInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Low - Service Degraded for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetLow")]
        public long? ResolutionTargetLow { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the impact value "Low - Service Degraded for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetLowInDays")]
        public long? ResolutionTargetLowInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Medium - Service Down for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetMedium")]
        public long? ResolutionTargetMedium { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the impact value "Medium - Service Down for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetMediumInDays")]
        public long? ResolutionTargetMediumInDays { get; internal set; }

        /// <summary>
        /// The resolution target notification scheme for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetNotificationSchemeHigh")]
        public SlaNotificationScheme? ResolutionTargetNotificationSchemeHigh { get; internal set; }

        /// <summary>
        /// The resolution target notification scheme for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetNotificationSchemeLow")]
        public SlaNotificationScheme? ResolutionTargetNotificationSchemeLow { get; internal set; }

        /// <summary>
        /// The resolution target notification scheme for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetNotificationSchemeMedium")]
        public SlaNotificationScheme? ResolutionTargetNotificationSchemeMedium { get; internal set; }

        /// <summary>
        /// The resolution target notification scheme for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetNotificationSchemeTop")]
        public SlaNotificationScheme? ResolutionTargetNotificationSchemeTop { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the category "RFC - Request for Change" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetRfc")]
        public long? ResolutionTargetRfc { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the category "RFC - Request for Change" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetRfcInDays")]
        public long? ResolutionTargetRfcInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the category "RFI - Request for Information" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetRfi")]
        public long? ResolutionTargetRfi { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the category "RFI - Request for Information" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetRfiInDays")]
        public long? ResolutionTargetRfiInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Top - Service Down for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetTop")]
        public long? ResolutionTargetTop { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the impact value "Top - Service Down for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetTopInDays")]
        public long? ResolutionTargetTopInDays { get; internal set; }

        /// <summary>
        /// The minimum percentage of incidents that is to be resolved before their resolution target.
        /// </summary>
        [XurrentField("resolutionsWithinTarget")]
        public long? ResolutionsWithinTarget { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetCase")]
        public long? ResponseTargetCase { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetCaseInDays")]
        public long? ResponseTargetCaseInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetHigh")]
        public long? ResponseTargetHigh { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetHighInDays")]
        public long? ResponseTargetHighInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetLow")]
        public long? ResponseTargetLow { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetLowInDays")]
        public long? ResponseTargetLowInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetMedium")]
        public long? ResponseTargetMedium { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetMediumInDays")]
        public long? ResponseTargetMediumInDays { get; internal set; }

        /// <summary>
        /// The response target notification scheme for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetNotificationSchemeHigh")]
        public SlaNotificationScheme? ResponseTargetNotificationSchemeHigh { get; internal set; }

        /// <summary>
        /// The response target notification scheme for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetNotificationSchemeLow")]
        public SlaNotificationScheme? ResponseTargetNotificationSchemeLow { get; internal set; }

        /// <summary>
        /// The response target notification scheme for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetNotificationSchemeMedium")]
        public SlaNotificationScheme? ResponseTargetNotificationSchemeMedium { get; internal set; }

        /// <summary>
        /// The response target notification scheme for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetNotificationSchemeTop")]
        public SlaNotificationScheme? ResponseTargetNotificationSchemeTop { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetRfc")]
        public long? ResponseTargetRfc { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetRfcInDays")]
        public long? ResponseTargetRfcInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetRfi")]
        public long? ResponseTargetRfi { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetRfiInDays")]
        public long? ResponseTargetRfiInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetTop")]
        public long? ResponseTargetTop { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetTopInDays")]
        public long? ResponseTargetTopInDays { get; internal set; }

        /// <summary>
        /// The minimum percentage of incidents that is to be responded to before their response target.
        /// </summary>
        [XurrentField("responsesWithinTarget")]
        public long? ResponsesWithinTarget { get; internal set; }

        /// <summary>
        /// How often an active SLA that is based on the service offering will be reviewed with the representative of its customer.
        /// </summary>
        [XurrentField("reviewFrequency")]
        public ServiceOfferingReviewFrequency? ReviewFrequency { get; internal set; }

        /// <summary>
        /// The service for which the service offering is being prepared.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

        /// <summary>
        /// Calendar that defines the hours during which the service is supposed to be available.
        /// </summary>
        [XurrentField("serviceHours")]
        public Calendar? ServiceHours { get; internal set; }

        [XurrentField("serviceLevelAgreements")]
        internal PagedResponse<ServiceLevelAgreement>? ServiceLevelAgreementsCollection { get; set; }
        /// <summary>
        /// Service level agreements of the service offering.
        /// </summary>
        public ReadOnlyDataCollection<ServiceLevelAgreement>? ServiceLevelAgreements { get => ServiceLevelAgreementsCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceLevelAgreement>(ServiceLevelAgreementsCollection.Data); }

        [XurrentField("shopArticles")]
        internal PagedResponse<ShopArticle>? ShopArticlesCollection { get; set; }
        /// <summary>
        /// Shop articles related to the service offering.
        /// </summary>
        public ReadOnlyDataCollection<ShopArticle>? ShopArticles { get => ShopArticlesCollection?.Data is null ? null : new ReadOnlyDataCollection<ShopArticle>(ShopArticlesCollection.Data); }

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

        [XurrentField("standardServiceRequests")]
        internal PagedResponse<StandardServiceRequest>? StandardServiceRequestsCollection { get; set; }
        /// <summary>
        /// Standard service requests of the service offering.
        /// </summary>
        public ReadOnlyDataCollection<StandardServiceRequest>? StandardServiceRequests { get => StandardServiceRequestsCollection?.Data is null ? null : new ReadOnlyDataCollection<StandardServiceRequest>(StandardServiceRequestsCollection.Data); }

        /// <summary>
        /// The current status of the service offering.
        /// </summary>
        [XurrentField("status")]
        public ServiceOfferingStatus? Status { get; internal set; }

        /// <summary>
        /// A high-level description of the differentiators between this service offering and other service offerings that have already been, or could be, prepared for the same service.
        /// </summary>
        [XurrentField("summary")]
        public string? Summary { get; internal set; }

        [XurrentField("summaryAttachments")]
        internal PagedResponse<Attachment>? SummaryAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Summary field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? SummaryAttachments { get => SummaryAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(SummaryAttachmentsCollection.Data); }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursCase")]
        public Calendar? SupportHoursCase { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursHigh")]
        public Calendar? SupportHoursHigh { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursLow")]
        public Calendar? SupportHoursLow { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursMedium")]
        public Calendar? SupportHoursMedium { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursRfc")]
        public Calendar? SupportHoursRfc { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursRfi")]
        public Calendar? SupportHoursRfi { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursTop")]
        public Calendar? SupportHoursTop { get; internal set; }

        /// <summary>
        /// Used to describe the length of notice required for changing or terminating the service level agreement.
        /// </summary>
        [XurrentField("termination")]
        public string? Termination { get; internal set; }

        [XurrentField("terminationAttachments")]
        internal PagedResponse<Attachment>? TerminationAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Termination field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? TerminationAttachments { get => TerminationAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(TerminationAttachmentsCollection.Data); }

        /// <summary>
        /// The time zone that applies to the selected service hours.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The waiting for customer follow-up for a request when it remains in status waiting for customer and has an active SLA that is based on this service offering. Only enabled waiting for customer follow-ups that are linked to the same account as the service offering can be selected.
        /// </summary>
        [XurrentField("waitingForCustomerFollowUp")]
        public WaitingForCustomerFollowUp? WaitingForCustomerFollowUp { get; internal set; }

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
            if (data is ServiceOffering serviceOffering)
            {
                ChargesAttachmentsCollection?.Data?.AddRange(serviceOffering.ChargesAttachments);
                ContinuityAttachmentsCollection?.Data?.AddRange(serviceOffering.ContinuityAttachments);
                EffortClassRatesCollection?.Data?.AddRange(serviceOffering.EffortClassRates);
                EffortClassesCollection?.Data?.AddRange(serviceOffering.EffortClasses);
                LimitationsAttachmentsCollection?.Data?.AddRange(serviceOffering.LimitationsAttachments);
                PenaltiesAttachmentsCollection?.Data?.AddRange(serviceOffering.PenaltiesAttachments);
                PerformanceAttachmentsCollection?.Data?.AddRange(serviceOffering.PerformanceAttachments);
                PrerequisitesAttachmentsCollection?.Data?.AddRange(serviceOffering.PrerequisitesAttachments);
                ServiceLevelAgreementsCollection?.Data?.AddRange(serviceOffering.ServiceLevelAgreements);
                ShopArticlesCollection?.Data?.AddRange(serviceOffering.ShopArticles);
                StandardServiceRequestsCollection?.Data?.AddRange(serviceOffering.StandardServiceRequests);
                SummaryAttachmentsCollection?.Data?.AddRange(serviceOffering.SummaryAttachments);
                TerminationAttachmentsCollection?.Data?.AddRange(serviceOffering.TerminationAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ChargesAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ChargesAttachmentsCollection.GetPageInfo("chargesAttachments", depth))
                    yield return pageInfo;

            if (ContinuityAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ContinuityAttachmentsCollection.GetPageInfo("continuityAttachments", depth))
                    yield return pageInfo;

            if (EffortClassRatesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in EffortClassRatesCollection.GetPageInfo("effortClassRates", depth))
                    yield return pageInfo;

            if (EffortClassesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in EffortClassesCollection.GetPageInfo("effortClasses", depth))
                    yield return pageInfo;

            if (LimitationsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in LimitationsAttachmentsCollection.GetPageInfo("limitationsAttachments", depth))
                    yield return pageInfo;

            if (PenaltiesAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PenaltiesAttachmentsCollection.GetPageInfo("penaltiesAttachments", depth))
                    yield return pageInfo;

            if (PerformanceAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PerformanceAttachmentsCollection.GetPageInfo("performanceAttachments", depth))
                    yield return pageInfo;

            if (PrerequisitesAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PrerequisitesAttachmentsCollection.GetPageInfo("prerequisitesAttachments", depth))
                    yield return pageInfo;

            if (ServiceLevelAgreementsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceLevelAgreementsCollection.GetPageInfo("serviceLevelAgreements", depth))
                    yield return pageInfo;

            if (ShopArticlesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ShopArticlesCollection.GetPageInfo("shopArticles", depth))
                    yield return pageInfo;

            if (StandardServiceRequestsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in StandardServiceRequestsCollection.GetPageInfo("standardServiceRequests", depth))
                    yield return pageInfo;

            if (SummaryAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SummaryAttachmentsCollection.GetPageInfo("summaryAttachments", depth))
                    yield return pageInfo;

            if (TerminationAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TerminationAttachmentsCollection.GetPageInfo("terminationAttachments", depth))
                    yield return pageInfo;
        }
    }
}
