using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Survey"/> query class.
    /// </summary>
    public class SurveyQuery : Query<Survey, SurveyQuery, SurveyView, SurveyField, SurveyFilterField, SurveyOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SurveyQuery"/> instance.
        /// </summary>
        public SurveyQuery() : base("surveys", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SurveyQuery"/>, updated to include the "Account" sub-query.</returns>
        public SurveyQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Completion field.
        /// </summary>
        /// <param name="query">The completion attachments query.</param>
        /// <returns>The same <see cref="SurveyQuery"/>, updated to include the "CompletionAttachments" sub-query.</returns>
        public SurveyQuery SelectCompletionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("completionAttachments", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Introduction field.
        /// </summary>
        /// <param name="query">The introduction attachments query.</param>
        /// <returns>The same <see cref="SurveyQuery"/>, updated to include the "IntroductionAttachments" sub-query.</returns>
        public SurveyQuery SelectIntroductionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("introductionAttachments", query, true);
        }

        /// <summary>
        /// Questions of this survey.
        /// </summary>
        /// <param name="query">The questions query.</param>
        /// <returns>The same <see cref="SurveyQuery"/>, updated to include the "Questions" sub-query.</returns>
        public SurveyQuery SelectQuestions(SurveyQuestionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("questions", query, true);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="SurveyQuery"/>, updated to include the "Translations" sub-query.</returns>
        public SurveyQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="SurveyQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="SurveyQuery">SurveyQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public SurveyQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
