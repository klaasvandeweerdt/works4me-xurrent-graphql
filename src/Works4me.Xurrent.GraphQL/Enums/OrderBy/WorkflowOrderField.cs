using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Workflow can be ordered on.
    /// </summary>
    public enum WorkflowOrderField
    {
        /// <summary>
        /// Order by <c>ActualEffort</c>.
        /// </summary>
        [XurrentEnum("actualEffort")]
        ActualEffort,

        /// <summary>
        /// Order by <c>ActualVsPlannedEffortPercentage</c>.
        /// </summary>
        [XurrentEnum("actualVsPlannedEffortPercentage")]
        ActualVsPlannedEffortPercentage,

        /// <summary>
        /// Order by <c>Category</c>.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// Order by <c>CompletedAt</c>.
        /// </summary>
        [XurrentEnum("completedAt")]
        CompletedAt,

        /// <summary>
        /// Order by <c>CompletionReason</c>.
        /// </summary>
        [XurrentEnum("completionReason")]
        CompletionReason,

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
        /// Order by <c>Impact</c>.
        /// </summary>
        [XurrentEnum("impact")]
        Impact,

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
        /// Order by <c>PlannedEffort</c>.
        /// </summary>
        [XurrentEnum("plannedEffort")]
        PlannedEffort,

        /// <summary>
        /// Order by <c>ServiceName</c>.
        /// </summary>
        [XurrentEnum("serviceName")]
        ServiceName,

        /// <summary>
        /// Order by <c>Subject</c>.
        /// </summary>
        [XurrentEnum("subject")]
        Subject,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Order by <c>WorkflowId</c>.
        /// </summary>
        [XurrentEnum("workflowId")]
        WorkflowId
    }
}
