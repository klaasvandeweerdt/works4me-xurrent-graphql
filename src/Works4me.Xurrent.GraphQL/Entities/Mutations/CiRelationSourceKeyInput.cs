using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/cirelationsourcekeyinput/">CiRelationSourceKeyInput</see> in Xurrent.
    /// </summary>
    public sealed class CiRelationSourceKeyInput : PropertyChangeSet
    {
        private string _configurationItemSource;
        private string _configurationItemSourceID;

        /// <summary>
        /// An identifier for the external system that owns the related configuration item, used.<br />
        /// together with <c>configurationItemSourceID</c> to address the relation to remove by the.<br />
        /// related configuration item's external identity.<br />
        /// </summary>
        [XurrentField("configurationItemSource")]
        public string ConfigurationItemSource
        {
            get => _configurationItemSource;
            set => _configurationItemSource = Set("configurationItemSource", value);
        }

        /// <summary>
        /// The unique identifier of the related configuration item in the external system named by.<br />
        /// <c>configurationItemSource</c>. Both must be provided together.<br />
        /// </summary>
        [XurrentField("configurationItemSourceID")]
        public string ConfigurationItemSourceID
        {
            get => _configurationItemSourceID;
            set => _configurationItemSourceID = Set("configurationItemSourceID", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiRelationSourceKeyInput"/> class without providing the required values.
        /// </summary>
        public CiRelationSourceKeyInput()
        {
            _configurationItemSource = string.Empty;
            _configurationItemSourceID = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiRelationSourceKeyInput"/> class.
        /// </summary>
        public CiRelationSourceKeyInput(string configurationItemSource, string configurationItemSourceID)
        {
            _configurationItemSource = Set("configurationItemSource", configurationItemSource);
            _configurationItemSourceID = Set("configurationItemSourceID", configurationItemSourceID);
        }
    }
}
