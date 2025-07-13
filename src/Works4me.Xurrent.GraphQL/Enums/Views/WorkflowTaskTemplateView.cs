using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on TaskTemplates.
    /// </summary>
    public enum WorkflowTaskTemplateView
    {
        /// <summary>
        /// Task Templates.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All TaskTemplates which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
