using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Task can be ordered on.
    /// </summary>
    public enum WorkflowTaskOrderField
    {
        /// <summary>
        /// Order by <c>AnticipatedAssignmentAt</c>.
        /// </summary>
        [XurrentEnum("anticipatedAssignmentAt")]
        AnticipatedAssignmentAt,

        /// <summary>
        /// Order by <c>AssignedAt</c>.
        /// </summary>
        [XurrentEnum("assignedAt")]
        AssignedAt,

        /// <summary>
        /// Order by <c>Category</c>.
        /// </summary>
        [XurrentEnum("category")]
        Category,

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
        /// Order by <c>FinishedAt</c>.
        /// </summary>
        [XurrentEnum("finishedAt")]
        FinishedAt,

        /// <summary>
        /// Order by <c>Impact</c>.
        /// </summary>
        [XurrentEnum("impact")]
        Impact,

        /// <summary>
        /// Order by <c>LifeCycleState</c>.
        /// </summary>
        [XurrentEnum("lifeCycleState")]
        LifeCycleState,

        /// <summary>
        /// Order by <c>MemberName</c>.
        /// </summary>
        [XurrentEnum("memberName")]
        MemberName,

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
        /// Order by <c>SupplierName</c>.
        /// </summary>
        [XurrentEnum("supplierName")]
        SupplierName,

        /// <summary>
        /// Order by <c>TaskId</c>.
        /// </summary>
        [XurrentEnum("taskId")]
        TaskId,

        /// <summary>
        /// Order by <c>TeamName</c>.
        /// </summary>
        [XurrentEnum("teamName")]
        TeamName,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Order by <c>Urgent</c>.
        /// </summary>
        [XurrentEnum("urgent")]
        Urgent
    }
}
