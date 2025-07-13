using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/knowledgearticleupdatepayload/">KnowledgeArticleUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class KnowledgeArticleUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("knowledgeArticle", IsDefaultQueryProperty = true)]
        public KnowledgeArticle? KnowledgeArticle { get; internal set; }
    }
}
