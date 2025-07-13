using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The person send email notifications values.
    /// </summary>
    public enum PersonSendEmailNotifications
    {
        /// <summary>
        /// Always.
        /// </summary>
        [XurrentEnum("always")]
        Always,

        /// <summary>
        /// Never.
        /// </summary>
        [XurrentEnum("never")]
        Never,

        /// <summary>
        /// Only when i am offline.
        /// </summary>
        [XurrentEnum("when_offline")]
        WhenOffline
    }
}
