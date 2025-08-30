using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProductCategory"/> query class.
    /// </summary>
    public class ProductCategoryQuery : Query<ProductCategory, ProductCategoryQuery, ProductCategoryView, ProductCategoryField, ProductCategoryFilterField, ProductCategoryOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProductCategoryQuery"/> instance.
        /// </summary>
        public ProductCategoryQuery() : base("productCategories", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ProductCategoryQuery"/>, updated to include the "Account" sub-query.</returns>
        public ProductCategoryQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Products in this category.
        /// </summary>
        /// <param name="query">The products query.</param>
        /// <returns>The same <see cref="ProductCategoryQuery"/>, updated to include the "Products" sub-query.</returns>
        public ProductCategoryQuery SelectProducts(ProductQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("products", query, true);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="ProductCategoryQuery"/>, updated to include the "Translations" sub-query.</returns>
        public ProductCategoryQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// UI extension that is linked to the product category.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="ProductCategoryQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public ProductCategoryQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ProductCategoryQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ProductCategoryQuery">ProductCategoryQuery</see>, updated to include the "Search" sub-query.</returns>
        public ProductCategoryQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
