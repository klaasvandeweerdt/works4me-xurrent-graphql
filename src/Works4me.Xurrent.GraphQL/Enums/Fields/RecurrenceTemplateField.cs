using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RecurrenceTemplate">RecurrenceTemplate</see> fields.
    /// </summary>
    public enum RecurrenceTemplateField
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
        /// The frequency field.
        /// </summary>
        [XurrentEnum("frequency")]
        Frequency,

        /// <summary>
        /// The interval field.
        /// </summary>
        [XurrentEnum("interval")]
        Interval,

        /// <summary>
        /// The month of year field.
        /// </summary>
        [XurrentEnum("monthOfYear")]
        MonthOfYear,

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
