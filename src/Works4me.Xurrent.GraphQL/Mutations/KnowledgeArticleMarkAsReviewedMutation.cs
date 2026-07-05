namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Marks the knowledge article as reviewed.
    /// </summary>
    internal sealed class KnowledgeArticleMarkAsReviewedMutation : Mutation<KnowledgeArticleMarkAsReviewedInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeArticleMarkAsReviewedMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the knowledge article mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal KnowledgeArticleMarkAsReviewedMutation(KnowledgeArticleMarkAsReviewedInput data, KnowledgeArticleQuery? query)
            : base("knowledgeArticleMarkAsReviewed", "KnowledgeArticleMarkAsReviewedInput!", data, query is null ? new KnowledgeArticleMarkAsReviewedPayloadQuery() : new KnowledgeArticleMarkAsReviewedPayloadQuery().Select(UpdateQuery(query, "knowledgeArticle")))
        {
        }
    }
}
