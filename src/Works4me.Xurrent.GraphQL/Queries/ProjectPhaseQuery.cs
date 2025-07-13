using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectPhase"/> query class.
    /// </summary>
    public class ProjectPhaseQuery : Query<ProjectPhase, ProjectPhaseQuery, DefaultView, ProjectPhaseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectPhaseQuery"/> instance.
        /// </summary>
        public ProjectPhaseQuery() : base(string.Empty, true)
        {
        }
    }
}
