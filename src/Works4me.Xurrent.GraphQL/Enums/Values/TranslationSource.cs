using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The translation source values.
    /// </summary>
    public enum TranslationSource
    {
        /// <summary>
        /// A machine (auto) translation.
        /// </summary>
        [XurrentEnum("AUTO")]
        Auto,

        /// <summary>
        /// A fresh human-authored translation.
        /// </summary>
        [XurrentEnum("MANUAL")]
        Manual,

        /// <summary>
        /// The source-language content.
        /// </summary>
        [XurrentEnum("SOURCE")]
        Source
    }
}
