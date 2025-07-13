using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AttachmentStorage"/> query class.
    /// </summary>
    public class AttachmentStorageQuery : Query<AttachmentStorage, AttachmentStorageQuery, DefaultView, AttachmentStorageField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AttachmentStorageQuery"/> instance.
        /// </summary>
        public AttachmentStorageQuery() : base("attachmentStorage", false)
        {
        }
    }
}
