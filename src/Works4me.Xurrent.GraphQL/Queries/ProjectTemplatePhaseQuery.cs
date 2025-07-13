using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTemplatePhase"/> query class.
    /// </summary>
    public class ProjectTemplatePhaseQuery : Query<ProjectTemplatePhase, ProjectTemplatePhaseQuery, DefaultView, ProjectTemplatePhaseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectTemplatePhaseQuery"/> instance.
        /// </summary>
        public ProjectTemplatePhaseQuery() : base(string.Empty, true)
        {
        }
    }
}
