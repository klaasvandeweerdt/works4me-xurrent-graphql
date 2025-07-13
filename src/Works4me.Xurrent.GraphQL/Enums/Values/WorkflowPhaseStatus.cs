using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The workflow phase status values.
    /// </summary>
    public enum WorkflowPhaseStatus
    {
        /// <summary>
        /// Completed.
        /// </summary>
        [XurrentEnum("completed")]
        Completed,

        /// <summary>
        /// In progress.
        /// </summary>
        [XurrentEnum("in_progress")]
        InProgress,

        /// <summary>
        /// Registered.
        /// </summary>
        [XurrentEnum("registered")]
        Registered
    }
}
