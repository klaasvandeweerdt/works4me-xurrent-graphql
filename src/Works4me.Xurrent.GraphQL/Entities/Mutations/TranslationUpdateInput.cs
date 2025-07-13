using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/translationupdateinput/">TranslationUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class TranslationUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string _id;
        private string _text;

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
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// The text of the translation.
        /// </summary>
        [XurrentField("text")]
        public string Text
        {
            get => _text;
            set => _text = Set("text", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationUpdateInput"/> class without providing the required values.
        /// </summary>
        public TranslationUpdateInput()
        {
            _id = string.Empty;
            _text = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationUpdateInput"/> class.
        /// </summary>
        public TranslationUpdateInput(string id, string text)
        {
            _id = Set("id", id);
            _text = Set("text", text);
        }
    }
}
