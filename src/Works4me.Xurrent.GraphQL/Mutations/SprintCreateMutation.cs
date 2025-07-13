namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new sprint.
    /// </summary>
    internal sealed class SprintCreateMutation : Mutation<SprintCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SprintCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the sprint mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SprintCreateMutation(SprintCreateInput data, SprintQuery query)
            : base("sprintCreate", "SprintCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "sprint")))
        {
        }
    }
}
