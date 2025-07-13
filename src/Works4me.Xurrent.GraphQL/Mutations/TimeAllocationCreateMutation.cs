namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new time allocation.
    /// </summary>
    internal sealed class TimeAllocationCreateMutation : Mutation<TimeAllocationCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeAllocationCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the time allocation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TimeAllocationCreateMutation(TimeAllocationCreateInput data, TimeAllocationQuery query)
            : base("timeAllocationCreate", "TimeAllocationCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "timeAllocation")))
        {
        }
    }
}
