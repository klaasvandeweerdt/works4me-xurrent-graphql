using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represents a GraphQL response selection query.
    /// </summary>
    internal sealed class GoldenSetItemDeleteMutationPayloadQuery : Query<GoldenSetItemDeleteMutationPayload, GoldenSetItemDeleteMutationPayloadQuery, DefaultView, MutationResponseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldenSetItemDeleteMutationPayloadQuery"/> class.
        /// </summary>
        public GoldenSetItemDeleteMutationPayloadQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// Adds a sub-query for a nested object field in the golden set item delete mutation payload response query.
        /// </summary>
        /// <param name="query">The <see cref="IQuery"/> representing the nested object field to include in the response.</param>
        /// <returns>The current <see cref="GoldenSetItemDeleteMutationPayloadQuery"/> instance.</returns>
        public GoldenSetItemDeleteMutationPayloadQuery Select(IQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select(query.Name, query, false);
        }
    }
}
