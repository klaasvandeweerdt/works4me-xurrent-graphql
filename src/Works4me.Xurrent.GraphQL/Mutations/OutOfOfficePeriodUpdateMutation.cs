namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing out of office period.
    /// </summary>
    internal sealed class OutOfOfficePeriodUpdateMutation : Mutation<OutOfOfficePeriodUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfOfficePeriodUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal OutOfOfficePeriodUpdateMutation(OutOfOfficePeriodUpdateInput data, OutOfOfficePeriodQuery query)
            : base("outOfOfficePeriodUpdate", "OutOfOfficePeriodUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "outOfOfficePeriod")))
        {
        }
    }
}
