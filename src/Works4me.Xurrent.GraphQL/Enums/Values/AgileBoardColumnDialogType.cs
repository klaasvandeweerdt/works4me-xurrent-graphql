using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The agile board column dialog type values.
    /// </summary>
    public enum AgileBoardColumnDialogType
    {
        /// <summary>
        /// Full.
        /// </summary>
        [XurrentEnum("full")]
        Full,

        /// <summary>
        /// Minimal.
        /// </summary>
        [XurrentEnum("minimal")]
        Minimal,

        /// <summary>
        /// None.
        /// </summary>
        [XurrentEnum("none")]
        None
    }
}
