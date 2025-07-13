namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new timesheet setting.
    /// </summary>
    internal sealed class TimesheetSettingCreateMutation : Mutation<TimesheetSettingCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetSettingCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TimesheetSettingCreateMutation(TimesheetSettingCreateInput data, TimesheetSettingQuery query)
            : base("timesheetSettingCreate", "TimesheetSettingCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "timesheetSetting")))
        {
        }
    }
}
