using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The life cycle state values.
    /// </summary>
    public enum LifeCycleState
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
        /// Erased.
        /// </summary>
        [XurrentEnum("erased")]
        Erased,

        /// <summary>
        /// Trashed.
        /// </summary>
        [XurrentEnum("trashed")]
        Trashed
    }
}
