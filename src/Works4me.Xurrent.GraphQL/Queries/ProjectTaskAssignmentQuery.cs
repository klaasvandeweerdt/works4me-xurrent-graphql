using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskAssignment"/> query class.
    /// </summary>
    public class ProjectTaskAssignmentQuery : Query<ProjectTaskAssignment, ProjectTaskAssignmentQuery, DefaultView, ProjectTaskAssignmentField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectTaskAssignmentQuery"/> instance.
        /// </summary>
        public ProjectTaskAssignmentQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The person who is selected as the assignee for the assignment.
        /// </summary>
        /// <param name="query">The assignee query.</param>
        /// <returns>The same <see cref="ProjectTaskAssignmentQuery"/>, updated to include the "Assignee" sub-query.</returns>
        public ProjectTaskAssignmentQuery SelectAssignee(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("assignee", query, false);
        }
    }
}
