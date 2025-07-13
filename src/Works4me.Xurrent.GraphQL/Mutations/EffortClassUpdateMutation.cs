namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing effort class.
    /// </summary>
    internal sealed class EffortClassUpdateMutation : Mutation<EffortClassUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffortClassUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal EffortClassUpdateMutation(EffortClassUpdateInput data, EffortClassQuery query)
            : base("effortClassUpdate", "EffortClassUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "effortClass")))
        {
        }
    }
}
