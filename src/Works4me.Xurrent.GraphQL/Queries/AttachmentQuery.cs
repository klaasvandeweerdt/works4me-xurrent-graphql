using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Attachment"/> query class.
    /// </summary>
    public class AttachmentQuery : Query<Attachment, AttachmentQuery, DefaultView, AttachmentField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AttachmentQuery"/> instance.
        /// </summary>
        public AttachmentQuery() : base(string.Empty, true)
        {
        }
    }
}
