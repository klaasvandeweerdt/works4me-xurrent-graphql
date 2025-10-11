using System;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/productcategorycreateinput/">ProductCategoryCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class ProductCategoryCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private string? _uiExtensionId;
        private bool? _disabled;
        private string? _group;
        private string _name;
        private ProductCategoryRuleSet _ruleSet;

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
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record. This may be a <a href="https://developer.mozilla.org/en-US/docs/Web/URI/Reference/Schemes/data">'data URL'</a>, allowing the image to be supplied directly without requiring a separate upload first.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
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
        /// Whether the product category may not be related to any more products.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Used to include the product category in a group.
        /// </summary>
        [XurrentField("group")]
        public string? Group
        {
            get => _group;
            set => _group = Set("group", value);
        }

        /// <summary>
        /// The name of the product category.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Used to select a set of rules that are to be applied to the products to which the product category is related, as well as the configuration items that are related to those products. The selected rule set dictates which fields are available for these product and configuration items.
        /// </summary>
        [XurrentField("ruleSet")]
        public ProductCategoryRuleSet RuleSet
        {
            get => _ruleSet;
            set => _ruleSet = Set("ruleSet", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategoryCreateInput"/> class without providing the required values.
        /// </summary>
        public ProductCategoryCreateInput()
        {
            _name = string.Empty;
            _ruleSet = default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategoryCreateInput"/> class.
        /// </summary>
        public ProductCategoryCreateInput(string name, ProductCategoryRuleSet ruleSet)
        {
            _name = Set("name", name);
            _ruleSet = Set("ruleSet", ruleSet);
        }
    }
}
