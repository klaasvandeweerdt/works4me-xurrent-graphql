using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The timesheet setting percentage increment values.
    /// </summary>
    public enum TimesheetSettingPercentageIncrement
    {
        /// <summary>
        /// OneHundred.
        /// </summary>
        [XurrentEnum("100")]
        OneHundred,

        /// <summary>
        /// TwelveAndFifty.
        /// </summary>
        [XurrentEnum("12.5")]
        TwelveAndFifty,

        /// <summary>
        /// TwentyFive.
        /// </summary>
        [XurrentEnum("25")]
        TwentyFive,

        /// <summary>
        /// Fifty.
        /// </summary>
        [XurrentEnum("50")]
        Fifty
    }
}
