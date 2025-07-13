using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The feedback satisfaction values.
    /// </summary>
    public enum FeedbackSatisfaction
    {
        /// <summary>
        /// Dissatisfied.
        /// </summary>
        [XurrentEnum("dissatisfied")]
        Dissatisfied,

        /// <summary>
        /// Satisfied.
        /// </summary>
        [XurrentEnum("satisfied")]
        Satisfied
    }
}
