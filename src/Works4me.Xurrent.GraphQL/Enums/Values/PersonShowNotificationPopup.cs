using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The person show notification popup values.
    /// </summary>
    public enum PersonShowNotificationPopup
    {
        /// <summary>
        /// Always.
        /// </summary>
        [XurrentEnum("always")]
        Always,

        /// <summary>
        /// Only for important notifications.
        /// </summary>
        [XurrentEnum("important_only")]
        ImportantOnly,

        /// <summary>
        /// Never.
        /// </summary>
        [XurrentEnum("never")]
        Never
    }
}
