using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represents a GraphQL response selection query.
    /// </summary>
    internal sealed class FirstLineSupportAgreementUpdatePayloadQuery : Query<FirstLineSupportAgreementUpdatePayload, FirstLineSupportAgreementUpdatePayloadQuery, DefaultView, MutationResponseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstLineSupportAgreementUpdatePayloadQuery"/> class.
        /// </summary>
        public FirstLineSupportAgreementUpdatePayloadQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// Adds a sub-query for a nested object field in the first line support agreement update payload response query.
        /// </summary>
        /// <param name="query">The <see cref="IQuery"/> representing the nested object field to include in the response.</param>
        /// <returns>The current <see cref="FirstLineSupportAgreementUpdatePayloadQuery"/> instance.</returns>
        public FirstLineSupportAgreementUpdatePayloadQuery Select(IQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select(query.Name, query, false);
        }
    }
}
