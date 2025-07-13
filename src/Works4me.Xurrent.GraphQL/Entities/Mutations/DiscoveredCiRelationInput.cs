using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/discoveredcirelationinput/">DiscoveredCiRelationInput</see> in Xurrent.
    /// </summary>
    public sealed class DiscoveredCiRelationInput : PropertyChangeSet
    {
        private Collection<string>? _childIds;

        /// <summary>
        /// Identifiers of other configuration items that are children of this item.
        /// </summary>
        [XurrentField("childIds")]
        public Collection<string>? ChildIds
        {
            get => _childIds;
            set => _childIds = Set("childIds", value);
        }
    }
}
