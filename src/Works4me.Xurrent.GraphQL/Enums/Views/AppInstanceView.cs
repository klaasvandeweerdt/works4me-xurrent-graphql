using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on AppInstances.
    /// </summary>
    public enum AppInstanceView
    {
        /// <summary>
        /// App Instances.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All AppInstances which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
