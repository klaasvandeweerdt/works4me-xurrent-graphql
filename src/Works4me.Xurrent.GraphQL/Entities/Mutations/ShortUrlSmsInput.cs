using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shorturlsmsinput/">ShortUrlSmsInput</see> in Xurrent.
    /// </summary>
    public sealed class ShortUrlSmsInput : PropertyChangeSet
    {
        private string _body;
        private string _tel;

        /// <summary>
        /// Text of the SMS message.
        /// </summary>
        [XurrentField("body")]
        public string Body
        {
            get => _body;
            set => _body = Set("body", value);
        }

        /// <summary>
        /// Telephone number of the recipient of the SMS message.
        /// </summary>
        [XurrentField("tel")]
        public string Tel
        {
            get => _tel;
            set => _tel = Set("tel", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlSmsInput"/> class without providing the required values.
        /// </summary>
        public ShortUrlSmsInput()
        {
            _body = string.Empty;
            _tel = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlSmsInput"/> class.
        /// </summary>
        public ShortUrlSmsInput(string body, string tel)
        {
            _body = Set("body", body);
            _tel = Set("tel", tel);
        }
    }
}
