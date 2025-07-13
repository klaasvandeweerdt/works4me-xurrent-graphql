using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The agile board column action type values.
    /// </summary>
    public enum AgileBoardColumnActionType
    {
        /// <summary>
        /// Accept.
        /// </summary>
        [XurrentEnum("accept")]
        Accept,

        /// <summary>
        /// Assign.
        /// </summary>
        [XurrentEnum("assign")]
        Assign,

        /// <summary>
        /// Complete.
        /// </summary>
        [XurrentEnum("complete")]
        Complete,

        /// <summary>
        /// None.
        /// </summary>
        [XurrentEnum("none")]
        None,

        /// <summary>
        /// Start.
        /// </summary>
        [XurrentEnum("start")]
        Start
    }
}
