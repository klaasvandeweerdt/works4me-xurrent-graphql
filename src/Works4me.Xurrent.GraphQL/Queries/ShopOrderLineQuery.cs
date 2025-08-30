using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ShopOrderLine"/> query class.
    /// </summary>
    public class ShopOrderLineQuery : Query<ShopOrderLine, ShopOrderLineQuery, ShopOrderLineView, ShopOrderLineField, ShopOrderLineFilterField, ShopOrderLineOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ShopOrderLineQuery"/> instance.
        /// </summary>
        public ShopOrderLineQuery() : base("shopOrderLines", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "Account" sub-query.</returns>
        public ShopOrderLineQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        /// <param name="query">The addresses query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "Addresses" sub-query.</returns>
        public ShopOrderLineQuery SelectAddresses(AddressQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("addresses", query, true);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public ShopOrderLineQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public ShopOrderLineQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// The fulfillment request that is assigned to the provider to fulfil this shop order line.
        /// </summary>
        /// <param name="query">The fulfillment request query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "FulfillmentRequest" sub-query.</returns>
        public ShopOrderLineQuery SelectFulfillmentRequest(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("fulfillmentRequest", query, false);
        }

        /// <summary>
        /// The fulfillment task of the purchase workflow generated to fulfil this shop order line.
        /// </summary>
        /// <param name="query">The fulfillment task query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "FulfillmentTask" sub-query.</returns>
        public ShopOrderLineQuery SelectFulfillmentTask(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("fulfillmentTask", query, false);
        }

        /// <summary>
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        /// <param name="query">The fulfillment template query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "FulfillmentTemplate" sub-query.</returns>
        public ShopOrderLineQuery SelectFulfillmentTemplate(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("fulfillmentTemplate", query, false);
        }

        /// <summary>
        /// The request for purchase that includes this shop order line.
        /// </summary>
        /// <param name="query">The order query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "Order" sub-query.</returns>
        public ShopOrderLineQuery SelectOrder(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("order", query, false);
        }

        /// <summary>
        /// Information from the provider.
        /// </summary>
        /// <param name="query">The provider order line query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "ProviderOrderLine" sub-query.</returns>
        public ShopOrderLineQuery SelectProviderOrderLine(ProviderShopOrderLineQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("providerOrderLine", query, false);
        }

        /// <summary>
        /// The person creating the shop order line.
        /// </summary>
        /// <param name="query">The requested by query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "RequestedBy" sub-query.</returns>
        public ShopOrderLineQuery SelectRequestedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestedBy", query, false);
        }

        /// <summary>
        /// The person for whom the shop order line was submitted.
        /// </summary>
        /// <param name="query">The requested for query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "RequestedFor" sub-query.</returns>
        public ShopOrderLineQuery SelectRequestedFor(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestedFor", query, false);
        }

        /// <summary>
        /// The shop article that is ordered.
        /// </summary>
        /// <param name="query">The shop article query.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery"/>, updated to include the "ShopArticle" sub-query.</returns>
        public ShopOrderLineQuery SelectShopArticle(ShopArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("shopArticle", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ShopOrderLineQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ShopOrderLineQuery">ShopOrderLineQuery</see>, updated to include the "Search" sub-query.</returns>
        public ShopOrderLineQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
