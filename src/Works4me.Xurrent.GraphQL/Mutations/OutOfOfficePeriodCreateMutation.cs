namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new out of office period.
    /// </summary>
    internal sealed class OutOfOfficePeriodCreateMutation : Mutation<OutOfOfficePeriodCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfOfficePeriodCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the out of office period mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal OutOfOfficePeriodCreateMutation(OutOfOfficePeriodCreateInput data, OutOfOfficePeriodQuery query)
            : base("outOfOfficePeriodCreate", "OutOfOfficePeriodCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "outOfOfficePeriod")))
        {
        }
    }
}
