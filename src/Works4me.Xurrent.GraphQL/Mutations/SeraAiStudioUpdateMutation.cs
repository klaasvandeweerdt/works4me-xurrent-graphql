namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing Sera AI Studio.
    /// </summary>
    internal sealed class SeraAiStudioUpdateMutation : Mutation<SeraAiStudioUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeraAiStudioUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the sera ai studio mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SeraAiStudioUpdateMutation(SeraAiStudioUpdateInput data, SeraAiStudioQuery? query)
            : base("seraAiStudioUpdate", "SeraAiStudioUpdateInput!", data, query is null ? new SeraAiStudioUpdatePayloadQuery() : new SeraAiStudioUpdatePayloadQuery().Select(UpdateQuery(query, "seraAiStudio")))
        {
        }
    }
}
