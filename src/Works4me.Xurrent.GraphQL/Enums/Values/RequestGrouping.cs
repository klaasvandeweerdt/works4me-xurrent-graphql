using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The request grouping values.
    /// </summary>
    public enum RequestGrouping
    {
        /// <summary>
        /// Group.
        /// </summary>
        [XurrentEnum("group")]
        Group,

        /// <summary>
        /// Grouped.
        /// </summary>
        [XurrentEnum("grouped")]
        Grouped,

        /// <summary>
        /// None.
        /// </summary>
        [XurrentEnum("none")]
        None
    }
}
