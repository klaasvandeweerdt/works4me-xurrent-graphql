using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Risk can be ordered on.
    /// </summary>
    public enum RiskOrderField
    {
        /// <summary>
        /// Order by <c>ClosedAt</c>.
        /// </summary>
        [XurrentEnum("closedAt")]
        ClosedAt,

        /// <summary>
        /// Order by <c>ClosureReason</c>.
        /// </summary>
        [XurrentEnum("closureReason")]
        ClosureReason,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>LifeCycleState</c>.
        /// </summary>
        [XurrentEnum("lifeCycleState")]
        LifeCycleState,

        /// <summary>
        /// Order by <c>ManagerName</c>.
        /// </summary>
        [XurrentEnum("managerName")]
        ManagerName,

        /// <summary>
        /// Order by <c>MitigationTargetAt</c>.
        /// </summary>
        [XurrentEnum("mitigationTargetAt")]
        MitigationTargetAt,

        /// <summary>
        /// Order by <c>Severity</c>.
        /// </summary>
        [XurrentEnum("severity")]
        Severity,

        /// <summary>
        /// Order by <c>Status</c>.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Order by <c>Subject</c>.
        /// </summary>
        [XurrentEnum("subject")]
        Subject,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
