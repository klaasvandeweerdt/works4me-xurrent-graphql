using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Translation records are returned.
    /// </summary>
    public enum TranslationFilterField
    {
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Include only if Disabled matches supplied value.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Filter on Field.
        /// </summary>
        [XurrentEnum("field")]
        Field,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Language.
        /// </summary>
        [XurrentEnum("language")]
        Language,

        /// <summary>
        /// Filter on Record.
        /// </summary>
        [XurrentEnum("owner")]
        Owner,

        /// <summary>
        /// Filter on Type.
        /// </summary>
        [XurrentEnum("type")]
        Type,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
