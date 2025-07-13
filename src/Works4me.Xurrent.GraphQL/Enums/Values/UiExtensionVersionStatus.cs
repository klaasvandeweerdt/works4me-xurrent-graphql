using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The ui extension version status values.
    /// </summary>
    public enum UiExtensionVersionStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [XurrentEnum("active")]
        Active,

        /// <summary>
        /// Archived.
        /// </summary>
        [XurrentEnum("archived")]
        Archived,

        /// <summary>
        /// Being prepared.
        /// </summary>
        [XurrentEnum("being_prepared")]
        BeingPrepared
    }
}
