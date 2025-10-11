using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/servicecategoryupdateinput/">ServiceCategoryUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ServiceCategoryUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private string? _name;
        private Collection<string>? _serviceIds;
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
        /// The hyperlink to the image file for the record. This may be a <a href="https://developer.mozilla.org/en-US/docs/Web/URI/Reference/Schemes/data">'data URL'</a>, allowing the image to be supplied directly without requiring a separate upload first.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// A high-level description of the type of services that are included in the service category.
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
        /// The name of the service category.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Identifiers of the services of the service category.
        /// </summary>
        [XurrentField("serviceIds")]
        public Collection<string>? ServiceIds
        {
            get => _serviceIds;
            set => _serviceIds = Set("serviceIds", value);
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
        /// Initializes a new instance of the <see cref="ServiceCategoryUpdateInput"/> class without providing the required values.
        /// </summary>
        public ServiceCategoryUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCategoryUpdateInput"/> class.
        /// </summary>
        public ServiceCategoryUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
