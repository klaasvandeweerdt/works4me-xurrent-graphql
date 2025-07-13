namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new knowledge article.
    /// </summary>
    internal sealed class KnowledgeArticleCreateMutation : Mutation<KnowledgeArticleCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeArticleCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal KnowledgeArticleCreateMutation(KnowledgeArticleCreateInput data, KnowledgeArticleQuery query)
            : base("knowledgeArticleCreate", "KnowledgeArticleCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "knowledgeArticle")))
        {
        }
    }
}
