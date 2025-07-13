using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Permission">Permission</see> fields.
    /// </summary>
    public enum PermissionField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The roles field.
        /// </summary>
        [XurrentEnum("roles")]
        Roles
    }
}
