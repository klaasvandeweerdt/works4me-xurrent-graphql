namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new holiday.
    /// </summary>
    internal sealed class HolidayCreateMutation : Mutation<HolidayCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HolidayCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal HolidayCreateMutation(HolidayCreateInput data, HolidayQuery query)
            : base("holidayCreate", "HolidayCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "holiday")))
        {
        }
    }
}
