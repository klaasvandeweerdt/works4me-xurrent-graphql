using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyAnswer">SurveyAnswer</see> fields.
    /// </summary>
    public enum SurveyAnswerField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The question field.
        /// </summary>
        [XurrentEnum("question")]
        Question,

        /// <summary>
        /// The rating field.
        /// </summary>
        [XurrentEnum("rating")]
        Rating,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The survey response field.
        /// </summary>
        [XurrentEnum("surveyResponse")]
        SurveyResponse,

        /// <summary>
        /// The text field.
        /// </summary>
        [XurrentEnum("text")]
        Text,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
