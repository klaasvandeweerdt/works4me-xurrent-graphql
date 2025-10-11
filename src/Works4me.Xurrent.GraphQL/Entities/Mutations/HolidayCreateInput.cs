using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/holidaycreateinput/">HolidayCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class HolidayCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private Collection<string>? _calendarIds;
        private string _name;
        private DateTime _startAt;
        private DateTime _endAt;

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
        /// The hyperlink to the image file for the record. This may be a <a href="https://developer.mozilla.org/en-US/docs/Web/URI/Reference/Schemes/data">'data URL'</a>, allowing the image to be supplied directly without requiring a separate upload first.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Identifiers of calendars of the holiday.
        /// </summary>
        [XurrentField("calendarIds")]
        public Collection<string>? CalendarIds
        {
            get => _calendarIds;
            set => _calendarIds = Set("calendarIds", value);
        }

        /// <summary>
        /// Name of the holiday.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Start of the holiday.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime StartAt
        {
            get => _startAt;
            set => _startAt = Set("startAt", value);
        }

        /// <summary>
        /// End of the holiday.
        /// </summary>
        [XurrentField("endAt")]
        public DateTime EndAt
        {
            get => _endAt;
            set => _endAt = Set("endAt", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidayCreateInput"/> class without providing the required values.
        /// </summary>
        public HolidayCreateInput()
        {
            _name = string.Empty;
            _startAt = default;
            _endAt = default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidayCreateInput"/> class.
        /// </summary>
        public HolidayCreateInput(string name, DateTime startAt, DateTime endAt)
        {
            _name = Set("name", name);
            _startAt = Set("startAt", startAt);
            _endAt = Set("endAt", endAt);
        }
    }
}
