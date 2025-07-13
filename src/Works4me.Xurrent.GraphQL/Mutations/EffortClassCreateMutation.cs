namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new effort class.
    /// </summary>
    internal sealed class EffortClassCreateMutation : Mutation<EffortClassCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffortClassCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the effort class mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal EffortClassCreateMutation(EffortClassCreateInput data, EffortClassQuery query)
            : base("effortClassCreate", "EffortClassCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "effortClass")))
        {
        }
    }
}
