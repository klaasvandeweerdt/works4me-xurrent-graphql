namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing survey response.
    /// </summary>
    internal sealed class SurveyResponseUpdateMutation : Mutation<SurveyResponseUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyResponseUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the survey response mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SurveyResponseUpdateMutation(SurveyResponseUpdateInput data, SurveyResponseQuery query)
            : base("surveyResponseUpdate", "SurveyResponseUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "surveyResponse")))
        {
        }
    }
}
