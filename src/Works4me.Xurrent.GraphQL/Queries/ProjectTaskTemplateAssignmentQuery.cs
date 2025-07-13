using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskTemplateAssignment"/> query class.
    /// </summary>
    public class ProjectTaskTemplateAssignmentQuery : Query<ProjectTaskTemplateAssignment, ProjectTaskTemplateAssignmentQuery, DefaultView, ProjectTaskTemplateAssignmentField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectTaskTemplateAssignmentQuery"/> instance.
        /// </summary>
        public ProjectTaskTemplateAssignmentQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The person who is selected as the assignee for the project task template assignment.
        /// </summary>
        /// <param name="query">The assignee query.</param>
        /// <returns>The same <see cref="ProjectTaskTemplateAssignmentQuery"/>, updated to include the "Assignee" sub-query.</returns>
        public ProjectTaskTemplateAssignmentQuery SelectAssignee(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("assignee", query, false);
        }
    }
}
