using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shoporderlineupdateinput/">ShopOrderLineUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ShopOrderLineUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _requestedForId;
        private string? _shopArticleId;
        private long? _quantity;
        private Collection<AddressInput>? _newAddresses;
        private string _id;

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
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [XurrentField("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => _customFields;
            set => _customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [XurrentField("customFieldsAttachments")]
        public Collection<AttachmentInput>? CustomFieldsAttachments
        {
            get => _customFieldsAttachments;
            set => _customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// The person for whom the shop order line was submitted.
        /// </summary>
        [XurrentField("requestedForId")]
        public string? RequestedForId
        {
            get => _requestedForId;
            set => _requestedForId = Set("requestedForId", value);
        }

        /// <summary>
        /// The shop article that is ordered.
        /// </summary>
        [XurrentField("shopArticleId")]
        public string? ShopArticleId
        {
            get => _shopArticleId;
            set => _shopArticleId = Set("shopArticleId", value);
        }

        /// <summary>
        /// The number units ordered.
        /// </summary>
        [XurrentField("quantity")]
        public long? Quantity
        {
            get => _quantity;
            set => _quantity = Set("quantity", value);
        }

        /// <summary>
        /// New or updated addresses of the shop order line.
        /// </summary>
        [XurrentField("newAddresses")]
        public Collection<AddressInput>? NewAddresses
        {
            get => _newAddresses;
            set => _newAddresses = Set("newAddresses", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopOrderLineUpdateInput"/> class without providing the required values.
        /// </summary>
        public ShopOrderLineUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopOrderLineUpdateInput"/> class.
        /// </summary>
        public ShopOrderLineUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
