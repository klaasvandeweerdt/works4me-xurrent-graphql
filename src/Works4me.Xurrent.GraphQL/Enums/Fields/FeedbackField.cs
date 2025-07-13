using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Feedback">Feedback</see> fields.
    /// </summary>
    public enum FeedbackField
    {
        /// <summary>
        /// The requested by field.
        /// </summary>
        [XurrentEnum("requestedBy")]
        RequestedBy,

        /// <summary>
        /// The requested for field.
        /// </summary>
        [XurrentEnum("requestedFor")]
        RequestedFor
    }
}
