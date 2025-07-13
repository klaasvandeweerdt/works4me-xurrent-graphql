using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Watch">Watch</see> fields.
    /// </summary>
    public enum WatchField
    {
        /// <summary>
        /// The added by field.
        /// </summary>
        [XurrentEnum("addedBy")]
        AddedBy,

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
        /// The person field.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
