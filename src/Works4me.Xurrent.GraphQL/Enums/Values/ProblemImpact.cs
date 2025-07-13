using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The problem impact values.
    /// </summary>
    public enum ProblemImpact
    {
        /// <summary>
        /// High degrades service for several users.
        /// </summary>
        [XurrentEnum("high")]
        High,

        /// <summary>
        /// Low degrades service for one user.
        /// </summary>
        [XurrentEnum("low")]
        Low,

        /// <summary>
        /// Medium brings service down for one user.
        /// </summary>
        [XurrentEnum("medium")]
        Medium,

        /// <summary>
        /// None does not degrade service.
        /// </summary>
        [XurrentEnum("none")]
        None,

        /// <summary>
        /// Top brings service down for several users.
        /// </summary>
        [XurrentEnum("top")]
        Top
    }
}
