using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Reservation can be ordered on.
    /// </summary>
    public enum ReservationOrderField
    {
        /// <summary>
        /// Order by <c>CiName</c>.
        /// </summary>
        [XurrentEnum("ciName")]
        CiName,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>EndAt</c>.
        /// </summary>
        [XurrentEnum("endAt")]
        EndAt,

        /// <summary>
        /// Order by <c>Name</c>.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Order by <c>PersonName</c>.
        /// </summary>
        [XurrentEnum("personName")]
        PersonName,

        /// <summary>
        /// Order by <c>StartAt</c>.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt,

        /// <summary>
        /// Order by <c>Status</c>.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
