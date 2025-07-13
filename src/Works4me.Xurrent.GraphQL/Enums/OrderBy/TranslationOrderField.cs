using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Translation can be ordered on.
    /// </summary>
    public enum TranslationOrderField
    {
        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Field</c>.
        /// </summary>
        [XurrentEnum("field")]
        Field,

        /// <summary>
        /// Order by <c>Language</c>.
        /// </summary>
        [XurrentEnum("language")]
        Language,

        /// <summary>
        /// Order by <c>Text</c>.
        /// </summary>
        [XurrentEnum("text")]
        Text,

        /// <summary>
        /// Order by <c>Type</c>.
        /// </summary>
        [XurrentEnum("type")]
        Type,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
