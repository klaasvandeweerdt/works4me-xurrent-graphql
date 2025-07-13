namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new survey.
    /// </summary>
    internal sealed class SurveyCreateMutation : Mutation<SurveyCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SurveyCreateMutation(SurveyCreateInput data, SurveyQuery query)
            : base("surveyCreate", "SurveyCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "survey")))
        {
        }
    }
}
