using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/discoveredreferencestrategiesinput/">DiscoveredReferenceStrategiesInput</see> in Xurrent.
    /// </summary>
    public sealed class DiscoveredReferenceStrategiesInput : PropertyChangeSet
    {
        private DiscoveredReferenceArrayStrategyInput? _ciUserIds;

        /// <summary>
        /// How to process the <c>userIds</c> supplied for configuration items.
        /// </summary>
        [XurrentField("ciUserIds")]
        public DiscoveredReferenceArrayStrategyInput? CiUserIds
        {
            get => _ciUserIds;
            set => _ciUserIds = Set("ciUserIds", value);
        }
    }
}
