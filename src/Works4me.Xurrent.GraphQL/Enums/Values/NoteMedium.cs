using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The note medium values.
    /// </summary>
    public enum NoteMedium
    {
        /// <summary>
        /// Ai.
        /// </summary>
        [XurrentEnum("ai")]
        Ai,

        /// <summary>
        /// Automation.
        /// </summary>
        [XurrentEnum("automation")]
        Automation,

        /// <summary>
        /// Default.
        /// </summary>
        [XurrentEnum("default")]
        Default,

        /// <summary>
        /// Email.
        /// </summary>
        [XurrentEnum("email")]
        Email,

        /// <summary>
        /// Outbound email.
        /// </summary>
        [XurrentEnum("outbound_email")]
        OutboundEmail,

        /// <summary>
        /// Redacted.
        /// </summary>
        [XurrentEnum("redacted")]
        Redacted,

        /// <summary>
        /// Reference.
        /// </summary>
        [XurrentEnum("reference")]
        Reference,

        /// <summary>
        /// System.
        /// </summary>
        [XurrentEnum("system")]
        System
    }
}
