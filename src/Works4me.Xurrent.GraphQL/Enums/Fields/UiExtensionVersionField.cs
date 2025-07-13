using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="UiExtensionVersion">UiExtensionVersion</see> fields.
    /// </summary>
    public enum UiExtensionVersionField
    {
        /// <summary>
        /// The activated at field.
        /// </summary>
        [XurrentEnum("activatedAt")]
        ActivatedAt,

        /// <summary>
        /// The archived at field.
        /// </summary>
        [XurrentEnum("archivedAt")]
        ArchivedAt,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The css field.
        /// </summary>
        [XurrentEnum("css")]
        Css,

        /// <summary>
        /// The form definition field.
        /// </summary>
        [XurrentEnum("formDefinition")]
        FormDefinition,

        /// <summary>
        /// The html field.
        /// </summary>
        [XurrentEnum("html")]
        Html,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The javascript field.
        /// </summary>
        [XurrentEnum("javascript")]
        Javascript,

        /// <summary>
        /// The status field.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// The ui extension field.
        /// </summary>
        [XurrentEnum("uiExtension")]
        UiExtension,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The version nr field.
        /// </summary>
        [XurrentEnum("versionNr")]
        VersionNr
    }
}
