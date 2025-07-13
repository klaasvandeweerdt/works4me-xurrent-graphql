using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="FeedbackUrls">FeedbackUrls</see> fields.
    /// </summary>
    public enum FeedbackUrlsField
    {
        /// <summary>
        /// The dissatisfied url field.
        /// </summary>
        [XurrentEnum("dissatisfiedUrl")]
        DissatisfiedUrl,

        /// <summary>
        /// The satisfied url field.
        /// </summary>
        [XurrentEnum("satisfiedUrl")]
        SatisfiedUrl
    }
}
