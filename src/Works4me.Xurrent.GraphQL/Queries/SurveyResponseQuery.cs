using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyResponse"/> query class.
    /// </summary>
    public class SurveyResponseQuery : Query<SurveyResponse, SurveyResponseQuery, SurveyResponseView, SurveyResponseField, SurveyResponseFilterField, SurveyResponseOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SurveyResponseQuery"/> instance.
        /// </summary>
        public SurveyResponseQuery() : base("surveyResponses", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SurveyResponseQuery"/>, updated to include the "Account" sub-query.</returns>
        public SurveyResponseQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Answers of this survey response.
        /// </summary>
        /// <param name="query">The answers query.</param>
        /// <returns>The same <see cref="SurveyResponseQuery"/>, updated to include the "Answers" sub-query.</returns>
        public SurveyResponseQuery SelectAnswers(SurveyAnswerQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("answers", query, true);
        }

        /// <summary>
        /// Service this response is about.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="SurveyResponseQuery"/>, updated to include the "Service" sub-query.</returns>
        public SurveyResponseQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// SLAs of this survey response.
        /// </summary>
        /// <param name="query">The slas query.</param>
        /// <returns>The same <see cref="SurveyResponseQuery"/>, updated to include the "Slas" sub-query.</returns>
        public SurveyResponseQuery SelectSlas(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("slas", query, true);
        }

        /// <summary>
        /// Survey this response is for.
        /// </summary>
        /// <param name="query">The survey query.</param>
        /// <returns>The same <see cref="SurveyResponseQuery"/>, updated to include the "Survey" sub-query.</returns>
        public SurveyResponseQuery SelectSurvey(SurveyQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("survey", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="SurveyResponseQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="SurveyResponseQuery">SurveyResponseQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public SurveyResponseQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
