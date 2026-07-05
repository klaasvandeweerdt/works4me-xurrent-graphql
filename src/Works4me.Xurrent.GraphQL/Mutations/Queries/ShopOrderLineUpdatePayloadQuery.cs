using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represents a GraphQL response selection query.
    /// </summary>
    internal sealed class ShopOrderLineUpdatePayloadQuery : Query<ShopOrderLineUpdatePayload, ShopOrderLineUpdatePayloadQuery, DefaultView, MutationResponseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopOrderLineUpdatePayloadQuery"/> class.
        /// </summary>
        public ShopOrderLineUpdatePayloadQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// Adds a sub-query for a nested object field in the shop order line update payload response query.
        /// </summary>
        /// <param name="query">The <see cref="IQuery"/> representing the nested object field to include in the response.</param>
        /// <returns>The current <see cref="ShopOrderLineUpdatePayloadQuery"/> instance.</returns>
        public ShopOrderLineUpdatePayloadQuery Select(IQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select(query.Name, query, false);
        }
    }
}
