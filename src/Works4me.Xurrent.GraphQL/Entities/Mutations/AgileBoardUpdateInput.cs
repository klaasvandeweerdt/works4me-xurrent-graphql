using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/agileboardupdateinput/">AgileBoardUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class AgileBoardUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private bool? _disabled;
        private string? _name;
        private string? _managerId;
        private Collection<string>? _customerRepresentativeSlaIds;
        private Collection<AgileBoardColumnInput>? _newColumns;
        private string _id;
        private Collection<string>? _columnsToDelete;

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
        /// Description of the agile board.
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        [XurrentField("descriptionAttachments")]
        public Collection<AttachmentInput>? DescriptionAttachments
        {
            get => _descriptionAttachments;
            set => _descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// Whether the board may not be used to place items on.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Name of the agile board.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Identifier of the manager of the agile board.
        /// </summary>
        [XurrentField("managerId")]
        public string? ManagerId
        {
            get => _managerId;
            set => _managerId = Set("managerId", value);
        }

        /// <summary>
        /// Identifiers of the service level agreements of which the customer representatives can view this board in Self Service.
        /// </summary>
        [XurrentField("customerRepresentativeSlaIds")]
        public Collection<string>? CustomerRepresentativeSlaIds
        {
            get => _customerRepresentativeSlaIds;
            set => _customerRepresentativeSlaIds = Set("customerRepresentativeSlaIds", value);
        }

        /// <summary>
        /// Columns of this agile board.
        /// </summary>
        [XurrentField("newColumns")]
        public Collection<AgileBoardColumnInput>? NewColumns
        {
            get => _newColumns;
            set => _newColumns = Set("newColumns", value);
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
        /// Identifiers of columns to remove from the board.
        /// </summary>
        [XurrentField("columnsToDelete")]
        public Collection<string>? ColumnsToDelete
        {
            get => _columnsToDelete;
            set => _columnsToDelete = Set("columnsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgileBoardUpdateInput"/> class without providing the required values.
        /// </summary>
        public AgileBoardUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgileBoardUpdateInput"/> class.
        /// </summary>
        public AgileBoardUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
