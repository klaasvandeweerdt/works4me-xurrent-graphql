using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Project can be ordered on.
    /// </summary>
    public enum ProjectOrderField
    {
        /// <summary>
        /// Order by <c>CompletedAt</c>.
        /// </summary>
        [XurrentEnum("completedAt")]
        CompletedAt,

        /// <summary>
        /// Order by <c>CompletionTargetAt</c>.
        /// </summary>
        [XurrentEnum("completionTargetAt")]
        CompletionTargetAt,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Justification</c>.
        /// </summary>
        [XurrentEnum("justification")]
        Justification,

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
        /// Order by <c>Program</c>.
        /// </summary>
        [XurrentEnum("program")]
        Program,

        /// <summary>
        /// Order by <c>ProjectId</c>.
        /// </summary>
        [XurrentEnum("projectId")]
        ProjectId,

        /// <summary>
        /// Order by <c>ServiceName</c>.
        /// </summary>
        [XurrentEnum("serviceName")]
        ServiceName,

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
