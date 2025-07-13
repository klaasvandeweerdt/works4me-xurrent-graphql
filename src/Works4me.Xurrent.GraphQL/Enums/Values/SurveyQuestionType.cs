using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The survey question type values.
    /// </summary>
    public enum SurveyQuestionType
    {
        /// <summary>
        /// Star rating.
        /// </summary>
        [XurrentEnum("star_rating")]
        StarRating,

        /// <summary>
        /// Free text.
        /// </summary>
        [XurrentEnum("text")]
        Text
    }
}
