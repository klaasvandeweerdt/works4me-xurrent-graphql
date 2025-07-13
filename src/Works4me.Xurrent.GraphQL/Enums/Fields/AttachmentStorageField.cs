using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AttachmentStorage">AttachmentStorage</see> fields.
    /// </summary>
    public enum AttachmentStorageField
    {
        /// <summary>
        /// The allowed extensions field.
        /// </summary>
        [XurrentEnum("allowedExtensions")]
        AllowedExtensions,

        /// <summary>
        /// The provider field.
        /// </summary>
        [XurrentEnum("provider")]
        Provider,

        /// <summary>
        /// The provider parameters field.
        /// </summary>
        [XurrentEnum("providerParameters")]
        ProviderParameters,

        /// <summary>
        /// The size limit field.
        /// </summary>
        [XurrentEnum("sizeLimit")]
        SizeLimit,

        /// <summary>
        /// The upload uri field.
        /// </summary>
        [XurrentEnum("uploadUri")]
        UploadUri
    }
}
