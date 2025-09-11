using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/attachmentinput/">AttachmentInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Key}")]
    public sealed class AttachmentInput : PropertyChangeSet
    {
        private bool? _inline;
        private string _key;
        private long? _size;

        /// <summary>
        /// Whether the attachment is an inline image.
        /// </summary>
        [XurrentField("inline")]
        public bool? Inline
        {
            get => _inline;
            set => _inline = Set("inline", value);
        }

        /// <summary>
        /// The key obtained from the attachment upload response.
        /// </summary>
        [XurrentField("key")]
        public string Key
        {
            get => _key;
            set => _key = Set("key", value);
        }

        /// <summary>
        /// The size of the attachment in bytes.
        /// </summary>
        [XurrentField("size")]
        public long? Size
        {
            get => _size;
            set => _size = Set("size", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentInput"/> class without providing the required values.
        /// </summary>
        public AttachmentInput()
        {
            _key = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentInput"/> class.
        /// </summary>
        public AttachmentInput(string key)
        {
            _key = Set("key", key);
        }
    }
}
