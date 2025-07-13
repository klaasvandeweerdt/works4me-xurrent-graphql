using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ProjectTaskTemplates.
    /// </summary>
    public enum ProjectTaskTemplateView
    {
        /// <summary>
        /// Project Task Templates.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ProjectTaskTemplates which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
