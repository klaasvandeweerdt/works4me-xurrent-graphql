using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Account">Account</see> fields.
    /// </summary>
    public enum AccountField
    {
        /// <summary>
        /// The design field.
        /// </summary>
        [XurrentEnum("design")]
        Design,

        /// <summary>
        /// The directory field.
        /// </summary>
        [XurrentEnum("directory")]
        Directory,

        /// <summary>
        /// The directory account field.
        /// </summary>
        [XurrentEnum("directoryAccount")]
        DirectoryAccount,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The organization field.
        /// </summary>
        [XurrentEnum("organization")]
        Organization,

        /// <summary>
        /// The url field.
        /// </summary>
        [XurrentEnum("url")]
        Url
    }
}
