namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new calendar.
    /// </summary>
    internal sealed class CalendarCreateMutation : Mutation<CalendarCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the calendar mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal CalendarCreateMutation(CalendarCreateInput data, CalendarQuery query)
            : base("calendarCreate", "CalendarCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "calendar")))
        {
        }
    }
}
