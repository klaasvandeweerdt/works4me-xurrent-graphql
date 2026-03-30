using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RfcType"/> query class.
    /// </summary>
    public class RfcTypeQuery : Query<RfcType, RfcTypeQuery, DefaultView, RfcTypeField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="RfcTypeQuery"/> instance.
        /// </summary>
        public RfcTypeQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="RfcTypeQuery"/>, updated to include the "Account" sub-query.</returns>
        public RfcTypeQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        /// <param name="query">The information attachments query.</param>
        /// <returns>The same <see cref="RfcTypeQuery"/>, updated to include the "InformationAttachments" sub-query.</returns>
        public RfcTypeQuery SelectInformationAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("informationAttachments", query, true);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="RfcTypeQuery"/>, updated to include the "Translations" sub-query.</returns>
        public RfcTypeQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }
    }
}
