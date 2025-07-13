using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Recurrence">Recurrence</see> fields.
    /// </summary>
    public enum RecurrenceField
    {
        /// <summary>
        /// The calendar field.
        /// </summary>
        [XurrentEnum("calendar")]
        Calendar,

        /// <summary>
        /// The day field.
        /// </summary>
        [XurrentEnum("day")]
        Day,

        /// <summary>
        /// The day of month field.
        /// </summary>
        [XurrentEnum("dayOfMonth")]
        DayOfMonth,

        /// <summary>
        /// The day of week field.
        /// </summary>
        [XurrentEnum("dayOfWeek")]
        DayOfWeek,

        /// <summary>
        /// The day of week day field.
        /// </summary>
        [XurrentEnum("dayOfWeekDay")]
        DayOfWeekDay,

        /// <summary>
        /// The day of week index field.
        /// </summary>
        [XurrentEnum("dayOfWeekIndex")]
        DayOfWeekIndex,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The end date field.
        /// </summary>
        [XurrentEnum("endDate")]
        EndDate,

        /// <summary>
        /// The frequency field.
        /// </summary>
        [XurrentEnum("frequency")]
        Frequency,

        /// <summary>
        /// The ical field.
        /// </summary>
        [XurrentEnum("ical")]
        Ical,

        /// <summary>
        /// The interval field.
        /// </summary>
        [XurrentEnum("interval")]
        Interval,

        /// <summary>
        /// The last occurrence at field.
        /// </summary>
        [XurrentEnum("lastOccurrenceAt")]
        LastOccurrenceAt,

        /// <summary>
        /// The last occurrence errors field.
        /// </summary>
        [XurrentEnum("lastOccurrenceErrors")]
        LastOccurrenceErrors,

        /// <summary>
        /// The month of year field.
        /// </summary>
        [XurrentEnum("monthOfYear")]
        MonthOfYear,

        /// <summary>
        /// The next occurrence at field.
        /// </summary>
        [XurrentEnum("nextOccurrenceAt")]
        NextOccurrenceAt,

        /// <summary>
        /// The start date field.
        /// </summary>
        [XurrentEnum("startDate")]
        StartDate,

        /// <summary>
        /// The time of day field.
        /// </summary>
        [XurrentEnum("timeOfDay")]
        TimeOfDay,

        /// <summary>
        /// The time zone field.
        /// </summary>
        [XurrentEnum("timeZone")]
        TimeZone
    }
}
