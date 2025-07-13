using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ProjectTemplates.
    /// </summary>
    public enum ProjectTemplateView
    {
        /// <summary>
        /// Project Templates.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ProjectTemplates which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
