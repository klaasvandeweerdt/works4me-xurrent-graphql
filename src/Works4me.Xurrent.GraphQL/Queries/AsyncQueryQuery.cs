using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AsyncQuery"/> query class.
    /// </summary>
    public class AsyncQueryQuery : Query<AsyncQuery, AsyncQueryQuery, DefaultView, AsyncQueryField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AsyncQueryQuery"/> instance.
        /// </summary>
        public AsyncQueryQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="AsyncQueryQuery"/>, updated to include the "Account" sub-query.</returns>
        public AsyncQueryQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The person or application who created the async query.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>The same <see cref="AsyncQueryQuery"/>, updated to include the "Person" sub-query.</returns>
        public AsyncQueryQuery SelectPerson(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("person", query, false);
        }
    }
}
