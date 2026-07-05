using System.Collections.Generic;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/discoveredconfigurationitemspayload/">DiscoveredConfigurationItemsPayload</see> in Xurrent.
    /// </summary>
    public sealed class DiscoveredConfigurationItemsPayload : MutationResultBase
    {
        /// <summary>
        /// Metadata about asynchronous query execution. The <c>asyncQuery { resultUrl }</c> contains an expiring link to the file with the full results.
        /// </summary>
        [XurrentField("asyncQuery")]
        public AsyncQuery? AsyncQuery { get; internal set; }

        /// <summary>
        /// Configuration items will be <c>null</c> on initial submission. The <c>asyncQuery { resultUrl }</c> contains an expiring link to the file with the full results.
        /// </summary>
        [XurrentField("configurationItems")]
        public IReadOnlyList<ConfigurationItem>? ConfigurationItems { get; internal set; }

        /// <summary>
        /// The number of configuration items that were routed to the reconciliation queue for approval instead of being created or updated directly. These items are staged for review and omitted from <c>configurationItems</c>. Will be <c>null</c> on initial submission; the count is included in the full results available via <c>asyncQuery { resultUrl }</c>.
        /// </summary>
        [XurrentField("pendingCiReconciliationCount", IsDefaultQueryProperty = true)]
        public long? PendingCiReconciliationCount { get; internal set; }
    }
}
