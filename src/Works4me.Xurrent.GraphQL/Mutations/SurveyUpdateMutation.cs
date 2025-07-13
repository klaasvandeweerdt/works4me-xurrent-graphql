namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing survey.
    /// </summary>
    internal sealed class SurveyUpdateMutation : Mutation<SurveyUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the survey mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SurveyUpdateMutation(SurveyUpdateInput data, SurveyQuery query)
            : base("surveyUpdate", "SurveyUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "survey")))
        {
        }
    }
}
