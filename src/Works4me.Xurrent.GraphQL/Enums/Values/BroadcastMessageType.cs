using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The broadcast message type values.
    /// </summary>
    public enum BroadcastMessageType
    {
        /// <summary>
        /// Available.
        /// </summary>
        [XurrentEnum("available")]
        Available,

        /// <summary>
        /// Email.
        /// </summary>
        [XurrentEnum("email")]
        Email,

        /// <summary>
        /// Information.
        /// </summary>
        [XurrentEnum("info")]
        Info,

        /// <summary>
        /// Outage.
        /// </summary>
        [XurrentEnum("outage")]
        Outage,

        /// <summary>
        /// Warning.
        /// </summary>
        [XurrentEnum("warning")]
        Warning
    }
}
