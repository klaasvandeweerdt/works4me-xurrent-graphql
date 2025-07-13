using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/calendarupdateinput/">CalendarUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class CalendarUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _disabled;
        private string? _name;
        private Collection<string>? _holidayIds;
        private Collection<CalendarHoursInput>? _newCalendarHours;
        private string _id;
        private Collection<string>? _calendarHoursToDelete;

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
        /// Whether the calendar may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// The name of the calendar.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Identifiers of the holidays of the calendar.
        /// </summary>
        [XurrentField("holidayIds")]
        public Collection<string>? HolidayIds
        {
            get => _holidayIds;
            set => _holidayIds = Set("holidayIds", value);
        }

        /// <summary>
        /// Calendar hours of the calendar.
        /// </summary>
        [XurrentField("newCalendarHours")]
        public Collection<CalendarHoursInput>? NewCalendarHours
        {
            get => _newCalendarHours;
            set => _newCalendarHours = Set("newCalendarHours", value);
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
        /// Identifiers of calendar hours to remove from the calendar.
        /// </summary>
        [XurrentField("calendarHoursToDelete")]
        public Collection<string>? CalendarHoursToDelete
        {
            get => _calendarHoursToDelete;
            set => _calendarHoursToDelete = Set("calendarHoursToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarUpdateInput"/> class without providing the required values.
        /// </summary>
        public CalendarUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarUpdateInput"/> class.
        /// </summary>
        public CalendarUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
