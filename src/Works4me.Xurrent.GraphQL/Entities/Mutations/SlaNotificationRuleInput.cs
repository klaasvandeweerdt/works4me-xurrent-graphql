using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/slanotificationruleinput/">SlaNotificationRuleInput</see> in Xurrent.
    /// </summary>
    public sealed class SlaNotificationRuleInput : PropertyChangeSet
    {
        private string? _id;
        private long? _thresholdPercentage;
        private bool? _notifyCurrentAssignee;
        private bool? _notifyFirstLineTeamCoordinator;
        private bool? _notifyFirstLineTeamManager;
        private bool? _notifyServiceOwner;
        private bool? _notifySupportTeamCoordinator;
        private bool? _notifySupportTeamManager;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [XurrentField("id")]
        public string? Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// The percentage of the target duration when a notification should be generated.
        /// </summary>
        [XurrentField("thresholdPercentage")]
        public long? ThresholdPercentage
        {
            get => _thresholdPercentage;
            set => _thresholdPercentage = Set("thresholdPercentage", value);
        }

        /// <summary>
        /// Whether to notify the current assignee of the request.
        /// </summary>
        [XurrentField("notifyCurrentAssignee")]
        public bool? NotifyCurrentAssignee
        {
            get => _notifyCurrentAssignee;
            set => _notifyCurrentAssignee = Set("notifyCurrentAssignee", value);
        }

        /// <summary>
        /// Whether to notify the first line team coordinator of the service instance of the affected SLA.
        /// </summary>
        [XurrentField("notifyFirstLineTeamCoordinator")]
        public bool? NotifyFirstLineTeamCoordinator
        {
            get => _notifyFirstLineTeamCoordinator;
            set => _notifyFirstLineTeamCoordinator = Set("notifyFirstLineTeamCoordinator", value);
        }

        /// <summary>
        /// Whether to notify the first line team manager of the service instance of the affected SLA.
        /// </summary>
        [XurrentField("notifyFirstLineTeamManager")]
        public bool? NotifyFirstLineTeamManager
        {
            get => _notifyFirstLineTeamManager;
            set => _notifyFirstLineTeamManager = Set("notifyFirstLineTeamManager", value);
        }

        /// <summary>
        /// Whether to notify the service owner of the service of the affected SLA.
        /// </summary>
        [XurrentField("notifyServiceOwner")]
        public bool? NotifyServiceOwner
        {
            get => _notifyServiceOwner;
            set => _notifyServiceOwner = Set("notifyServiceOwner", value);
        }

        /// <summary>
        /// Whether to notify the support team coordinator of the service instance of the affected SLA.
        /// </summary>
        [XurrentField("notifySupportTeamCoordinator")]
        public bool? NotifySupportTeamCoordinator
        {
            get => _notifySupportTeamCoordinator;
            set => _notifySupportTeamCoordinator = Set("notifySupportTeamCoordinator", value);
        }

        /// <summary>
        /// Whether to notify the support team manager of the service instance of the affected SLA.
        /// </summary>
        [XurrentField("notifySupportTeamManager")]
        public bool? NotifySupportTeamManager
        {
            get => _notifySupportTeamManager;
            set => _notifySupportTeamManager = Set("notifySupportTeamManager", value);
        }
    }
}
