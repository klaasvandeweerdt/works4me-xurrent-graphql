using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Watch"/> query class.
    /// </summary>
    public class WatchQuery : Query<Watch, WatchQuery, DefaultView, WatchField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WatchQuery"/> instance.
        /// </summary>
        public WatchQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The person who added this watch.
        /// </summary>
        /// <param name="query">The added by query.</param>
        /// <returns>The same <see cref="WatchQuery"/>, updated to include the "AddedBy" sub-query.</returns>
        public WatchQuery SelectAddedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("addedBy", query, false);
        }

        /// <summary>
        /// The person who is watching the record.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>The same <see cref="WatchQuery"/>, updated to include the "Person" sub-query.</returns>
        public WatchQuery SelectPerson(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("person", query, false);
        }
    }
}
