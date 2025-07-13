using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The timesheet setting time increment values.
    /// </summary>
    public enum TimesheetSettingTimeIncrement
    {
        /// <summary>
        /// Ten.
        /// </summary>
        [XurrentEnum("10")]
        Ten,

        /// <summary>
        /// OneHundredAndTwenty.
        /// </summary>
        [XurrentEnum("120")]
        OneHundredAndTwenty,

        /// <summary>
        /// Fifteen.
        /// </summary>
        [XurrentEnum("15")]
        Fifteen,

        /// <summary>
        /// TwoHundredAndForty.
        /// </summary>
        [XurrentEnum("240")]
        TwoHundredAndForty,

        /// <summary>
        /// Thirty.
        /// </summary>
        [XurrentEnum("30")]
        Thirty,

        /// <summary>
        /// Five.
        /// </summary>
        [XurrentEnum("5")]
        Five,

        /// <summary>
        /// Sixty.
        /// </summary>
        [XurrentEnum("60")]
        Sixty
    }
}
