using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on KnowledgeArticleTemplates.
    /// </summary>
    public enum KnowledgeArticleTemplateView
    {
        /// <summary>
        /// Knowledge Article Templates.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All KnowledgeArticleTemplates which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
