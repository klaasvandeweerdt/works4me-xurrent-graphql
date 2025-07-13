using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Sprints.
    /// </summary>
    public enum SprintView
    {
        /// <summary>
        /// Sprints.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Sprints which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
