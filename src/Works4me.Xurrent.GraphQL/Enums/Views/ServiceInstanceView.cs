using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ServiceInstances.
    /// </summary>
    public enum ServiceInstanceView
    {
        /// <summary>
        /// Service Instances.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ServiceInstances which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
