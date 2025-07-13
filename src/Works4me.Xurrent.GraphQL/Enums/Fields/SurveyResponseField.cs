using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyResponse">SurveyResponse</see> fields.
    /// </summary>
    public enum SurveyResponseField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The completed field.
        /// </summary>
        [XurrentEnum("completed")]
        Completed,

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
        /// The rating field.
        /// </summary>
        [XurrentEnum("rating")]
        Rating,

        /// <summary>
        /// The rating calculation field.
        /// </summary>
        [XurrentEnum("ratingCalculation")]
        RatingCalculation,

        /// <summary>
        /// The responded at field.
        /// </summary>
        [XurrentEnum("respondedAt")]
        RespondedAt,

        /// <summary>
        /// The service field.
        /// </summary>
        [XurrentEnum("service")]
        Service,

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
        /// The survey field.
        /// </summary>
        [XurrentEnum("survey")]
        Survey,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
