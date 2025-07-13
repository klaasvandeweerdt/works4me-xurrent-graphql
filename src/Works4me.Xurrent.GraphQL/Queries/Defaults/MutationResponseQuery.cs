using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represents a query for selecting fields from a GraphQL mutation response payload.
    /// </summary>
    internal sealed class MutationResponseQuery : Query<MutationPayload, MutationResponseQuery, DefaultView, MutationResponseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="MutationResponseQuery"/> instance.
        /// </summary>
        public MutationResponseQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// Adds a sub-query for a nested object field in the mutation response payload.
        /// </summary>
        /// <param name="query">The <see cref="IQuery"/> representing the nested object to include in the response.</param>
        /// <returns>The same <see cref="MutationResponseQuery"/>, updated to include the new sub-query.</returns>
        public MutationResponseQuery Select(IQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select(query.Name, query, false);
        }
    }
}
