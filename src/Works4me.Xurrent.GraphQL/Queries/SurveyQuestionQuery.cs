using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyQuestion"/> query class.
    /// </summary>
    public class SurveyQuestionQuery : Query<SurveyQuestion, SurveyQuestionQuery, DefaultView, SurveyQuestionField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SurveyQuestionQuery"/> instance.
        /// </summary>
        public SurveyQuestionQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SurveyQuestionQuery"/>, updated to include the "Account" sub-query.</returns>
        public SurveyQuestionQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Guidance field.
        /// </summary>
        /// <param name="query">The guidance attachments query.</param>
        /// <returns>The same <see cref="SurveyQuestionQuery"/>, updated to include the "GuidanceAttachments" sub-query.</returns>
        public SurveyQuestionQuery SelectGuidanceAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("guidanceAttachments", query, true);
        }

        /// <summary>
        /// Survey the question is part of.
        /// </summary>
        /// <param name="query">The survey query.</param>
        /// <returns>The same <see cref="SurveyQuestionQuery"/>, updated to include the "Survey" sub-query.</returns>
        public SurveyQuestionQuery SelectSurvey(SurveyQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("survey", query, false);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="SurveyQuestionQuery"/>, updated to include the "Translations" sub-query.</returns>
        public SurveyQuestionQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }
    }
}
