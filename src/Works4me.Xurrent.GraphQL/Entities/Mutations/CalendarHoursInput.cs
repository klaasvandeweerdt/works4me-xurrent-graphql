using System;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/calendarhoursinput/">CalendarHoursInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class CalendarHoursInput : PropertyChangeSet
    {
        private string? _id;
        private TimeSpan? _timeFrom;
        private TimeSpan? _timeUntil;
        private Weekday? _weekday;

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
        /// The time at which the calendar becomes active on the given weekday.
        /// </summary>
        [XurrentField("timeFrom")]
        public TimeSpan? TimeFrom
        {
            get => _timeFrom;
            set => _timeFrom = Set("timeFrom", value);
        }

        /// <summary>
        /// The time at which the calendar stops being active on the given weekday.
        /// </summary>
        [XurrentField("timeUntil")]
        public TimeSpan? TimeUntil
        {
            get => _timeUntil;
            set => _timeUntil = Set("timeUntil", value);
        }

        /// <summary>
        /// The day of the week.
        /// </summary>
        [XurrentField("weekday")]
        public Weekday? Weekday
        {
            get => _weekday;
            set => _weekday = Set("weekday", value);
        }
    }
}
