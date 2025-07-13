using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Surveys.
    /// </summary>
    public enum SurveyView
    {
        /// <summary>
        /// Surveys.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Surveys which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
