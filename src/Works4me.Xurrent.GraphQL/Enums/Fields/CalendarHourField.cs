using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="CalendarHour">CalendarHour</see> fields.
    /// </summary>
    public enum CalendarHourField
    {
        /// <summary>
        /// The time from field.
        /// </summary>
        [XurrentEnum("timeFrom")]
        TimeFrom,

        /// <summary>
        /// The time until field.
        /// </summary>
        [XurrentEnum("timeUntil")]
        TimeUntil,

        /// <summary>
        /// The weekday field.
        /// </summary>
        [XurrentEnum("weekday")]
        Weekday
    }
}
