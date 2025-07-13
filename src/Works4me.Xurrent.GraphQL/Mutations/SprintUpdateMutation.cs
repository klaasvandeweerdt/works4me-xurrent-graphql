namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing sprint.
    /// </summary>
    internal sealed class SprintUpdateMutation : Mutation<SprintUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SprintUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SprintUpdateMutation(SprintUpdateInput data, SprintQuery query)
            : base("sprintUpdate", "SprintUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "sprint")))
        {
        }
    }
}
