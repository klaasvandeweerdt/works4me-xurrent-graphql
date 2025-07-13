using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="InboundEmail">InboundEmail</see> fields.
    /// </summary>
    public enum InboundEmailField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The body start field.
        /// </summary>
        [XurrentEnum("bodyStart")]
        BodyStart,

        /// <summary>
        /// The cc field.
        /// </summary>
        [XurrentEnum("cc")]
        Cc,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The failure reason field.
        /// </summary>
        [XurrentEnum("failureReason")]
        FailureReason,

        /// <summary>
        /// The from field.
        /// </summary>
        [XurrentEnum("from")]
        From,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The message id field.
        /// </summary>
        [XurrentEnum("messageId")]
        MessageId,

        /// <summary>
        /// The note field.
        /// </summary>
        [XurrentEnum("note")]
        Note,

        /// <summary>
        /// The record field.
        /// </summary>
        [XurrentEnum("record")]
        Record,

        /// <summary>
        /// The source uri field.
        /// </summary>
        [XurrentEnum("sourceUri")]
        SourceUri,

        /// <summary>
        /// The subject field.
        /// </summary>
        [XurrentEnum("subject")]
        Subject,

        /// <summary>
        /// The to field.
        /// </summary>
        [XurrentEnum("to")]
        To
    }
}
