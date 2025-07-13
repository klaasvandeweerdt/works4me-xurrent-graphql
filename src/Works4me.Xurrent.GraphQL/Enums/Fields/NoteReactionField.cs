using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="NoteReaction">NoteReaction</see> fields.
    /// </summary>
    public enum NoteReactionField
    {
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
        /// The note field.
        /// </summary>
        [XurrentEnum("note")]
        Note,

        /// <summary>
        /// The person field.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// The reaction field.
        /// </summary>
        [XurrentEnum("reaction")]
        Reaction
    }
}
