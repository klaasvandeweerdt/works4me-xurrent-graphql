namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// An attachment upload response.
    /// </summary>
    public sealed class AttachmentUploadResponse
    {
        /// <summary>
        /// The S3 file storage reference key.
        /// </summary>
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// The file size.
        /// </summary>
        public long Size { get; set; }
    }
}
