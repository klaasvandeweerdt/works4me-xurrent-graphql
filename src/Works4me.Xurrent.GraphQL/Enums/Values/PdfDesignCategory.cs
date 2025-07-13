using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The pdf design category values.
    /// </summary>
    public enum PdfDesignCategory
    {
        /// <summary>
        /// Dashboard.
        /// </summary>
        [XurrentEnum("dashboard")]
        Dashboard,

        /// <summary>
        /// Project summary.
        /// </summary>
        [XurrentEnum("project_summary")]
        ProjectSummary,

        /// <summary>
        /// Workflow summary.
        /// </summary>
        [XurrentEnum("workflow_summary")]
        WorkflowSummary
    }
}
