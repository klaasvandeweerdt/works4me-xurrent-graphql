using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/translationcreateinput/">TranslationCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class TranslationCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string _field;
        private string _language;
        private string _ownerId;
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
        /// The field of the record from which the translation is obtained.
        /// </summary>
        [XurrentField("field")]
        public string Field
        {
            get => _field;
            set => _field = Set("field", value);
        }

        /// <summary>
        /// The language in which the text is specified.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/language/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("language")]
        public string Language
        {
            get => _language;
            set => _language = Set("language", value);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        [XurrentField("ownerId")]
        public string OwnerId
        {
            get => _ownerId;
            set => _ownerId = Set("ownerId", value);
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
        /// Initializes a new instance of the <see cref="TranslationCreateInput"/> class without providing the required values.
        /// </summary>
        public TranslationCreateInput()
        {
            _field = string.Empty;
            _language = string.Empty;
            _ownerId = string.Empty;
            _text = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationCreateInput"/> class.
        /// </summary>
        public TranslationCreateInput(string @field, string language, string ownerId, string text)
        {
            _field = Set("field", @field);
            _language = Set("language", language);
            _ownerId = Set("ownerId", ownerId);
            _text = Set("text", text);
        }
    }
}
