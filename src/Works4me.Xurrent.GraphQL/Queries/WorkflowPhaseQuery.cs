using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowPhase"/> query class.
    /// </summary>
    public class WorkflowPhaseQuery : Query<WorkflowPhase, WorkflowPhaseQuery, DefaultView, WorkflowPhaseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WorkflowPhaseQuery"/> instance.
        /// </summary>
        public WorkflowPhaseQuery() : base(string.Empty, false)
        {
        }
    }
}
