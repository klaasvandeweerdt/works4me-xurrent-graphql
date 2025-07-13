namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing time entry.
    /// </summary>
    internal sealed class TimeEntryUpdateMutation : Mutation<TimeEntryUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeEntryUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TimeEntryUpdateMutation(TimeEntryUpdateInput data, TimeEntryQuery query)
            : base("timeEntryUpdate", "TimeEntryUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "timeEntry")))
        {
        }
    }
}
