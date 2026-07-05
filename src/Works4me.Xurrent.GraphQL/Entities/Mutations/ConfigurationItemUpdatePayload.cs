using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/configurationitemupdatepayload/">ConfigurationItemUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ConfigurationItemUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("configurationItem")]
        public ConfigurationItem? ConfigurationItem { get; internal set; }

        /// <summary>
        /// Returns <c>true</c> when the configuration item was routed to the reconciliation queue for approval instead of being applied directly. The proposed change is staged for review, not applied to the configuration item; on create <c>configurationItem</c> is <c>null</c>, on update <c>configurationItem</c> is returned unchanged.
        /// </summary>
        [XurrentField("pendingCiReconciliation", IsDefaultQueryProperty = true)]
        public bool? PendingCiReconciliation { get; internal set; }
    }
}
