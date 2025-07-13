namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new closure code.
    /// </summary>
    internal sealed class ClosureCodeCreateMutation : Mutation<ClosureCodeCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClosureCodeCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the closure code mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ClosureCodeCreateMutation(ClosureCodeCreateInput data, ClosureCodeQuery query)
            : base("closureCodeCreate", "ClosureCodeCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "closureCode")))
        {
        }
    }
}
