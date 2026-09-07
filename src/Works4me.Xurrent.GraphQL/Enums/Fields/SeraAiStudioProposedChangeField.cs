using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SeraAiStudioProposedChange">SeraAiStudioProposedChange</see> fields.
    /// </summary>
    public enum SeraAiStudioProposedChangeField
    {
        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The note field.
        /// </summary>
        [XurrentEnum("note")]
        Note,

        /// <summary>
        /// The original field.
        /// </summary>
        [XurrentEnum("original")]
        Original,

        /// <summary>
        /// The proposed field.
        /// </summary>
        [XurrentEnum("proposed")]
        Proposed
    }
}
