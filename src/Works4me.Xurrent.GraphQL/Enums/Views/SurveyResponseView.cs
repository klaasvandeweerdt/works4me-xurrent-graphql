using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on SurveyResponses.
    /// </summary>
    public enum SurveyResponseView
    {
        /// <summary>
        /// Survey Responses.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All SurveyResponses which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
