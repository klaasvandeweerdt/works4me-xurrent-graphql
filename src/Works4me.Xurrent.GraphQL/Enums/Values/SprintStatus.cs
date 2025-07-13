using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The sprint status values.
    /// </summary>
    public enum SprintStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [XurrentEnum("active")]
        Active,

        /// <summary>
        /// Completed.
        /// </summary>
        [XurrentEnum("completed")]
        Completed,

        /// <summary>
        /// Registered.
        /// </summary>
        [XurrentEnum("registered")]
        Registered
    }
}
