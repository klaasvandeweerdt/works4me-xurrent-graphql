using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="GoldenSetItem">GoldenSetItem</see> fields.
    /// </summary>
    public enum GoldenSetItemField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The ai response field.
        /// </summary>
        [XurrentEnum("aiResponse")]
        AiResponse,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The expected hit field.
        /// </summary>
        [XurrentEnum("expectedHit")]
        ExpectedHit,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The prompt query field.
        /// </summary>
        [XurrentEnum("promptQuery")]
        PromptQuery,

        /// <summary>
        /// The run as field.
        /// </summary>
        [XurrentEnum("runAs")]
        RunAs,

        /// <summary>
        /// The score field.
        /// </summary>
        [XurrentEnum("score")]
        Score,

        /// <summary>
        /// The sera ai studio field.
        /// </summary>
        [XurrentEnum("seraAiStudio")]
        SeraAiStudio,

        /// <summary>
        /// The started at field.
        /// </summary>
        [XurrentEnum("startedAt")]
        StartedAt,

        /// <summary>
        /// The status field.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// The time taken field.
        /// </summary>
        [XurrentEnum("timeTaken")]
        TimeTaken,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
