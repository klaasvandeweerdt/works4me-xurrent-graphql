namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing knowledge article.
    /// </summary>
    internal sealed class KnowledgeArticleUpdateMutation : Mutation<KnowledgeArticleUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeArticleUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal KnowledgeArticleUpdateMutation(KnowledgeArticleUpdateInput data, KnowledgeArticleQuery query)
            : base("knowledgeArticleUpdate", "KnowledgeArticleUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "knowledgeArticle")))
        {
        }
    }
}
