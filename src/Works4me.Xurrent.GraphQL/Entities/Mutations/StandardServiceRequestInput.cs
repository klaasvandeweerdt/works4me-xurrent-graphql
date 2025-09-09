using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/standardservicerequestinput/">StandardServiceRequestInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class StandardServiceRequestInput : PropertyChangeSet
    {
        private string? _id;
        private string? _requestTemplateId;
        private long? _responseTarget;
        private long? _responseTargetInDays;
        private bool? _responseTargetBestEffort;
        private long? _resolutionTarget;
        private long? _resolutionTargetInDays;
        private bool? _resolutionTargetBestEffort;
        private string? _supportHoursId;
        private string? _responseTargetNotificationSchemeId;
        private string? _resolutionTargetNotificationSchemeId;
        private ServiceOfferingChargeType? _chargeType;
        private decimal? _rate;
        private Currency? _rateCurrency;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [XurrentField("id")]
        public string? Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Identifier of the request template related to the service offering. Only the request templates that are linked to the same service as the service offering can be selected.
        /// </summary>
        [XurrentField("requestTemplateId")]
        public string? RequestTemplateId
        {
            get => _requestTemplateId;
            set => _requestTemplateId = Set("requestTemplateId", value);
        }

        /// <summary>
        /// Number of minutes within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTarget")]
        public long? ResponseTarget
        {
            get => _responseTarget;
            set => _responseTarget = Set("responseTarget", value);
        }

        /// <summary>
        /// Number of business days within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetInDays")]
        public long? ResponseTargetInDays
        {
            get => _responseTargetInDays;
            set => _responseTargetInDays = Set("responseTargetInDays", value);
        }

        /// <summary>
        /// Set response target to Best Effort when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("responseTargetBestEffort")]
        public bool? ResponseTargetBestEffort
        {
            get => _responseTargetBestEffort;
            set => _responseTargetBestEffort = Set("responseTargetBestEffort", value);
        }

        /// <summary>
        /// Number of minutes within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTarget")]
        public long? ResolutionTarget
        {
            get => _resolutionTarget;
            set => _resolutionTarget = Set("resolutionTarget", value);
        }

        /// <summary>
        /// Number of business days within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetInDays")]
        public long? ResolutionTargetInDays
        {
            get => _resolutionTargetInDays;
            set => _resolutionTargetInDays = Set("resolutionTargetInDays", value);
        }

        /// <summary>
        /// Set the resolution target to Best Effort when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("resolutionTargetBestEffort")]
        public bool? ResolutionTargetBestEffort
        {
            get => _resolutionTargetBestEffort;
            set => _resolutionTargetBestEffort = Set("resolutionTargetBestEffort", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [XurrentField("supportHoursId")]
        public string? SupportHoursId
        {
            get => _supportHoursId;
            set => _supportHoursId = Set("supportHoursId", value);
        }

        /// <summary>
        /// Identifier of the response target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        [XurrentField("responseTargetNotificationSchemeId")]
        public string? ResponseTargetNotificationSchemeId
        {
            get => _responseTargetNotificationSchemeId;
            set => _responseTargetNotificationSchemeId = Set("responseTargetNotificationSchemeId", value);
        }

        /// <summary>
        /// Identifier of the resolution target notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        [XurrentField("resolutionTargetNotificationSchemeId")]
        public string? ResolutionTargetNotificationSchemeId
        {
            get => _resolutionTargetNotificationSchemeId;
            set => _resolutionTargetNotificationSchemeId = Set("resolutionTargetNotificationSchemeId", value);
        }

        /// <summary>
        /// Defines how a standard service request must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [XurrentField("chargeType")]
        public ServiceOfferingChargeType? ChargeType
        {
            get => _chargeType;
            set => _chargeType = Set("chargeType", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a standard service request.
        /// </summary>
        [XurrentField("rate")]
        public decimal? Rate
        {
            get => _rate;
            set => _rate = Set("rate", value);
        }

        /// <summary>
        /// Defines the currency for the fixed price rate of a standard service request.
        /// </summary>
        [XurrentField("rateCurrency")]
        public Currency? RateCurrency
        {
            get => _rateCurrency;
            set => _rateCurrency = Set("rateCurrency", value);
        }
    }
}
