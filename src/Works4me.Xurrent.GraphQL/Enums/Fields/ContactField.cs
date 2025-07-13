using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Contact">Contact</see> fields.
    /// </summary>
    public enum ContactField
    {
        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The integration field.
        /// </summary>
        [XurrentEnum("integration")]
        Integration,

        /// <summary>
        /// The label field.
        /// </summary>
        [XurrentEnum("label")]
        Label,

        /// <summary>
        /// The protocol field.
        /// </summary>
        [XurrentEnum("protocol")]
        Protocol,

        /// <summary>
        /// The uri field.
        /// </summary>
        [XurrentEnum("uri")]
        Uri
    }
}
