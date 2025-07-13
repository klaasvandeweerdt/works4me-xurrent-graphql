using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/notereactioncreateinput/">NoteReactionCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class NoteReactionCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string _noteId;
        private string _reaction;

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
        /// The identifier of the note you want to add a reaction to.
        /// </summary>
        [XurrentField("noteId")]
        public string NoteId
        {
            get => _noteId;
            set => _noteId = Set("noteId", value);
        }

        /// <summary>
        /// The type of reaction to add to the note. Valid values are:<br />
        ///   • 👍.<br />
        ///   • 👎.<br />
        ///   • 😀.<br />
        ///   • 😕.<br />
        ///   • 🎉.<br />
        ///   • ❤️.<br />
        /// </summary>
        [XurrentField("reaction")]
        public string Reaction
        {
            get => _reaction;
            set => _reaction = Set("reaction", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteReactionCreateInput"/> class without providing the required values.
        /// </summary>
        public NoteReactionCreateInput()
        {
            _noteId = string.Empty;
            _reaction = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteReactionCreateInput"/> class.
        /// </summary>
        public NoteReactionCreateInput(string noteId, string reaction)
        {
            _noteId = Set("noteId", noteId);
            _reaction = Set("reaction", reaction);
        }
    }
}
