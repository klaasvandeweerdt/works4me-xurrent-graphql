using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Tag"/> query class.
    /// </summary>
    public class TagQuery : Query<Tag, TagQuery, DefaultView, TagField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TagQuery"/> instance.
        /// </summary>
        public TagQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="TagQuery"/>, updated to include the "Account" sub-query.</returns>
        public TagQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }
    }
}
