using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/discoveredreferencearraystrategyinput/">DiscoveredReferenceArrayStrategyInput</see> in Xurrent.
    /// </summary>
    public sealed class DiscoveredReferenceArrayStrategyInput : PropertyChangeSet
    {
        private string? _strategy;

        /// <summary>
        /// How to handle existing references, to other objects, for discovered items already present in Xurrent.
        /// </summary>
        [XurrentField("strategy")]
        public string? Strategy
        {
            get => _strategy;
            set => _strategy = Set("strategy", value);
        }
    }
}
