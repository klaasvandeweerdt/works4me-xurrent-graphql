using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/childsourcerefinput/">ChildSourceRefInput</see> in Xurrent.
    /// </summary>
    public sealed class ChildSourceRefInput : PropertyChangeSet
    {
        private string? _source;
        private string _sourceID;

        /// <summary>
        /// An identifier for the external system that owns the child configuration item. Optional;.<br />
        /// defaults to the discovery run's own source. Supply it to reference a child identified in.<br />
        /// a different external system.<br />
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the child configuration item within its source.
        /// </summary>
        [XurrentField("sourceID")]
        public string SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildSourceRefInput"/> class without providing the required values.
        /// </summary>
        public ChildSourceRefInput()
        {
            _sourceID = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildSourceRefInput"/> class.
        /// </summary>
        public ChildSourceRefInput(string sourceID)
        {
            _sourceID = Set("sourceID", sourceID);
        }
    }
}
