using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/slanotificationrule/">SlaNotificationRule</see> in Xurrent.
    /// </summary>
    [XurrentEntity("SlaNotificationRule")]
    public sealed class SlaNotificationRule : IDataItem
    {
        /// <summary>
        /// Whether to notify the current assignee of the request.
        /// </summary>
        [XurrentField("notifyCurrentAssignee", IsDefaultQueryProperty = true)]
        public bool? NotifyCurrentAssignee { get; internal set; }

        /// <summary>
        /// Whether to notify the first line team coordinator of the service instance of the affected SLA.
        /// </summary>
        [XurrentField("notifyFirstLineTeamCoordinator", IsDefaultQueryProperty = true)]
        public bool? NotifyFirstLineTeamCoordinator { get; internal set; }

        /// <summary>
        /// Whether to notify the first line team manager of the service instance of the affected SLA.
        /// </summary>
        [XurrentField("notifyFirstLineTeamManager", IsDefaultQueryProperty = true)]
        public bool? NotifyFirstLineTeamManager { get; internal set; }

        /// <summary>
        /// Whether to notify the service owner of the service of the affected SLA.
        /// </summary>
        [XurrentField("notifyServiceOwner", IsDefaultQueryProperty = true)]
        public bool? NotifyServiceOwner { get; internal set; }

        /// <summary>
        /// Whether to notify the support team coordinator of the service instance of the affected SLA.
        /// </summary>
        [XurrentField("notifySupportTeamCoordinator", IsDefaultQueryProperty = true)]
        public bool? NotifySupportTeamCoordinator { get; internal set; }

        /// <summary>
        /// Whether to notify the support team manager of the service instance of the affected SLA.
        /// </summary>
        [XurrentField("notifySupportTeamManager", IsDefaultQueryProperty = true)]
        public bool? NotifySupportTeamManager { get; internal set; }

        /// <summary>
        /// The percentage of the target duration when a notification should be generated.
        /// </summary>
        [XurrentField("thresholdPercentage", IsDefaultQueryProperty = true)]
        public long? ThresholdPercentage { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return GetHashCode().ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
