using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Archive can be ordered on.
    /// </summary>
    public enum ArchiveOrderField
    {
        /// <summary>
        /// Order by <c>ArchivedByName</c>.
        /// </summary>
        [XurrentEnum("archivedByName")]
        ArchivedByName,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Name</c>.
        /// </summary>
        [XurrentEnum("name")]
        Name
    }
}
