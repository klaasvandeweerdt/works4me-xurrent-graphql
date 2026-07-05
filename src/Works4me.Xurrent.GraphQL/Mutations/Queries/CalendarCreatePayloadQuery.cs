using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represents a GraphQL response selection query.
    /// </summary>
    internal sealed class CalendarCreatePayloadQuery : Query<CalendarCreatePayload, CalendarCreatePayloadQuery, DefaultView, MutationResponseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarCreatePayloadQuery"/> class.
        /// </summary>
        public CalendarCreatePayloadQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// Adds a sub-query for a nested object field in the calendar create payload response query.
        /// </summary>
        /// <param name="query">The <see cref="IQuery"/> representing the nested object field to include in the response.</param>
        /// <returns>The current <see cref="CalendarCreatePayloadQuery"/> instance.</returns>
        public CalendarCreatePayloadQuery Select(IQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select(query.Name, query, false);
        }
    }
}
