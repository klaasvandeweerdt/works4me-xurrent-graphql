using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/serviceofferingupdateinput/">ServiceOfferingUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class ServiceOfferingUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private decimal? _availability;
        private string? _charges;
        private string? _continuity;
        private string? _defaultEffortClassId;
        private string? _limitations;
        private string? _name;
        private string? _penalties;
        private string? _performance;
        private string? _prerequisites;
        private long? _recoveryTimeObjective;
        private long? _recoveryPointObjective;
        private string? _reliability;
        private ServiceOfferingReportFrequency? _reportFrequency;
        private long? _resolutionTargetCase;
        private long? _resolutionTargetHigh;
        private long? _resolutionTargetLow;
        private long? _resolutionTargetMedium;
        private long? _resolutionTargetRfc;
        private long? _resolutionTargetRfi;
        private long? _resolutionTargetTop;
        private long? _resolutionsWithinTarget;
        private long? _responseTargetCase;
        private long? _responseTargetHigh;
        private long? _responseTargetLow;
        private long? _responseTargetMedium;
        private long? _responseTargetRfc;
        private long? _responseTargetRfi;
        private long? _responseTargetTop;
        private long? _responsesWithinTarget;
        private ServiceOfferingReviewFrequency? _reviewFrequency;
        private string? _serviceId;
        private string? _serviceHoursId;
        private ServiceOfferingStatus? _status;
        private string? _summary;
        private string? _supportHoursCaseId;
        private string? _supportHoursHighId;
        private string? _supportHoursLowId;
        private string? _supportHoursMediumId;
        private string? _supportHoursRfcId;
        private string? _supportHoursRfiId;
        private string? _supportHoursTopId;
        private string? _termination;
        private string? _timeZone;
        private Collection<string>? _effortClassIds;
        private ServiceOfferingChargeType? _chargeTypeTop;
        private decimal? _rateTop;
        private Currency? _rateTopCurrency;
        private ServiceOfferingChargeType? _chargeTypeHigh;
        private decimal? _rateHigh;
        private Currency? _rateHighCurrency;
        private ServiceOfferingChargeType? _chargeTypeMedium;
        private decimal? _rateMedium;
        private Currency? _rateMediumCurrency;
        private ServiceOfferingChargeType? _chargeTypeLow;
        private decimal? _rateLow;
        private Currency? _rateLowCurrency;
        private ServiceOfferingChargeType? _chargeTypeRfc;
        private decimal? _rateRfc;
        private Currency? _rateRfcCurrency;
        private ServiceOfferingChargeType? _chargeTypeRfi;
        private decimal? _rateRfi;
        private Currency? _rateRfiCurrency;
        private ServiceOfferingChargeType? _chargeTypeCase;
        private decimal? _rateCase;
        private Currency? _rateCaseCurrency;
        private Collection<StandardServiceRequestInput>? _newStandardServiceRequests;
        private Collection<EffortClassRateInput>? _newEffortClassRates;
        private string _id;
        private Collection<string>? _standardServiceRequestsToDelete;
        private Collection<string>? _effortClassRatesToDelete;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// The duration, expressed as percentage of the total number of service hours, during which the service is to be available to customers with an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("availability")]
        public decimal? Availability
        {
            get => _availability;
            set => _availability = Set("availability", value);
        }

        /// <summary>
        /// The amount that the service provider will charge the customer for the delivery of the service per charge driver, per charge term.
        /// </summary>
        [XurrentField("charges")]
        public string? Charges
        {
            get => _charges;
            set => _charges = Set("charges", value);
        }

        /// <summary>
        /// The continuity measures for the service offering.
        /// </summary>
        [XurrentField("continuity")]
        public string? Continuity
        {
            get => _continuity;
            set => _continuity = Set("continuity", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on a request with an affected SLA linked to this service offering.
        /// </summary>
        [XurrentField("defaultEffortClassId")]
        public string? DefaultEffortClassId
        {
            get => _defaultEffortClassId;
            set => _defaultEffortClassId = Set("defaultEffortClassId", value);
        }

        /// <summary>
        /// The limitations that apply to the service level agreements that are based on the service offering.
        /// </summary>
        [XurrentField("limitations")]
        public string? Limitations
        {
            get => _limitations;
            set => _limitations = Set("limitations", value);
        }

        /// <summary>
        /// The name of the service offering.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Used to specify what the penalties will be for the service provider organization if a service level target has been breached.
        /// </summary>
        [XurrentField("penalties")]
        public string? Penalties
        {
            get => _penalties;
            set => _penalties = Set("penalties", value);
        }

        /// <summary>
        /// Used to describe the transaction(s) and the maximum time these transaction(s) can take to complete.
        /// </summary>
        [XurrentField("performance")]
        public string? Performance
        {
            get => _performance;
            set => _performance = Set("performance", value);
        }

        /// <summary>
        /// Used to specify which requirements need to be met by the customer in order for the customer to be able to benefit from the service. The service provider cannot be held accountable for breaches of the service level targets caused by a failure of the customer to meet one or more of these prerequisites.
        /// </summary>
        [XurrentField("prerequisites")]
        public string? Prerequisites
        {
            get => _prerequisites;
            set => _prerequisites = Set("prerequisites", value);
        }

        /// <summary>
        /// The Recovery Time Objective (RTO) is the maximum targeted duration in minutes in which a business process must be restored after a disaster (or disruption) in order to avoid unacceptable consequences associated with a break in business continuity.
        /// </summary>
        [XurrentField("recoveryTimeObjective")]
        public long? RecoveryTimeObjective
        {
            get => _recoveryTimeObjective;
            set => _recoveryTimeObjective = Set("recoveryTimeObjective", value);
        }

        /// <summary>
        /// The Recovery Point Objective (RPO) is the maximum targeted duration in minutes in which data (transactions) might be lost from an IT service due to a major incident.
        /// </summary>
        [XurrentField("recoveryPointObjective")]
        public long? RecoveryPointObjective
        {
            get => _recoveryPointObjective;
            set => _recoveryPointObjective = Set("recoveryPointObjective", value);
        }

        /// <summary>
        /// Used to specify the maximum number of times per month that the service may become unavailable to customers with an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("reliability")]
        public string? Reliability
        {
            get => _reliability;
            set => _reliability = Set("reliability", value);
        }

        /// <summary>
        /// Used to specify how often the representative of a customer of an active SLA that is based on the service offering will receive a report comparing the service level targets specified in the service offering with the actual level of service provided.
        /// </summary>
        [XurrentField("reportFrequency")]
        public ServiceOfferingReportFrequency? ReportFrequency
        {
            get => _reportFrequency;
            set => _reportFrequency = Set("reportFrequency", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the category "Case" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetCase")]
        public long? ResolutionTargetCase
        {
            get => _resolutionTargetCase;
            set => _resolutionTargetCase = Set("resolutionTargetCase", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the impact value "High - Service Degraded for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetHigh")]
        public long? ResolutionTargetHigh
        {
            get => _resolutionTargetHigh;
            set => _resolutionTargetHigh = Set("resolutionTargetHigh", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Low - Service Degraded for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetLow")]
        public long? ResolutionTargetLow
        {
            get => _resolutionTargetLow;
            set => _resolutionTargetLow = Set("resolutionTargetLow", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Medium - Service Down for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetMedium")]
        public long? ResolutionTargetMedium
        {
            get => _resolutionTargetMedium;
            set => _resolutionTargetMedium = Set("resolutionTargetMedium", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the category "RFC - Request for Change" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetRfc")]
        public long? ResolutionTargetRfc
        {
            get => _resolutionTargetRfc;
            set => _resolutionTargetRfc = Set("resolutionTargetRfc", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the category "RFI - Request for Information" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetRfi")]
        public long? ResolutionTargetRfi
        {
            get => _resolutionTargetRfi;
            set => _resolutionTargetRfi = Set("resolutionTargetRfi", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Top - Service Down for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetTop")]
        public long? ResolutionTargetTop
        {
            get => _resolutionTargetTop;
            set => _resolutionTargetTop = Set("resolutionTargetTop", value);
        }

        /// <summary>
        /// The minimum percentage of incidents that is to be resolved before their resolution target.
        /// </summary>
        [XurrentField("resolutionsWithinTarget")]
        public long? ResolutionsWithinTarget
        {
            get => _resolutionsWithinTarget;
            set => _resolutionsWithinTarget = Set("resolutionsWithinTarget", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetCase")]
        public long? ResponseTargetCase
        {
            get => _responseTargetCase;
            set => _responseTargetCase = Set("responseTargetCase", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetHigh")]
        public long? ResponseTargetHigh
        {
            get => _responseTargetHigh;
            set => _responseTargetHigh = Set("responseTargetHigh", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetLow")]
        public long? ResponseTargetLow
        {
            get => _responseTargetLow;
            set => _responseTargetLow = Set("responseTargetLow", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetMedium")]
        public long? ResponseTargetMedium
        {
            get => _responseTargetMedium;
            set => _responseTargetMedium = Set("responseTargetMedium", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetRfc")]
        public long? ResponseTargetRfc
        {
            get => _responseTargetRfc;
            set => _responseTargetRfc = Set("responseTargetRfc", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetRfi")]
        public long? ResponseTargetRfi
        {
            get => _responseTargetRfi;
            set => _responseTargetRfi = Set("responseTargetRfi", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetTop")]
        public long? ResponseTargetTop
        {
            get => _responseTargetTop;
            set => _responseTargetTop = Set("responseTargetTop", value);
        }

        /// <summary>
        /// The minimum percentage of incidents that is to be responded to before their response target.
        /// </summary>
        [XurrentField("responsesWithinTarget")]
        public long? ResponsesWithinTarget
        {
            get => _responsesWithinTarget;
            set => _responsesWithinTarget = Set("responsesWithinTarget", value);
        }

        /// <summary>
        /// How often an active SLA that is based on the service offering will be reviewed with the representative of its customer.
        /// </summary>
        [XurrentField("reviewFrequency")]
        public ServiceOfferingReviewFrequency? ReviewFrequency
        {
            get => _reviewFrequency;
            set => _reviewFrequency = Set("reviewFrequency", value);
        }

        /// <summary>
        /// Identifier of the service for which the service offering is being prepared.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the hours during which the service is supposed to be available.
        /// </summary>
        [XurrentField("serviceHoursId")]
        public string? ServiceHoursId
        {
            get => _serviceHoursId;
            set => _serviceHoursId = Set("serviceHoursId", value);
        }

        /// <summary>
        /// The current status of the service offering.
        /// </summary>
        [XurrentField("status")]
        public ServiceOfferingStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// A high-level description of the differentiators between this service offering and other service offerings that have already been, or could be, prepared for the same service.
        /// </summary>
        [XurrentField("summary")]
        public string? Summary
        {
            get => _summary;
            set => _summary = Set("summary", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursCaseId")]
        public string? SupportHoursCaseId
        {
            get => _supportHoursCaseId;
            set => _supportHoursCaseId = Set("supportHoursCaseId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursHighId")]
        public string? SupportHoursHighId
        {
            get => _supportHoursHighId;
            set => _supportHoursHighId = Set("supportHoursHighId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursLowId")]
        public string? SupportHoursLowId
        {
            get => _supportHoursLowId;
            set => _supportHoursLowId = Set("supportHoursLowId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursMediumId")]
        public string? SupportHoursMediumId
        {
            get => _supportHoursMediumId;
            set => _supportHoursMediumId = Set("supportHoursMediumId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursRfcId")]
        public string? SupportHoursRfcId
        {
            get => _supportHoursRfcId;
            set => _supportHoursRfcId = Set("supportHoursRfcId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursRfiId")]
        public string? SupportHoursRfiId
        {
            get => _supportHoursRfiId;
            set => _supportHoursRfiId = Set("supportHoursRfiId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursTopId")]
        public string? SupportHoursTopId
        {
            get => _supportHoursTopId;
            set => _supportHoursTopId = Set("supportHoursTopId", value);
        }

        /// <summary>
        /// Used to describe the length of notice required for changing or terminating the service level agreement.
        /// </summary>
        [XurrentField("termination")]
        public string? Termination
        {
            get => _termination;
            set => _termination = Set("termination", value);
        }

        /// <summary>
        /// The time zone that applies to the selected service hours.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Identifiers of effort classes of the service offering.
        /// </summary>
        [XurrentField("effortClassIds")]
        public Collection<string>? EffortClassIds
        {
            get => _effortClassIds;
            set => _effortClassIds = Set("effortClassIds", value);
        }

        /// <summary>
        /// Defines how a top incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeTop")]
        public ServiceOfferingChargeType? ChargeTypeTop
        {
            get => _chargeTypeTop;
            set => _chargeTypeTop = Set("chargeTypeTop", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a top incident.
        /// </summary>
        [XurrentField("rateTop")]
        public decimal? RateTop
        {
            get => _rateTop;
            set => _rateTop = Set("rateTop", value);
        }

        /// <summary>
        /// Defines the currency for the fixed price rate of a top incident.
        /// </summary>
        [XurrentField("rateTopCurrency")]
        public Currency? RateTopCurrency
        {
            get => _rateTopCurrency;
            set => _rateTopCurrency = Set("rateTopCurrency", value);
        }

        /// <summary>
        /// Defines how a high incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeHigh")]
        public ServiceOfferingChargeType? ChargeTypeHigh
        {
            get => _chargeTypeHigh;
            set => _chargeTypeHigh = Set("chargeTypeHigh", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a high incident.
        /// </summary>
        [XurrentField("rateHigh")]
        public decimal? RateHigh
        {
            get => _rateHigh;
            set => _rateHigh = Set("rateHigh", value);
        }

        /// <summary>
        /// Defines the currency for the fixed price rate of a high incident.
        /// </summary>
        [XurrentField("rateHighCurrency")]
        public Currency? RateHighCurrency
        {
            get => _rateHighCurrency;
            set => _rateHighCurrency = Set("rateHighCurrency", value);
        }

        /// <summary>
        /// Defines how a medium incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeMedium")]
        public ServiceOfferingChargeType? ChargeTypeMedium
        {
            get => _chargeTypeMedium;
            set => _chargeTypeMedium = Set("chargeTypeMedium", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a medium incident.
        /// </summary>
        [XurrentField("rateMedium")]
        public decimal? RateMedium
        {
            get => _rateMedium;
            set => _rateMedium = Set("rateMedium", value);
        }

        /// <summary>
        /// Defines the currency for the fixed price rate of a medium incident.
        /// </summary>
        [XurrentField("rateMediumCurrency")]
        public Currency? RateMediumCurrency
        {
            get => _rateMediumCurrency;
            set => _rateMediumCurrency = Set("rateMediumCurrency", value);
        }

        /// <summary>
        /// Defines how a low incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeLow")]
        public ServiceOfferingChargeType? ChargeTypeLow
        {
            get => _chargeTypeLow;
            set => _chargeTypeLow = Set("chargeTypeLow", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a low incident.
        /// </summary>
        [XurrentField("rateLow")]
        public decimal? RateLow
        {
            get => _rateLow;
            set => _rateLow = Set("rateLow", value);
        }

        /// <summary>
        /// Defines the currency for the fixed price rate of a low incident.
        /// </summary>
        [XurrentField("rateLowCurrency")]
        public Currency? RateLowCurrency
        {
            get => _rateLowCurrency;
            set => _rateLowCurrency = Set("rateLowCurrency", value);
        }

        /// <summary>
        /// Defines how a RFC must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeRfc")]
        public ServiceOfferingChargeType? ChargeTypeRfc
        {
            get => _chargeTypeRfc;
            set => _chargeTypeRfc = Set("chargeTypeRfc", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a RFC.
        /// </summary>
        [XurrentField("rateRfc")]
        public decimal? RateRfc
        {
            get => _rateRfc;
            set => _rateRfc = Set("rateRfc", value);
        }

        /// <summary>
        /// Defines the currency for the fixed price rate of a RFC.
        /// </summary>
        [XurrentField("rateRfcCurrency")]
        public Currency? RateRfcCurrency
        {
            get => _rateRfcCurrency;
            set => _rateRfcCurrency = Set("rateRfcCurrency", value);
        }

        /// <summary>
        /// Defines how a RFI must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeRfi")]
        public ServiceOfferingChargeType? ChargeTypeRfi
        {
            get => _chargeTypeRfi;
            set => _chargeTypeRfi = Set("chargeTypeRfi", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a RFI.
        /// </summary>
        [XurrentField("rateRfi")]
        public decimal? RateRfi
        {
            get => _rateRfi;
            set => _rateRfi = Set("rateRfi", value);
        }

        /// <summary>
        /// Defines the currency for the fixed price rate of a RFI.
        /// </summary>
        [XurrentField("rateRfiCurrency")]
        public Currency? RateRfiCurrency
        {
            get => _rateRfiCurrency;
            set => _rateRfiCurrency = Set("rateRfiCurrency", value);
        }

        /// <summary>
        /// Defines how a Case must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeTypeCase")]
        public ServiceOfferingChargeType? ChargeTypeCase
        {
            get => _chargeTypeCase;
            set => _chargeTypeCase = Set("chargeTypeCase", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a Case.
        /// </summary>
        [XurrentField("rateCase")]
        public decimal? RateCase
        {
            get => _rateCase;
            set => _rateCase = Set("rateCase", value);
        }

        /// <summary>
        /// Defines the currency for the fixed price rate of a Case.
        /// </summary>
        [XurrentField("rateCaseCurrency")]
        public Currency? RateCaseCurrency
        {
            get => _rateCaseCurrency;
            set => _rateCaseCurrency = Set("rateCaseCurrency", value);
        }

        /// <summary>
        /// Standard service requests of the service offering.
        /// </summary>
        [XurrentField("newStandardServiceRequests")]
        public Collection<StandardServiceRequestInput>? NewStandardServiceRequests
        {
            get => _newStandardServiceRequests;
            set => _newStandardServiceRequests = Set("newStandardServiceRequests", value);
        }

        /// <summary>
        /// Effort class rates of the service offering.
        /// </summary>
        [XurrentField("newEffortClassRates")]
        public Collection<EffortClassRateInput>? NewEffortClassRates
        {
            get => _newEffortClassRates;
            set => _newEffortClassRates = Set("newEffortClassRates", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Identifiers of standard service requests to remove from the service offering.
        /// </summary>
        [XurrentField("standardServiceRequestsToDelete")]
        public Collection<string>? StandardServiceRequestsToDelete
        {
            get => _standardServiceRequestsToDelete;
            set => _standardServiceRequestsToDelete = Set("standardServiceRequestsToDelete", value);
        }

        /// <summary>
        /// Identifiers of effort class rates to remove from the service offering.
        /// </summary>
        [XurrentField("effortClassRatesToDelete")]
        public Collection<string>? EffortClassRatesToDelete
        {
            get => _effortClassRatesToDelete;
            set => _effortClassRatesToDelete = Set("effortClassRatesToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOfferingUpdateInput"/> class without providing the required values.
        /// </summary>
        public ServiceOfferingUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOfferingUpdateInput"/> class.
        /// </summary>
        public ServiceOfferingUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
