using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The workflow status values.
    /// </summary>
    public enum WorkflowStatus
    {
        /// <summary>
        /// Being created.
        /// </summary>
        [XurrentEnum("being_created")]
        BeingCreated,

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
        /// Progress halted.
        /// </summary>
        [XurrentEnum("progress_halted")]
        ProgressHalted,

        /// <summary>
        /// Registered.
        /// </summary>
        [XurrentEnum("registered")]
        Registered
    }
}
