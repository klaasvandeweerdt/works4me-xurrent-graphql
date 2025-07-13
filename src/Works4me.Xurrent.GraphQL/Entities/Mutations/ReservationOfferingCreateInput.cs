using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/reservationofferingcreateinput/">ReservationOfferingCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class ReservationOfferingCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _disabled;
        private string? _serviceInstanceId;
        private Collection<string>? _filters;
        private ReservationStatus? _initialStatus;
        private long? _preparationDuration;
        private bool? _multiDay;
        private bool? _allowRepeat;
        private long? _minAdvanceDuration;
        private long? _maxAdvanceDuration;
        private bool? _privateReservations;
        private Collection<string>? _configurationItemIds;
        private string _name;
        private string _calendarId;
        private long _maxDuration;
        private long _minDuration;
        private long _stepDuration;
        private string _timeZone;

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
        /// Whether the reservation offering may not be used to register requests for reservation.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the service instance for which the reservations may be requested.
        /// </summary>
        [XurrentField("serviceInstanceId")]
        public string? ServiceInstanceId
        {
            get => _serviceInstanceId;
            set => _serviceInstanceId = Set("serviceInstanceId", value);
        }

        /// <summary>
        /// The filters of the reservation offering.
        /// </summary>
        [XurrentField("filters")]
        public Collection<string>? Filters
        {
            get => _filters;
            set => _filters = Set("filters", value);
        }

        /// <summary>
        /// The initial status of the reservation.
        /// </summary>
        [XurrentField("initialStatus")]
        public ReservationStatus? InitialStatus
        {
            get => _initialStatus;
            set => _initialStatus = Set("initialStatus", value);
        }

        /// <summary>
        /// The duration required to prepare the asset before the reservation starts.
        /// </summary>
        [XurrentField("preparationDuration")]
        public long? PreparationDuration
        {
            get => _preparationDuration;
            set => _preparationDuration = Set("preparationDuration", value);
        }

        /// <summary>
        /// Whether or not the reservation may span over multiple calendar days.
        /// </summary>
        [XurrentField("multiDay")]
        public bool? MultiDay
        {
            get => _multiDay;
            set => _multiDay = Set("multiDay", value);
        }

        /// <summary>
        /// Whether it is allowed to create recurrent reservations for this offering.
        /// </summary>
        [XurrentField("allowRepeat")]
        public bool? AllowRepeat
        {
            get => _allowRepeat;
            set => _allowRepeat = Set("allowRepeat", value);
        }

        /// <summary>
        /// The minimum duration between the creation time of a request for reservation and the requested start of the reservation.
        /// </summary>
        [XurrentField("minAdvanceDuration")]
        public long? MinAdvanceDuration
        {
            get => _minAdvanceDuration;
            set => _minAdvanceDuration = Set("minAdvanceDuration", value);
        }

        /// <summary>
        /// The maximum duration between the creation time of a request for reservation and the requested start of the reservation.
        /// </summary>
        [XurrentField("maxAdvanceDuration")]
        public long? MaxAdvanceDuration
        {
            get => _maxAdvanceDuration;
            set => _maxAdvanceDuration = Set("maxAdvanceDuration", value);
        }

        /// <summary>
        /// Reservations of this reservation offering are private and can not be viewed by other end users.
        /// </summary>
        [XurrentField("privateReservations")]
        public bool? PrivateReservations
        {
            get => _privateReservations;
            set => _privateReservations = Set("privateReservations", value);
        }

        /// <summary>
        /// Identifiers of the configuration items that may be reserved using this offering.
        /// </summary>
        [XurrentField("configurationItemIds")]
        public Collection<string>? ConfigurationItemIds
        {
            get => _configurationItemIds;
            set => _configurationItemIds = Set("configurationItemIds", value);
        }

        /// <summary>
        /// A short description of the reservation offering.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Calendar that defines the hours in which reservations may start and end.
        /// </summary>
        [XurrentField("calendarId")]
        public string CalendarId
        {
            get => _calendarId;
            set => _calendarId = Set("calendarId", value);
        }

        /// <summary>
        /// The maximum duration of the reservation within the hours of the calendar.
        /// </summary>
        [XurrentField("maxDuration")]
        public long MaxDuration
        {
            get => _maxDuration;
            set => _maxDuration = Set("maxDuration", value);
        }

        /// <summary>
        /// The minimum duration of the reservation within the hours of the calendar.
        /// </summary>
        [XurrentField("minDuration")]
        public long MinDuration
        {
            get => _minDuration;
            set => _minDuration = Set("minDuration", value);
        }

        /// <summary>
        /// The increments with which the reservation may be prolonged.
        /// </summary>
        [XurrentField("stepDuration")]
        public long StepDuration
        {
            get => _stepDuration;
            set => _stepDuration = Set("stepDuration", value);
        }

        /// <summary>
        /// The time zone that applies to the selected calendar.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationOfferingCreateInput"/> class without providing the required values.
        /// </summary>
        public ReservationOfferingCreateInput()
        {
            _name = string.Empty;
            _calendarId = string.Empty;
            _maxDuration = default;
            _minDuration = default;
            _stepDuration = default;
            _timeZone = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationOfferingCreateInput"/> class.
        /// </summary>
        public ReservationOfferingCreateInput(string name, string calendarId, long maxDuration, long minDuration, long stepDuration, string timeZone)
        {
            _name = Set("name", name);
            _calendarId = Set("calendarId", calendarId);
            _maxDuration = Set("maxDuration", maxDuration);
            _minDuration = Set("minDuration", minDuration);
            _stepDuration = Set("stepDuration", stepDuration);
            _timeZone = Set("timeZone", timeZone);
        }
    }
}
