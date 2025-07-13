using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/customcollectionelementcreateinput/">CustomCollectionElementCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class CustomCollectionElementCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private CustomFieldCollection? _customFields;
        private Collection<AttachmentInput>? _customFieldsAttachments;
        private string? _description;
        private bool? _disabled;
        private string? _information;
        private Collection<AttachmentInput>? _informationAttachments;
        private string? _reference;
        private string? _customCollectionId;
        private string? _customCollection;
        private string _name;

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
        /// Description of the collection element.
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// Whether the collection element may not be referenced from custom fields of other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Any additional information about the element that might prove useful.
        /// </summary>
        [XurrentField("information")]
        public string? Information
        {
            get => _information;
            set => _information = Set("information", value);
        }

        /// <summary>
        /// The attachments used in the <c>information</c> field.
        /// </summary>
        [XurrentField("informationAttachments")]
        public Collection<AttachmentInput>? InformationAttachments
        {
            get => _informationAttachments;
            set => _informationAttachments = Set("informationAttachments", value);
        }

        /// <summary>
        /// The Reference field defaults to the Name field value, written in lower case characters and with all spaces replaced by the underscore character.
        /// </summary>
        [XurrentField("reference")]
        public string? Reference
        {
            get => _reference;
            set => _reference = Set("reference", value);
        }

        /// <summary>
        /// Identifier of the collection of this element.
        /// </summary>
        [XurrentField("customCollectionId")]
        public string? CustomCollectionId
        {
            get => _customCollectionId;
            set => _customCollectionId = Set("customCollectionId", value);
        }

        /// <summary>
        /// Reference of the collection of this element.
        /// </summary>
        [XurrentField("customCollection")]
        public string? CustomCollection
        {
            get => _customCollection;
            set => _customCollection = Set("customCollection", value);
        }

        /// <summary>
        /// Name of the collection element.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollectionElementCreateInput"/> class without providing the required values.
        /// </summary>
        public CustomCollectionElementCreateInput()
        {
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollectionElementCreateInput"/> class.
        /// </summary>
        public CustomCollectionElementCreateInput(string name)
        {
            _name = Set("name", name);
        }
    }
}
