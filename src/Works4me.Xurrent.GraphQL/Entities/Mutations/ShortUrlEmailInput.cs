using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shorturlemailinput/">ShortUrlEmailInput</see> in Xurrent.
    /// </summary>
    public sealed class ShortUrlEmailInput : PropertyChangeSet
    {
        private string _body;
        private string _subject;
        private string _to;

        /// <summary>
        /// Body of the email.
        /// </summary>
        [XurrentField("body")]
        public string Body
        {
            get => _body;
            set => _body = Set("body", value);
        }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        [XurrentField("subject")]
        public string Subject
        {
            get => _subject;
            set => _subject = Set("subject", value);
        }

        /// <summary>
        /// Email address of the recipient of the email.
        /// </summary>
        [XurrentField("to")]
        public string To
        {
            get => _to;
            set => _to = Set("to", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlEmailInput"/> class without providing the required values.
        /// </summary>
        public ShortUrlEmailInput()
        {
            _body = string.Empty;
            _subject = string.Empty;
            _to = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlEmailInput"/> class.
        /// </summary>
        public ShortUrlEmailInput(string body, string subject, string to)
        {
            _body = Set("body", body);
            _subject = Set("subject", subject);
            _to = Set("to", to);
        }
    }
}
