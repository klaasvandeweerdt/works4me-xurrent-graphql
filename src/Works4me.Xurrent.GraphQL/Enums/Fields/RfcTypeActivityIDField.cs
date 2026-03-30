using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RfcTypeActivityID">RfcTypeActivityID</see> fields.
    /// </summary>
    public enum RfcTypeActivityIDField
    {
        /// <summary>
        /// The activity id field.
        /// </summary>
        [XurrentEnum("activityID")]
        ActivityID,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The rfc type field.
        /// </summary>
        [XurrentEnum("rfcType")]
        RfcType
    }
}
