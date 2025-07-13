using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/discoveredconfigurationitemsinput/">DiscoveredConfigurationItemsInput</see> in Xurrent.
    /// </summary>
    public sealed class DiscoveredConfigurationItemsInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string _source;
        private Collection<string>? _alternativeSources;
        private string? _supportTeam;
        private Collection<DiscoveredProductCategoryInput>? _physicalAssets;
        private DiscoveredReferenceStrategiesInput? _referenceStrategies;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// Identifier for the client application submitting the upload.
        /// </summary>
        [XurrentField("source")]
        public string Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// Alternative identifiers for the client application. When a configuration item or product with the given <c>sourceID</c> is found linked to one of these alternative sources it will be identified as the same. For configuration items the source field in Xurrent will be updated to the <c>source</c> value supplied.
        /// </summary>
        [XurrentField("alternativeSources")]
        public Collection<string>? AlternativeSources
        {
            get => _alternativeSources;
            set => _alternativeSources = Set("alternativeSources", value);
        }

        /// <summary>
        /// Name of the support team to use as default for new products and configuration items uploaded.
        /// </summary>
        [XurrentField("supportTeam")]
        public string? SupportTeam
        {
            get => _supportTeam;
            set => _supportTeam = Set("supportTeam", value);
        }

        /// <summary>
        /// Physical assets to be uploaded, grouped by product category and product.
        /// </summary>
        [XurrentField("physicalAssets")]
        public Collection<DiscoveredProductCategoryInput>? PhysicalAssets
        {
            get => _physicalAssets;
            set => _physicalAssets = Set("physicalAssets", value);
        }

        /// <summary>
        /// How to handle references to records already present in Xurrent.
        /// </summary>
        [XurrentField("referenceStrategies")]
        public DiscoveredReferenceStrategiesInput? ReferenceStrategies
        {
            get => _referenceStrategies;
            set => _referenceStrategies = Set("referenceStrategies", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredConfigurationItemsInput"/> class without providing the required values.
        /// </summary>
        public DiscoveredConfigurationItemsInput()
        {
            _source = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredConfigurationItemsInput"/> class.
        /// </summary>
        public DiscoveredConfigurationItemsInput(string source)
        {
            _source = Set("source", source);
        }
    }
}
