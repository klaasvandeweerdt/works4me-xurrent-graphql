using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ProjectTasks.
    /// </summary>
    public enum ProjectTaskView
    {
        /// <summary>
        /// All Project Tasks.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived Project Tasks.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// Project Tasks Assigned to Me.
        /// </summary>
        [XurrentEnum("assigned_to_me")]
        AssignedToMe,

        /// <summary>
        /// All ProjectTasks which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Project Tasks Managed by Me.
        /// </summary>
        [XurrentEnum("managed_by_me")]
        ManagedByMe,

        /// <summary>
        /// Trashed Project Tasks.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
