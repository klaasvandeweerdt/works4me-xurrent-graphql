using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on People.
    /// </summary>
    public enum PersonView
    {
        /// <summary>
        /// All People.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All People with Roles.
        /// </summary>
        [XurrentEnum("all_with_roles")]
        AllWithRoles,

        /// <summary>
        /// Archived People.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// All People which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Trashed People.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
