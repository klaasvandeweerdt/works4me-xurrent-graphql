using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Tasks.
    /// </summary>
    public enum WorkflowTaskView
    {
        /// <summary>
        /// All Tasks.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived Tasks.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// Tasks Assigned to Me.
        /// </summary>
        [XurrentEnum("assigned_to_me")]
        AssignedToMe,

        /// <summary>
        /// Tasks Assigned to My Team.
        /// </summary>
        [XurrentEnum("assigned_to_my_team")]
        AssignedToMyTeam,

        /// <summary>
        /// All Tasks which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Tasks Managed by Me.
        /// </summary>
        [XurrentEnum("managed_by_me")]
        ManagedByMe,

        /// <summary>
        /// Trashed Tasks.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
