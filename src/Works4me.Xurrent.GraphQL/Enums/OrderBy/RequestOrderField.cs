using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Request can be ordered on.
    /// </summary>
    public enum RequestOrderField
    {
        /// <summary>
        /// Order by <c>Addressed</c>.
        /// </summary>
        [XurrentEnum("addressed")]
        Addressed,

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
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>DowntimeEndAt</c>.
        /// </summary>
        [XurrentEnum("downtimeEndAt")]
        DowntimeEndAt,

        /// <summary>
        /// Order by <c>DowntimeStartAt</c>.
        /// </summary>
        [XurrentEnum("downtimeStartAt")]
        DowntimeStartAt,

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
        /// Order by <c>MajorIncidentStatus</c>.
        /// </summary>
        [XurrentEnum("majorIncidentStatus")]
        MajorIncidentStatus,

        /// <summary>
        /// Order by <c>MemberName</c>.
        /// </summary>
        [XurrentEnum("memberName")]
        MemberName,

        /// <summary>
        /// Order by <c>NextTargetAt</c>.
        /// </summary>
        [XurrentEnum("nextTargetAt")]
        NextTargetAt,

        /// <summary>
        /// Order by <c>ProblemId</c>.
        /// </summary>
        [XurrentEnum("problemId")]
        ProblemId,

        /// <summary>
        /// Order by <c>ProjectId</c>.
        /// </summary>
        [XurrentEnum("projectId")]
        ProjectId,

        /// <summary>
        /// Order by <c>RequestedForName</c>.
        /// </summary>
        [XurrentEnum("requestedForName")]
        RequestedForName,

        /// <summary>
        /// Order by <c>RequestId</c>.
        /// </summary>
        [XurrentEnum("requestId")]
        RequestId,

        /// <summary>
        /// Order by <c>Reviewed</c>.
        /// </summary>
        [XurrentEnum("reviewed")]
        Reviewed,

        /// <summary>
        /// Order by <c>ServiceInstanceName</c>.
        /// </summary>
        [XurrentEnum("serviceInstanceName")]
        ServiceInstanceName,

        /// <summary>
        /// Order by <c>Source</c>.
        /// </summary>
        [XurrentEnum("source")]
        Source,

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
        /// Order by <c>TeamName</c>.
        /// </summary>
        [XurrentEnum("teamName")]
        TeamName,

        /// <summary>
        /// Order by <c>TimeSpentOnRequest</c>.
        /// </summary>
        [XurrentEnum("timeSpentOnRequest")]
        TimeSpentOnRequest,

        /// <summary>
        /// Order by <c>TimeSpentOnRequestAndWorkflow</c>.
        /// </summary>
        [XurrentEnum("timeSpentOnRequestAndWorkflow")]
        TimeSpentOnRequestAndWorkflow,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Order by <c>Urgent</c>.
        /// </summary>
        [XurrentEnum("urgent")]
        Urgent,

        /// <summary>
        /// Order by <c>WorkflowId</c>.
        /// </summary>
        [XurrentEnum("workflowId")]
        WorkflowId
    }
}
