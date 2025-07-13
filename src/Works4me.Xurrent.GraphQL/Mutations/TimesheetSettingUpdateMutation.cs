namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing timesheet setting.
    /// </summary>
    internal sealed class TimesheetSettingUpdateMutation : Mutation<TimesheetSettingUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetSettingUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the timesheet setting mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TimesheetSettingUpdateMutation(TimesheetSettingUpdateInput data, TimesheetSettingQuery query)
            : base("timesheetSettingUpdate", "TimesheetSettingUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "timesheetSetting")))
        {
        }
    }
}
