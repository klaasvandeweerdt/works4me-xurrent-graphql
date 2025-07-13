using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ServiceCategory"/> query class.
    /// </summary>
    public class ServiceCategoryQuery : Query<ServiceCategory, ServiceCategoryQuery, DefaultView, ServiceCategoryField, ServiceCategoryFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ServiceCategoryQuery"/> instance.
        /// </summary>
        public ServiceCategoryQuery() : base("serviceCategories", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ServiceCategoryQuery"/>, updated to include the "Account" sub-query.</returns>
        public ServiceCategoryQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="ServiceCategoryQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public ServiceCategoryQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// Services of the service category.
        /// </summary>
        /// <param name="query">The services query.</param>
        /// <returns>The same <see cref="ServiceCategoryQuery"/>, updated to include the "Services" sub-query.</returns>
        public ServiceCategoryQuery SelectServices(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("services", query, true);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="ServiceCategoryQuery"/>, updated to include the "Translations" sub-query.</returns>
        public ServiceCategoryQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }
    }
}
