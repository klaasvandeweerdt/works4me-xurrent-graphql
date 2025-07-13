using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The problem category values.
    /// </summary>
    public enum ProblemCategory
    {
        /// <summary>
        /// Proactive anticipated problem.
        /// </summary>
        [XurrentEnum("proactive")]
        Proactive,

        /// <summary>
        /// Reactive existing problem.
        /// </summary>
        [XurrentEnum("reactive")]
        Reactive
    }
}
