using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Problems.
    /// </summary>
    public enum ProblemView
    {
        /// <summary>
        /// All Problems.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived Problems.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// Problems Assigned to Me.
        /// </summary>
        [XurrentEnum("assigned_to_me")]
        AssignedToMe,

        /// <summary>
        /// Problems Assigned to My Team.
        /// </summary>
        [XurrentEnum("assigned_to_my_team")]
        AssignedToMyTeam,

        /// <summary>
        /// All Problems which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Problems Managed by Me.
        /// </summary>
        [XurrentEnum("managed_by_me")]
        ManagedByMe,

        /// <summary>
        /// Trashed Problems.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
