namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new time entry.
    /// </summary>
    internal sealed class TimeEntryCreateMutation : Mutation<TimeEntryCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeEntryCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the time entry mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TimeEntryCreateMutation(TimeEntryCreateInput data, TimeEntryQuery query)
            : base("timeEntryCreate", "TimeEntryCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "timeEntry")))
        {
        }
    }
}
