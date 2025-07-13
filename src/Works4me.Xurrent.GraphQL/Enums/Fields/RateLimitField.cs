using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RateLimit">RateLimit</see> fields.
    /// </summary>
    public enum RateLimitField
    {
        /// <summary>
        /// The cost field.
        /// </summary>
        [XurrentEnum("cost")]
        Cost,

        /// <summary>
        /// The limit field.
        /// </summary>
        [XurrentEnum("limit")]
        Limit,

        /// <summary>
        /// The remaining field.
        /// </summary>
        [XurrentEnum("remaining")]
        Remaining,

        /// <summary>
        /// The reset at field.
        /// </summary>
        [XurrentEnum("resetAt")]
        ResetAt
    }
}
