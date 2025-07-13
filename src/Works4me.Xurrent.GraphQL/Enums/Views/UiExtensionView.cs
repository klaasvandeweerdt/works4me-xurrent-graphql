using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on UiExtensions.
    /// </summary>
    public enum UiExtensionView
    {
        /// <summary>
        /// UI Extensions.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All UiExtensions which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
