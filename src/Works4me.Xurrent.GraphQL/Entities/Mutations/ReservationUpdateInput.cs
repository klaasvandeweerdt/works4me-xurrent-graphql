using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/reservationupdateinput/">ReservationUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class ReservationUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _name;
        private ReservationStatus? _status;
        private string? _reservationOfferingId;
        private string? _requestId;
        private string? _createdById;
        private string? _personId;
        private string? _configurationItemId;
        private DateTime? _preparationStartAt;
        private DateTime? _startAt;
        private DateTime? _endAt;
        private long? _duration;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private ReservationRecurrenceInput? _recurrence;
        private string _id;

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
        /// A short description of the reservation.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The status of the reservation.
        /// </summary>
        [XurrentField("status")]
        public ReservationStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// Identifier of the reservation offering that was used to create this reservation.
        /// </summary>
        [XurrentField("reservationOfferingId")]
        public string? ReservationOfferingId
        {
            get => _reservationOfferingId;
            set => _reservationOfferingId = Set("reservationOfferingId", value);
        }

        /// <summary>
        /// Identifier of the request for reservation.
        /// </summary>
        [XurrentField("requestId")]
        public string? RequestId
        {
            get => _requestId;
            set => _requestId = Set("requestId", value);
        }

        /// <summary>
        /// Identifier of the person who created this reservation.
        /// </summary>
        [XurrentField("createdById")]
        public string? CreatedById
        {
            get => _createdById;
            set => _createdById = Set("createdById", value);
        }

        /// <summary>
        /// Identifier of the person for whom this reservation was created.
        /// </summary>
        [XurrentField("personId")]
        public string? PersonId
        {
            get => _personId;
            set => _personId = Set("personId", value);
        }

        /// <summary>
        /// Identifier of the asset that is being reserved.
        /// </summary>
        [XurrentField("configurationItemId")]
        public string? ConfigurationItemId
        {
            get => _configurationItemId;
            set => _configurationItemId = Set("configurationItemId", value);
        }

        /// <summary>
        /// The start date and time of the preparation of the asset for the reservation. Only present in case the reservation offering specifies a preparation duration.
        /// </summary>
        [XurrentField("preparationStartAt")]
        public DateTime? PreparationStartAt
        {
            get => _preparationStartAt;
            set => _preparationStartAt = Set("preparationStartAt", value);
        }

        /// <summary>
        /// Used to specify the start date and time of the reservation.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt
        {
            get => _startAt;
            set => _startAt = Set("startAt", value);
        }

        /// <summary>
        /// Used to specify the end date and time of the reservation.
        /// </summary>
        [XurrentField("endAt")]
        public DateTime? EndAt
        {
            get => _endAt;
            set => _endAt = Set("endAt", value);
        }

        /// <summary>
        /// The duration of the reservation during the calendar hours of the reservation offering.
        /// </summary>
        [XurrentField("duration")]
        public long? Duration
        {
            get => _duration;
            set => _duration = Set("duration", value);
        }

        /// <summary>
        /// Full description of the reservation.
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        [XurrentField("descriptionAttachments")]
        public Collection<AttachmentInput>? DescriptionAttachments
        {
            get => _descriptionAttachments;
            set => _descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// Recurrence for the reservation.
        /// </summary>
        [XurrentField("recurrence")]
        public ReservationRecurrenceInput? Recurrence
        {
            get => _recurrence;
            set => _recurrence = Set("recurrence", value);
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
        /// Initializes a new instance of the <see cref="ReservationUpdateInput"/> class without providing the required values.
        /// </summary>
        public ReservationUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationUpdateInput"/> class.
        /// </summary>
        public ReservationUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
