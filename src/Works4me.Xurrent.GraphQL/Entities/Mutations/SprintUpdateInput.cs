using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/sprintupdateinput/">SprintUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class SprintUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private DateTime? _endAt;
        private long? _number;
        private string? _scrumWorkspaceId;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private DateTime? _startAt;
        private SprintStatus? _status;
        private Collection<SprintBacklogItemInput>? _newSprintBacklogItems;
        private string _id;
        private Collection<string>? _sprintBacklogItemsToDelete;

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
        /// The date and time the sprint ended, or will end.
        /// </summary>
        [XurrentField("endAt")]
        public DateTime? EndAt
        {
            get => _endAt;
            set => _endAt = Set("endAt", value);
        }

        /// <summary>
        /// Sequence number of this sprint.
        /// </summary>
        [XurrentField("number")]
        public long? Number
        {
            get => _number;
            set => _number = Set("number", value);
        }

        /// <summary>
        /// Identifier of scrum workspace this sprint belongs to.
        /// </summary>
        [XurrentField("scrumWorkspaceId")]
        public string? ScrumWorkspaceId
        {
            get => _scrumWorkspaceId;
            set => _scrumWorkspaceId = Set("scrumWorkspaceId", value);
        }

        /// <summary>
        /// Description of this sprint (e.g. goal of the sprint).
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
        /// The date and time the sprint started, or will start.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt
        {
            get => _startAt;
            set => _startAt = Set("startAt", value);
        }

        /// <summary>
        /// The current status of the sprint.
        /// </summary>
        [XurrentField("status")]
        public SprintStatus? Status
        {
            get => _status;
            set => _status = Set("status", value);
        }

        /// <summary>
        /// Sprint backlog items of this sprint.
        /// </summary>
        [XurrentField("newSprintBacklogItems")]
        public Collection<SprintBacklogItemInput>? NewSprintBacklogItems
        {
            get => _newSprintBacklogItems;
            set => _newSprintBacklogItems = Set("newSprintBacklogItems", value);
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
        /// Identifiers of sprint backlog items to remove from the sprint.
        /// </summary>
        [XurrentField("sprintBacklogItemsToDelete")]
        public Collection<string>? SprintBacklogItemsToDelete
        {
            get => _sprintBacklogItemsToDelete;
            set => _sprintBacklogItemsToDelete = Set("sprintBacklogItemsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SprintUpdateInput"/> class without providing the required values.
        /// </summary>
        public SprintUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SprintUpdateInput"/> class.
        /// </summary>
        public SprintUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
