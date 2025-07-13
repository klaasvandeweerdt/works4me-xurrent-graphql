using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RateLimit"/> query class.
    /// </summary>
    public class RateLimitQuery : Query<RateLimit, RateLimitQuery, DefaultView, RateLimitField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="RateLimitQuery"/> instance.
        /// </summary>
        public RateLimitQuery() : base("rateLimit", false)
        {
        }
    }
}
