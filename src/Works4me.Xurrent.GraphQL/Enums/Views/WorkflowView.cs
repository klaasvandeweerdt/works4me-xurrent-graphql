using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Workflows.
    /// </summary>
    public enum WorkflowView
    {
        /// <summary>
        /// All Workflows.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived Workflows.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// All Workflows which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Workflows Managed by Me.
        /// </summary>
        [XurrentEnum("managed_by_me")]
        ManagedByMe,

        /// <summary>
        /// Workflows for My Team's Services.
        /// </summary>
        [XurrentEnum("my_teams_services")]
        MyTeamsServices,

        /// <summary>
        /// Trashed Workflows.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
