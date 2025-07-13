using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="CustomCollection"/> query class.
    /// </summary>
    public class CustomCollectionQuery : Query<CustomCollection, CustomCollectionQuery, DefaultView, CustomCollectionField, CustomCollectionFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="CustomCollectionQuery"/> instance.
        /// </summary>
        public CustomCollectionQuery() : base("customCollections", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="CustomCollectionQuery"/>, updated to include the "Account" sub-query.</returns>
        public CustomCollectionQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Elements of this custom collection.
        /// </summary>
        /// <param name="query">The collection elements query.</param>
        /// <returns>The same <see cref="CustomCollectionQuery"/>, updated to include the "CollectionElements" sub-query.</returns>
        public CustomCollectionQuery SelectCollectionElements(CustomCollectionElementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("collectionElements", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="CustomCollectionQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public CustomCollectionQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// UI extension that is linked to the collection.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="CustomCollectionQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public CustomCollectionQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }
    }
}
