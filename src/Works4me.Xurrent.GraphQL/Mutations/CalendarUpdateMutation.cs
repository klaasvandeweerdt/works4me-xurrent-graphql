namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing calendar.
    /// </summary>
    internal sealed class CalendarUpdateMutation : Mutation<CalendarUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal CalendarUpdateMutation(CalendarUpdateInput data, CalendarQuery query)
            : base("calendarUpdate", "CalendarUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "calendar")))
        {
        }
    }
}
