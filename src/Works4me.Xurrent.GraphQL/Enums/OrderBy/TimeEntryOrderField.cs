using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields TimeEntry can be ordered on.
    /// </summary>
    public enum TimeEntryOrderField
    {
        /// <summary>
        /// Order by <c>AssignmentSubject</c>.
        /// </summary>
        [XurrentEnum("assignmentSubject")]
        AssignmentSubject,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Date</c>.
        /// </summary>
        [XurrentEnum("date")]
        Date,

        /// <summary>
        /// Order by <c>PersonName</c>.
        /// </summary>
        [XurrentEnum("personName")]
        PersonName,

        /// <summary>
        /// Order by <c>StartedAt</c>.
        /// </summary>
        [XurrentEnum("startedAt")]
        StartedAt,

        /// <summary>
        /// Order by <c>TimeAllocationName</c>.
        /// </summary>
        [XurrentEnum("timeAllocationName")]
        TimeAllocationName,

        /// <summary>
        /// Order by <c>TimeSpent</c>.
        /// </summary>
        [XurrentEnum("timeSpent")]
        TimeSpent,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
