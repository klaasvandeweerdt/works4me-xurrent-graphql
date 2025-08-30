using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="UiExtension"/> query class.
    /// </summary>
    public class UiExtensionQuery : Query<UiExtension, UiExtensionQuery, UiExtensionView, UiExtensionField, UiExtensionFilterField, UiExtensionOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="UiExtensionQuery"/> instance.
        /// </summary>
        public UiExtensionQuery() : base("uiExtensions", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="UiExtensionQuery"/>, updated to include the "Account" sub-query.</returns>
        public UiExtensionQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The version with Status <c>active</c>.
        /// </summary>
        /// <param name="query">The active version query.</param>
        /// <returns>The same <see cref="UiExtensionQuery"/>, updated to include the "ActiveVersion" sub-query.</returns>
        public UiExtensionQuery SelectActiveVersion(UiExtensionVersionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("activeVersion", query, false);
        }

        /// <summary>
        /// The person who created the UI extension.
        /// </summary>
        /// <param name="query">The created by query.</param>
        /// <returns>The same <see cref="UiExtensionQuery"/>, updated to include the "CreatedBy" sub-query.</returns>
        public UiExtensionQuery SelectCreatedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("createdBy", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="UiExtensionQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public UiExtensionQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="UiExtensionQuery"/>, updated to include the "Translations" sub-query.</returns>
        public UiExtensionQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// The person who last updated the UI extension.
        /// </summary>
        /// <param name="query">The updated by query.</param>
        /// <returns>The same <see cref="UiExtensionQuery"/>, updated to include the "UpdatedBy" sub-query.</returns>
        public UiExtensionQuery SelectUpdatedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("updatedBy", query, false);
        }

        /// <summary>
        /// Versions of the UI extension.
        /// </summary>
        /// <param name="query">The versions query.</param>
        /// <returns>The same <see cref="UiExtensionQuery"/>, updated to include the "Versions" sub-query.</returns>
        public UiExtensionQuery SelectVersions(UiExtensionVersionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("versions", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="UiExtensionQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="UiExtensionQuery">UiExtensionQuery</see>, updated to include the "Search" sub-query.</returns>
        public UiExtensionQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
