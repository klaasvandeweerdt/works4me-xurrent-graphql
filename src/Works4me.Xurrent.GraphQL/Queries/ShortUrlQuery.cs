using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ShortUrl"/> query class.
    /// </summary>
    public class ShortUrlQuery : Query<ShortUrl, ShortUrlQuery, ShortUrlView, ShortUrlField, ShortUrlFilterField, ShortUrlOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ShortUrlQuery"/> instance.
        /// </summary>
        public ShortUrlQuery() : base("shortUrls", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ShortUrlQuery"/>, updated to include the "Account" sub-query.</returns>
        public ShortUrlQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ShortUrlQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ShortUrlQuery">ShortUrlQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public ShortUrlQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
