using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The weekday values.
    /// </summary>
    public enum Weekday
    {
        /// <summary>
        /// Fridays.
        /// </summary>
        [XurrentEnum("fri")]
        Fri,

        /// <summary>
        /// Mondays.
        /// </summary>
        [XurrentEnum("mon")]
        Mon,

        /// <summary>
        /// Saturdays.
        /// </summary>
        [XurrentEnum("sat")]
        Sat,

        /// <summary>
        /// Sundays.
        /// </summary>
        [XurrentEnum("sun")]
        Sun,

        /// <summary>
        /// Thursdays.
        /// </summary>
        [XurrentEnum("thu")]
        Thu,

        /// <summary>
        /// Tuesdays.
        /// </summary>
        [XurrentEnum("tue")]
        Tue,

        /// <summary>
        /// Wednesdays.
        /// </summary>
        [XurrentEnum("wed")]
        Wed
    }
}
