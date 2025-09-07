using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/notecreateinput/">NoteCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class NoteCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string _text;
        private Collection<AttachmentInput>? _attachments;
        private bool? _internal;
        private bool? _suppressNoteAddedNotifications;
        private string _ownerId;

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
        /// Text of the note.
        /// </summary>
        [XurrentField("text")]
        public string Text
        {
            get => _text;
            set => _text = Set("text", value);
        }

        /// <summary>
        /// The attachments used in the <c>note</c> field.
        /// </summary>
        [XurrentField("attachments")]
        public Collection<AttachmentInput>? Attachments
        {
            get => _attachments;
            set => _attachments = Set("attachments", value);
        }

        /// <summary>
        /// Whether the note should be visible only for people who have the Auditor, Specialist or Account Administrator role of the account. Internal notes are only available for Requests.
        /// </summary>
        [XurrentField("internal")]
        public bool? Internal
        {
            get => _internal;
            set => _internal = Set("internal", value);
        }

        /// <summary>
        /// Whether Note Added notifications for this note should be suppressed.
        /// </summary>
        [XurrentField("suppressNoteAddedNotifications")]
        public bool? SuppressNoteAddedNotifications
        {
            get => _suppressNoteAddedNotifications;
            set => _suppressNoteAddedNotifications = Set("suppressNoteAddedNotifications", value);
        }

        /// <summary>
        /// The record that the note should be added to.
        /// </summary>
        [XurrentField("ownerId")]
        public string OwnerId
        {
            get => _ownerId;
            set => _ownerId = Set("ownerId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteCreateInput"/> class without providing the required values.
        /// </summary>
        public NoteCreateInput()
        {
            _text = string.Empty;
            _ownerId = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteCreateInput"/> class.
        /// </summary>
        public NoteCreateInput(string text, string ownerId)
        {
            _text = Set("text", text);
            _ownerId = Set("ownerId", ownerId);
        }
    }
}
