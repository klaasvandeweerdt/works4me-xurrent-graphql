using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Snapshot">Snapshot</see> fields.
    /// </summary>
    public enum SnapshotField
    {
        /// <summary>
        /// The download url field.
        /// </summary>
        [XurrentEnum("downloadUrl")]
        DownloadUrl,

        /// <summary>
        /// The started at field.
        /// </summary>
        [XurrentEnum("startedAt")]
        StartedAt
    }
}
