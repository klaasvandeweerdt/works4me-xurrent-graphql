using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The note visibility values.
    /// </summary>
    public enum NoteVisibility
    {
        /// <summary>
        /// Audit.
        /// </summary>
        [XurrentEnum("audit")]
        Audit,

        /// <summary>
        /// End user.
        /// </summary>
        [XurrentEnum("end_user")]
        EndUser,

        /// <summary>
        /// Specialist.
        /// </summary>
        [XurrentEnum("specialist")]
        Specialist
    }
}
