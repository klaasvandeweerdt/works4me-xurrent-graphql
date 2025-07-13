namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new survey response.
    /// </summary>
    internal sealed class SurveyResponseCreateMutation : Mutation<SurveyResponseCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyResponseCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SurveyResponseCreateMutation(SurveyResponseCreateInput data, SurveyResponseQuery query)
            : base("surveyResponseCreate", "SurveyResponseCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "surveyResponse")))
        {
        }
    }
}
