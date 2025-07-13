namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing problem.
    /// </summary>
    internal sealed class ProblemUpdateMutation : Mutation<ProblemUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProblemUpdateMutation(ProblemUpdateInput data, ProblemQuery query)
            : base("problemUpdate", "ProblemUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "problem")))
        {
        }
    }
}
