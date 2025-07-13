using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The timesheet setting unit values.
    /// </summary>
    public enum TimesheetSettingUnit
    {
        /// <summary>
        /// Hours minutes.
        /// </summary>
        [XurrentEnum("hours_and_minutes")]
        HoursAndMinutes,

        /// <summary>
        /// Percentage of workday.
        /// </summary>
        [XurrentEnum("percentage_of_workday")]
        PercentageOfWorkday
    }
}
