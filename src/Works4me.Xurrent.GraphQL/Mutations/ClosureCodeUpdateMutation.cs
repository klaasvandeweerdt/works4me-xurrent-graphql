namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing closure code.
    /// </summary>
    internal sealed class ClosureCodeUpdateMutation : Mutation<ClosureCodeUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClosureCodeUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ClosureCodeUpdateMutation(ClosureCodeUpdateInput data, ClosureCodeQuery query)
            : base("closureCodeUpdate", "ClosureCodeUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "closureCode")))
        {
        }
    }
}
