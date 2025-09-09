using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/workflowtypeupdateinput/">WorkflowTypeUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class WorkflowTypeUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _description;
        private bool? _disabled;
        private string? _information;
        private Collection<AttachmentInput>? _informationAttachments;
        private string? _name;
        private long? _position;
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
        /// Very short description of the workflow type, for example "More than 200 workdays or $200K".
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// Whether the workflow type may not be related to any more workflows.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Any additional information about the workflow type that might prove useful, especially for workflow managers when they need to decide which workflow type to select for a workflow.
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
        /// The name of the workflow type. Ideally the name of a workflow type consists of a single word, such as "Large".
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The position that the workflow type takes when it is displayed in a sorted list.
        /// </summary>
        [XurrentField("position")]
        public long? Position
        {
            get => _position;
            set => _position = Set("position", value);
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
        /// Initializes a new instance of the <see cref="WorkflowTypeUpdateInput"/> class without providing the required values.
        /// </summary>
        public WorkflowTypeUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTypeUpdateInput"/> class.
        /// </summary>
        public WorkflowTypeUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
