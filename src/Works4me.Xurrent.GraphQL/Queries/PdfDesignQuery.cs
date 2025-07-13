using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="PdfDesign"/> query class.
    /// </summary>
    public class PdfDesignQuery : Query<PdfDesign, PdfDesignQuery, DefaultView, PdfDesignField, PdfDesignFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="PdfDesignQuery"/> instance.
        /// </summary>
        public PdfDesignQuery() : base("pdfDesigns", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="PdfDesignQuery"/>, updated to include the "Account" sub-query.</returns>
        public PdfDesignQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="PdfDesignQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public PdfDesignQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="PdfDesignQuery"/>, updated to include the "Translations" sub-query.</returns>
        public PdfDesignQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }
    }
}
