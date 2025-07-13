using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Problem can be ordered on.
    /// </summary>
    public enum ProblemOrderField
    {
        /// <summary>
        /// Order by <c>AnalysisTargetAt</c>.
        /// </summary>
        [XurrentEnum("analysisTargetAt")]
        AnalysisTargetAt,

        /// <summary>
        /// Order by <c>Category</c>.
        /// </summary>
        [XurrentEnum("category")]
        Category,

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
        /// Order by <c>KnownError</c>.
        /// </summary>
        [XurrentEnum("knownError")]
        KnownError,

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
        /// Order by <c>SolvedAt</c>.
        /// </summary>
        [XurrentEnum("solvedAt")]
        SolvedAt,

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
        Urgent,

        /// <summary>
        /// Order by <c>WorkflowId</c>.
        /// </summary>
        [XurrentEnum("workflowId")]
        WorkflowId
    }
}
