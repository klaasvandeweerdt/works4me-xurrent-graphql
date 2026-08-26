using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TranslationProvenance">TranslationProvenance</see> fields.
    /// </summary>
    public enum TranslationProvenanceField
    {
        /// <summary>
        /// The field field.
        /// </summary>
        [XurrentEnum("field")]
        Field,

        /// <summary>
        /// The locale field.
        /// </summary>
        [XurrentEnum("locale")]
        Locale,

        /// <summary>
        /// The outdated manual field.
        /// </summary>
        [XurrentEnum("outdatedManual")]
        OutdatedManual,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The translated at field.
        /// </summary>
        [XurrentEnum("translatedAt")]
        TranslatedAt
    }
}
