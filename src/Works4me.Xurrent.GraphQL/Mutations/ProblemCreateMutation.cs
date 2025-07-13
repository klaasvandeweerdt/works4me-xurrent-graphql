namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new problem.
    /// </summary>
    internal sealed class ProblemCreateMutation : Mutation<ProblemCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the problem mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ProblemCreateMutation(ProblemCreateInput data, ProblemQuery query)
            : base("problemCreate", "ProblemCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "problem")))
        {
        }
    }
}
