using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ActivityID">ActivityID</see> fields.
    /// </summary>
    public enum ActivityIDField
    {
        /// <summary>
        /// The case field.
        /// </summary>
        [XurrentEnum("case")]
        Case,

        /// <summary>
        /// The high field.
        /// </summary>
        [XurrentEnum("high")]
        High,

        /// <summary>
        /// The low field.
        /// </summary>
        [XurrentEnum("low")]
        Low,

        /// <summary>
        /// The medium field.
        /// </summary>
        [XurrentEnum("medium")]
        Medium,

        /// <summary>
        /// The rfc field.
        /// </summary>
        [XurrentEnum("rfc")]
        Rfc,

        /// <summary>
        /// The rfi field.
        /// </summary>
        [XurrentEnum("rfi")]
        Rfi,

        /// <summary>
        /// The top field.
        /// </summary>
        [XurrentEnum("top")]
        Top
    }
}
