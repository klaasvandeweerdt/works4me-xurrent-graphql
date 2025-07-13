namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing holiday.
    /// </summary>
    internal sealed class HolidayUpdateMutation : Mutation<HolidayUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HolidayUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the holiday mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal HolidayUpdateMutation(HolidayUpdateInput data, HolidayQuery query)
            : base("holidayUpdate", "HolidayUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "holiday")))
        {
        }
    }
}
