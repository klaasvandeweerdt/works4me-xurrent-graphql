using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SlaNotificationRule">SlaNotificationRule</see> fields.
    /// </summary>
    public enum SlaNotificationRuleField
    {
        /// <summary>
        /// The notify current assignee field.
        /// </summary>
        [XurrentEnum("notifyCurrentAssignee")]
        NotifyCurrentAssignee,

        /// <summary>
        /// The notify first line team coordinator field.
        /// </summary>
        [XurrentEnum("notifyFirstLineTeamCoordinator")]
        NotifyFirstLineTeamCoordinator,

        /// <summary>
        /// The notify first line team manager field.
        /// </summary>
        [XurrentEnum("notifyFirstLineTeamManager")]
        NotifyFirstLineTeamManager,

        /// <summary>
        /// The notify service owner field.
        /// </summary>
        [XurrentEnum("notifyServiceOwner")]
        NotifyServiceOwner,

        /// <summary>
        /// The notify support team coordinator field.
        /// </summary>
        [XurrentEnum("notifySupportTeamCoordinator")]
        NotifySupportTeamCoordinator,

        /// <summary>
        /// The notify support team manager field.
        /// </summary>
        [XurrentEnum("notifySupportTeamManager")]
        NotifySupportTeamManager,

        /// <summary>
        /// The threshold percentage field.
        /// </summary>
        [XurrentEnum("thresholdPercentage")]
        ThresholdPercentage
    }
}
