namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing time allocation.
    /// </summary>
    internal sealed class TimeAllocationUpdateMutation : Mutation<TimeAllocationUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeAllocationUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TimeAllocationUpdateMutation(TimeAllocationUpdateInput data, TimeAllocationQuery query)
            : base("timeAllocationUpdate", "TimeAllocationUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "timeAllocation")))
        {
        }
    }
}
