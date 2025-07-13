using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ScrumWorkspaces.
    /// </summary>
    public enum ScrumWorkspaceView
    {
        /// <summary>
        /// Scrum Workspaces.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ScrumWorkspaces which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
