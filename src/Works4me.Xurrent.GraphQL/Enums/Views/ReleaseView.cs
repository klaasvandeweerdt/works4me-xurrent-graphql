using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Releases.
    /// </summary>
    public enum ReleaseView
    {
        /// <summary>
        /// All Releases.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived Releases.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// All Releases which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Releases Managed by Me.
        /// </summary>
        [XurrentEnum("managed_by_me")]
        ManagedByMe,

        /// <summary>
        /// Trashed Releases.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
