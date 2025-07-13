using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on WorkflowTemplates.
    /// </summary>
    public enum WorkflowTemplateView
    {
        /// <summary>
        /// Workflow Templates.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All WorkflowTemplates which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
