using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskAssignment"/> query class.
    /// </summary>
    public class ProjectTaskAssignmentQuery : Query<ProjectTaskAssignment, ProjectTaskAssignmentQuery, DefaultView, ProjectTaskAssignmentField, ProjectTaskAssignmentFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProjectTaskAssignmentQuery"/> instance.
        /// </summary>
        public ProjectTaskAssignmentQuery() : base("projectTaskAssignments", true)
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

        /// <summary>
        /// The project task to which the assignment belongs.
        /// </summary>
        /// <param name="query">The task query.</param>
        /// <returns>The same <see cref="ProjectTaskAssignmentQuery"/>, updated to include the "Task" sub-query.</returns>
        public ProjectTaskAssignmentQuery SelectTask(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("task", query, false);
        }
    }
}
