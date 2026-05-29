using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The golden set item status values.
    /// </summary>
    public enum GoldenSetItemStatus
    {
        /// <summary>
        /// Completed.
        /// </summary>
        [XurrentEnum("completed")]
        Completed,

        /// <summary>
        /// Failed.
        /// </summary>
        [XurrentEnum("failed")]
        Failed,

        /// <summary>
        /// Pending.
        /// </summary>
        [XurrentEnum("pending")]
        Pending,

        /// <summary>
        /// Queued.
        /// </summary>
        [XurrentEnum("queued")]
        Queued,

        /// <summary>
        /// Running.
        /// </summary>
        [XurrentEnum("running")]
        Running
    }
}
