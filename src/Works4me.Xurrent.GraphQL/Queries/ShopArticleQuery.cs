using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ShopArticle"/> query class.
    /// </summary>
    public class ShopArticleQuery : Query<ShopArticle, ShopArticleQuery, ShopArticleView, ShopArticleField, ShopArticleFilterField, ShopArticleOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ShopArticleQuery"/> instance.
        /// </summary>
        public ShopArticleQuery() : base("shopArticles", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ShopArticleQuery"/>, updated to include the "Account" sub-query.</returns>
        public ShopArticleQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Calendar that represents the work hours related to the fulfillment/delivery.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>The same <see cref="ShopArticleQuery"/>, updated to include the "Calendar" sub-query.</returns>
        public ShopArticleQuery SelectCalendar(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("calendar", query, false);
        }

        /// <summary>
        /// Related category.
        /// </summary>
        /// <param name="query">The category query.</param>
        /// <returns>The same <see cref="ShopArticleQuery"/>, updated to include the "Category" sub-query.</returns>
        public ShopArticleQuery SelectCategory(ShopArticleCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("category", query, false);
        }

        /// <summary>
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        /// <param name="query">The fulfillment template query.</param>
        /// <returns>The same <see cref="ShopArticleQuery"/>, updated to include the "FulfillmentTemplate" sub-query.</returns>
        public ShopArticleQuery SelectFulfillmentTemplate(RequestTemplateQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("fulfillmentTemplate", query, false);
        }

        /// <summary>
        /// Related product.
        /// </summary>
        /// <param name="query">The product query.</param>
        /// <returns>The same <see cref="ShopArticleQuery"/>, updated to include the "Product" sub-query.</returns>
        public ShopArticleQuery SelectProduct(ProductQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("product", query, false);
        }

        /// <summary>
        /// Information from the provider.
        /// </summary>
        /// <param name="query">The provider shop article query.</param>
        /// <returns>The same <see cref="ShopArticleQuery"/>, updated to include the "ProviderShopArticle" sub-query.</returns>
        public ShopArticleQuery SelectProviderShopArticle(ProviderShopArticleQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("providerShopArticle", query, false);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="ShopArticleQuery"/>, updated to include the "Translations" sub-query.</returns>
        public ShopArticleQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// UI extension that is to be used when the shop article is ordered.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="ShopArticleQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public ShopArticleQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ShopArticleQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ShopArticleQuery">ShopArticleQuery</see>, updated to include the "Search" sub-query.</returns>
        public ShopArticleQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
