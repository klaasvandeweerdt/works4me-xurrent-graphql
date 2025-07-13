using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="CustomField">CustomField</see> fields.
    /// </summary>
    public enum CustomFieldField
    {
        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The value field.
        /// </summary>
        [XurrentEnum("value")]
        Value
    }
}
