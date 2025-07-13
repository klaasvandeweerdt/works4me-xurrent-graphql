using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The workflow category values.
    /// </summary>
    public enum WorkflowCategory
    {
        /// <summary>
        /// Emergency required for incident resolution.
        /// </summary>
        [XurrentEnum("emergency")]
        Emergency,

        /// <summary>
        /// Non standard approved workflow template not available.
        /// </summary>
        [XurrentEnum("non_standard")]
        NonStandard,

        /// <summary>
        /// Order organization order workflow.
        /// </summary>
        [XurrentEnum("order")]
        Order,

        /// <summary>
        /// Standard approved workflow template was used.
        /// </summary>
        [XurrentEnum("standard")]
        Standard
    }
}
