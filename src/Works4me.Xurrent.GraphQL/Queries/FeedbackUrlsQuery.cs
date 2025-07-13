using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="FeedbackUrls"/> query class.
    /// </summary>
    public class FeedbackUrlsQuery : Query<FeedbackUrls, FeedbackUrlsQuery, DefaultView, FeedbackUrlsField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="FeedbackUrlsQuery"/> instance.
        /// </summary>
        public FeedbackUrlsQuery() : base(string.Empty, false)
        {
        }
    }
}
