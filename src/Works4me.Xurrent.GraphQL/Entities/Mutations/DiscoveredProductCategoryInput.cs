using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/discoveredproductcategoryinput/">DiscoveredProductCategoryInput</see> in Xurrent.
    /// </summary>
    public sealed class DiscoveredProductCategoryInput : PropertyChangeSet
    {
        private DiscoveredItemMetaData? _meta;
        private string _reference;
        private string? _sourceID;
        private string _name;
        private Collection<DiscoveredProductInput>? _products;

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
        /// Reference identifying the product category.
        /// </summary>
        [XurrentField("reference")]
        public string Reference
        {
            get => _reference;
            set => _reference = Set("reference", value);
        }

        /// <summary>
        /// The unique identifier of the product category in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Name of the product category.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Configuration items to be uploaded, grouped by product.
        /// </summary>
        [XurrentField("products")]
        public Collection<DiscoveredProductInput>? Products
        {
            get => _products;
            set => _products = Set("products", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredProductCategoryInput"/> class without providing the required values.
        /// </summary>
        public DiscoveredProductCategoryInput()
        {
            _reference = string.Empty;
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredProductCategoryInput"/> class.
        /// </summary>
        public DiscoveredProductCategoryInput(string reference, string name)
        {
            _reference = Set("reference", reference);
            _name = Set("name", name);
        }
    }
}
