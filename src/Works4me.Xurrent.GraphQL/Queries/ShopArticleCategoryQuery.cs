using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ShopArticleCategory"/> query class.
    /// </summary>
    public class ShopArticleCategoryQuery : Query<ShopArticleCategory, ShopArticleCategoryQuery, ShopArticleCategoryView, ShopArticleCategoryField, ShopArticleCategoryFilterField, ShopArticleCategoryOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ShopArticleCategoryQuery"/> instance.
        /// </summary>
        public ShopArticleCategoryQuery() : base("shopArticleCategories", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ShopArticleCategoryQuery"/>, updated to include the "Account" sub-query.</returns>
        public ShopArticleCategoryQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The attachments used in the <c>fullDescription</c> field.
        /// </summary>
        /// <param name="query">The full description attachments query.</param>
        /// <returns>The same <see cref="ShopArticleCategoryQuery"/>, updated to include the "FullDescriptionAttachments" sub-query.</returns>
        public ShopArticleCategoryQuery SelectFullDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("fullDescriptionAttachments", query, true);
        }

        /// <summary>
        /// The category's parent category.
        /// </summary>
        /// <param name="query">The parent query.</param>
        /// <returns>The same <see cref="ShopArticleCategoryQuery"/>, updated to include the "Parent" sub-query.</returns>
        public ShopArticleCategoryQuery SelectParent(ShopArticleCategoryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("parent", query, false);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="ShopArticleCategoryQuery"/>, updated to include the "Translations" sub-query.</returns>
        public ShopArticleCategoryQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ShopArticleCategoryQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ShopArticleCategoryQuery">ShopArticleCategoryQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public ShopArticleCategoryQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
