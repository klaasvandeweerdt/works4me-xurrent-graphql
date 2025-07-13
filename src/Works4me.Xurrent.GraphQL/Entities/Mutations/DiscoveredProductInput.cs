using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/discoveredproductinput/">DiscoveredProductInput</see> in Xurrent.
    /// </summary>
    public sealed class DiscoveredProductInput : PropertyChangeSet
    {
        private DiscoveredItemMetaData? _meta;
        private string? _uiExtensionId;
        private string _sourceID;
        private string _name;
        private string? _service;
        private string _model;
        private string _brand;
        private string? _productID;
        private Collection<DiscoveredCiInput>? _configurationItems;

        /// <summary>
        /// Meta data describing how to process the values supplied.
        /// </summary>
        [XurrentField("meta")]
        public DiscoveredItemMetaData? Meta
        {
            get => _meta;
            set => _meta = Set("meta", value);
        }

        /// <summary>
        /// UI extension that is to be applied to the record.
        /// </summary>
        [XurrentField("uiExtensionId")]
        public string? UiExtensionId
        {
            get => _uiExtensionId;
            set => _uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// The unique identifier of the product in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Name of the product.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The name of the service this product's configuration items are, or will be, a part of.
        /// </summary>
        [XurrentField("service")]
        public string? Service
        {
            get => _service;
            set => _service = Set("service", value);
        }

        /// <summary>
        /// The model of the product.
        /// </summary>
        [XurrentField("model")]
        public string Model
        {
            get => _model;
            set => _model = Set("model", value);
        }

        /// <summary>
        /// The brand name is typically the name of the product's manufacturer.
        /// </summary>
        [XurrentField("brand")]
        public string Brand
        {
            get => _brand;
            set => _brand = Set("brand", value);
        }

        /// <summary>
        /// The unique identifier of the product that is used by the manufacturer. The concatenation of <c>brand</c> and <c>productID</c> must be unique within a Xurrent account.
        /// </summary>
        [XurrentField("productID")]
        public string? ProductID
        {
            get => _productID;
            set => _productID = Set("productID", value);
        }

        /// <summary>
        /// Configuration items to be uploaded.
        /// </summary>
        [XurrentField("configurationItems")]
        public Collection<DiscoveredCiInput>? ConfigurationItems
        {
            get => _configurationItems;
            set => _configurationItems = Set("configurationItems", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredProductInput"/> class without providing the required values.
        /// </summary>
        public DiscoveredProductInput()
        {
            _sourceID = string.Empty;
            _name = string.Empty;
            _model = string.Empty;
            _brand = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredProductInput"/> class.
        /// </summary>
        public DiscoveredProductInput(string sourceID, string name, string model, string brand)
        {
            _sourceID = Set("sourceID", sourceID);
            _name = Set("name", name);
            _model = Set("model", model);
            _brand = Set("brand", brand);
        }
    }
}
