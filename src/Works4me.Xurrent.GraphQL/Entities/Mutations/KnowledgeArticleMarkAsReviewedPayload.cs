using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/knowledgearticlemarkasreviewedpayload/">KnowledgeArticleMarkAsReviewedPayload</see> in Xurrent.
    /// </summary>
    public sealed class KnowledgeArticleMarkAsReviewedPayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("knowledgeArticle")]
        public KnowledgeArticle? KnowledgeArticle { get; internal set; }
    }
}
