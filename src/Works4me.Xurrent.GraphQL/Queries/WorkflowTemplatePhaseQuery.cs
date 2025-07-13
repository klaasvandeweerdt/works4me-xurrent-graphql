using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTemplatePhase"/> query class.
    /// </summary>
    public class WorkflowTemplatePhaseQuery : Query<WorkflowTemplatePhase, WorkflowTemplatePhaseQuery, DefaultView, WorkflowTemplatePhaseField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="WorkflowTemplatePhaseQuery"/> instance.
        /// </summary>
        public WorkflowTemplatePhaseQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="WorkflowTemplatePhaseQuery"/>, updated to include the "Translations" sub-query.</returns>
        public WorkflowTemplatePhaseQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }
    }
}
