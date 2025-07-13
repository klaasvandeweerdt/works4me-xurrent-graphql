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
        [XurrentField("asyncQuery", IsDefaultQueryProperty = true)]
        public AsyncQuery? AsyncQuery { get; internal set; }

        /// <summary>
        /// Configuration items will be <c>null</c> on initial submission. The <c>asyncQuery { resultUrl }</c> contains an expiring link to the file with the full results.
        /// </summary>
        [XurrentField("configurationItems", IsDefaultQueryProperty = true)]
        public IReadOnlyList<ConfigurationItem>? ConfigurationItems { get; internal set; }
    }
}
