using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Feedback"/> query class.
    /// </summary>
    public class FeedbackQuery : Query<Feedback, FeedbackQuery, DefaultView, FeedbackField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="FeedbackQuery"/> instance.
        /// </summary>
        public FeedbackQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// URLs to capture feedback from the person who submitted the request.
        /// </summary>
        /// <param name="query">The requested by query.</param>
        /// <returns>The same <see cref="FeedbackQuery"/>, updated to include the "RequestedBy" sub-query.</returns>
        public FeedbackQuery SelectRequestedBy(FeedbackUrlsQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestedBy", query, false);
        }

        /// <summary>
        /// URLs to capture feedback from the person for whom the request was submitted, if that was not the submitter of the request.
        /// </summary>
        /// <param name="query">The requested for query.</param>
        /// <returns>The same <see cref="FeedbackQuery"/>, updated to include the "RequestedFor" sub-query.</returns>
        public FeedbackQuery SelectRequestedFor(FeedbackUrlsQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestedFor", query, false);
        }
    }
}
