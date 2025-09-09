using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/scrumworkspaceupdateinput/">ScrumWorkspaceUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ScrumWorkspaceUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private string? _agileBoardId;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private bool? _disabled;
        private string? _name;
        private string? _productBacklogId;
        private long? _sprintLength;
        private string? _teamId;
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
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Identifier of the agile board used to track the progress of this workspace's active sprint.
        /// </summary>
        [XurrentField("agileBoardId")]
        public string? AgileBoardId
        {
            get => _agileBoardId;
            set => _agileBoardId = Set("agileBoardId", value);
        }

        /// <summary>
        /// Additional information regarding the scrum workspace.
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
        /// Whether the scrum workspace is in use.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Name of the scrum workspace.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Identifier of the product backlog used when planning sprints.
        /// </summary>
        [XurrentField("productBacklogId")]
        public string? ProductBacklogId
        {
            get => _productBacklogId;
            set => _productBacklogId = Set("productBacklogId", value);
        }

        /// <summary>
        /// Standard length in weeks of new sprints planned in this scrum workspace.
        /// </summary>
        [XurrentField("sprintLength")]
        public long? SprintLength
        {
            get => _sprintLength;
            set => _sprintLength = Set("sprintLength", value);
        }

        /// <summary>
        /// Identifier of the team planning their work using this scrum workspace.
        /// </summary>
        [XurrentField("teamId")]
        public string? TeamId
        {
            get => _teamId;
            set => _teamId = Set("teamId", value);
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
        /// Initializes a new instance of the <see cref="ScrumWorkspaceUpdateInput"/> class without providing the required values.
        /// </summary>
        public ScrumWorkspaceUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrumWorkspaceUpdateInput"/> class.
        /// </summary>
        public ScrumWorkspaceUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
