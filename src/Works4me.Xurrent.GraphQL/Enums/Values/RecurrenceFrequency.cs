using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The recurrence frequency values.
    /// </summary>
    public enum RecurrenceFrequency
    {
        /// <summary>
        /// Daily.
        /// </summary>
        [XurrentEnum("daily")]
        Daily,

        /// <summary>
        /// Monthly.
        /// </summary>
        [XurrentEnum("monthly")]
        Monthly,

        /// <summary>
        /// No repeat.
        /// </summary>
        [XurrentEnum("no_repeat")]
        NoRepeat,

        /// <summary>
        /// Weekly.
        /// </summary>
        [XurrentEnum("weekly")]
        Weekly,

        /// <summary>
        /// Yearly.
        /// </summary>
        [XurrentEnum("yearly")]
        Yearly
    }
}
