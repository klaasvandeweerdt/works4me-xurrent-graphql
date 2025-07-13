using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyAnswer"/> query class.
    /// </summary>
    public class SurveyAnswerQuery : Query<SurveyAnswer, SurveyAnswerQuery, DefaultView, SurveyAnswerField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SurveyAnswerQuery"/> instance.
        /// </summary>
        public SurveyAnswerQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SurveyAnswerQuery"/>, updated to include the "Account" sub-query.</returns>
        public SurveyAnswerQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Question this answer is for.
        /// </summary>
        /// <param name="query">The question query.</param>
        /// <returns>The same <see cref="SurveyAnswerQuery"/>, updated to include the "Question" sub-query.</returns>
        public SurveyAnswerQuery SelectQuestion(SurveyQuestionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("question", query, false);
        }

        /// <summary>
        /// Survey response the answer is part of.
        /// </summary>
        /// <param name="query">The survey response query.</param>
        /// <returns>The same <see cref="SurveyAnswerQuery"/>, updated to include the "SurveyResponse" sub-query.</returns>
        public SurveyAnswerQuery SelectSurveyResponse(SurveyResponseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("surveyResponse", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the Text field.
        /// </summary>
        /// <param name="query">The text attachments query.</param>
        /// <returns>The same <see cref="SurveyAnswerQuery"/>, updated to include the "TextAttachments" sub-query.</returns>
        public SurveyAnswerQuery SelectTextAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("textAttachments", query, true);
        }
    }
}
