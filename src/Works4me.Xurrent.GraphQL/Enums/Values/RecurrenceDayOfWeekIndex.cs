using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The recurrence day of week index values.
    /// </summary>
    public enum RecurrenceDayOfWeekIndex
    {
        /// <summary>
        /// First.
        /// </summary>
        [XurrentEnum("first")]
        First,

        /// <summary>
        /// Fourth.
        /// </summary>
        [XurrentEnum("fourth")]
        Fourth,

        /// <summary>
        /// Last.
        /// </summary>
        [XurrentEnum("last")]
        Last,

        /// <summary>
        /// Second.
        /// </summary>
        [XurrentEnum("second")]
        Second,

        /// <summary>
        /// Third.
        /// </summary>
        [XurrentEnum("third")]
        Third
    }
}
