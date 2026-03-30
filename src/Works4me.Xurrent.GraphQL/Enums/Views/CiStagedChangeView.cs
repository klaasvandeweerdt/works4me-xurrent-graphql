using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on CiStagedChanges.
    /// </summary>
    public enum CiStagedChangeView
    {
        /// <summary>
        /// Review Queue.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All CiStagedChanges which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
