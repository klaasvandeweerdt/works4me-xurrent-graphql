using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shoparticlecategorycreateinput/">ShopArticleCategoryCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class ShopArticleCategoryCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private string? _fullDescription;
        private Collection<AttachmentInput>? _fullDescriptionAttachments;
        private string? _parentId;
        private string? _shortDescription;
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
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// The full description of the shop article category.
        /// </summary>
        [XurrentField("fullDescription")]
        public string? FullDescription
        {
            get => _fullDescription;
            set => _fullDescription = Set("fullDescription", value);
        }

        /// <summary>
        /// The attachments used in the <c>fullDescription</c> field.
        /// </summary>
        [XurrentField("fullDescriptionAttachments")]
        public Collection<AttachmentInput>? FullDescriptionAttachments
        {
            get => _fullDescriptionAttachments;
            set => _fullDescriptionAttachments = Set("fullDescriptionAttachments", value);
        }

        /// <summary>
        /// Identifier of the category's parent category.
        /// </summary>
        [XurrentField("parentId")]
        public string? ParentId
        {
            get => _parentId;
            set => _parentId = Set("parentId", value);
        }

        /// <summary>
        /// The shop description of the shop article category.
        /// </summary>
        [XurrentField("shortDescription")]
        public string? ShortDescription
        {
            get => _shortDescription;
            set => _shortDescription = Set("shortDescription", value);
        }

        /// <summary>
        /// The display name of the shop article category.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCategoryCreateInput"/> class without providing the required values.
        /// </summary>
        public ShopArticleCategoryCreateInput()
        {
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCategoryCreateInput"/> class.
        /// </summary>
        public ShopArticleCategoryCreateInput(string name)
        {
            _name = Set("name", name);
        }
    }
}
