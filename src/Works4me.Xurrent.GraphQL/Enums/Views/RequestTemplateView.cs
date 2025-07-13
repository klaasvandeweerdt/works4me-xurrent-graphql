using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on RequestTemplates.
    /// </summary>
    public enum RequestTemplateView
    {
        /// <summary>
        /// Request Templates.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All RequestTemplates which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
