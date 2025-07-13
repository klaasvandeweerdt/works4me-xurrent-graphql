using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyQuestion">SurveyQuestion</see> fields.
    /// </summary>
    public enum SurveyQuestionField
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
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The guidance field.
        /// </summary>
        [XurrentEnum("guidance")]
        Guidance,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The position field.
        /// </summary>
        [XurrentEnum("position")]
        Position,

        /// <summary>
        /// The question field.
        /// </summary>
        [XurrentEnum("question")]
        Question,

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
        /// The type field.
        /// </summary>
        [XurrentEnum("type")]
        Type,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The weight field.
        /// </summary>
        [XurrentEnum("weight")]
        Weight
    }
}
