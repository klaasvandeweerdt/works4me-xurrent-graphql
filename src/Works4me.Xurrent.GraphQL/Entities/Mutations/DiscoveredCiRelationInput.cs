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
        private Collection<ChildSourceRefInput>? _childSourceRefs;

        /// <summary>
        /// Identifiers of other configuration items that are children of this item.
        /// </summary>
        [XurrentField("childIds")]
        public Collection<string>? ChildIds
        {
            get => _childIds;
            set => _childIds = Set("childIds", value);
        }

        /// <summary>
        /// References to other configuration items that are children of this item, addressed by.<br />
        /// their external identity (source, sourceID) rather than by a Xurrent identifier. Use this.<br />
        /// for a child created in the same call, staged in an earlier batch, or maintained in.<br />
        /// another external system. On a reconciliation-enabled account, a child that does not exist.<br />
        /// yet is deferred and linked automatically once it is imported.<br />
        /// </summary>
        [XurrentField("childSourceRefs")]
        public Collection<ChildSourceRefInput>? ChildSourceRefs
        {
            get => _childSourceRefs;
            set => _childSourceRefs = Set("childSourceRefs", value);
        }
    }
}
