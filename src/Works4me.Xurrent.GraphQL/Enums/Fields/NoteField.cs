using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Note">Note</see> fields.
    /// </summary>
    public enum NoteField
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
        /// The inbound email field.
        /// </summary>
        [XurrentEnum("inboundEmail")]
        InboundEmail,

        /// <summary>
        /// The internal field.
        /// </summary>
        [XurrentEnum("internal")]
        Internal,

        /// <summary>
        /// The medium field.
        /// </summary>
        [XurrentEnum("medium")]
        Medium,

        /// <summary>
        /// The person field.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// The text field.
        /// </summary>
        [XurrentEnum("text")]
        Text,

        /// <summary>
        /// The visibility field.
        /// </summary>
        [XurrentEnum("visibility")]
        Visibility
    }
}
