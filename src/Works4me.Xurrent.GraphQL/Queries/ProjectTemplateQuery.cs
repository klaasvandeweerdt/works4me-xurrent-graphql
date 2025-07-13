using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTemplate"/> query class.
    /// </summary>
    public class ProjectTemplateQuery : Query<ProjectTemplate, ProjectTemplateQuery, ProjectTemplateView, ProjectTemplateField, ProjectTemplateFilterField, ProjectTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectTemplateQuery"/> instance.
        /// </summary>
        public ProjectTemplateQuery() : base("projectTemplates", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ProjectTemplateQuery"/>, updated to include the "Account" sub-query.</returns>
        public ProjectTemplateQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Phases of the project template.
        /// </summary>
        /// <param name="query">The phases query.</param>
        /// <returns>The same <see cref="ProjectTemplateQuery"/>, updated to include the "Phases" sub-query.</returns>
        public ProjectTemplateQuery SelectPhases(ProjectTemplatePhaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("phases", query, true);
        }

        /// <summary>
        /// Task template relations of the project template.
        /// </summary>
        /// <param name="query">The task template relations query.</param>
        /// <returns>The same <see cref="ProjectTemplateQuery"/>, updated to include the "TaskTemplateRelations" sub-query.</returns>
        public ProjectTemplateQuery SelectTaskTemplateRelations(ProjectTaskTemplateRelationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("taskTemplateRelations", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ProjectTemplateQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ProjectTemplateQuery">ProjectTemplateQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public ProjectTemplateQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
