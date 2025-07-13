using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TimesheetSetting"/> query class.
    /// </summary>
    public class TimesheetSettingQuery : Query<TimesheetSetting, TimesheetSettingQuery, DefaultView, TimesheetSettingField, TimesheetSettingFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TimesheetSettingQuery"/> instance.
        /// </summary>
        public TimesheetSettingQuery() : base("timesheetSettings", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="TimesheetSettingQuery"/>, updated to include the "Account" sub-query.</returns>
        public TimesheetSettingQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Effort classes of the timesheet setting.
        /// </summary>
        /// <param name="query">The effort classes query.</param>
        /// <returns>The same <see cref="TimesheetSettingQuery"/>, updated to include the "EffortClasses" sub-query.</returns>
        public TimesheetSettingQuery SelectEffortClasses(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClasses", query, true);
        }

        /// <summary>
        /// Organizations of the timesheet setting.
        /// </summary>
        /// <param name="query">The organizations query.</param>
        /// <returns>The same <see cref="TimesheetSettingQuery"/>, updated to include the "Organizations" sub-query.</returns>
        public TimesheetSettingQuery SelectOrganizations(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("organizations", query, true);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a problem.
        /// </summary>
        /// <param name="query">The problem effort class query.</param>
        /// <returns>The same <see cref="TimesheetSettingQuery"/>, updated to include the "ProblemEffortClass" sub-query.</returns>
        public TimesheetSettingQuery SelectProblemEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("problemEffortClass", query, false);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a project task.
        /// </summary>
        /// <param name="query">The project task effort class query.</param>
        /// <returns>The same <see cref="TimesheetSettingQuery"/>, updated to include the "ProjectTaskEffortClass" sub-query.</returns>
        public TimesheetSettingQuery SelectProjectTaskEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("projectTaskEffortClass", query, false);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a request.
        /// </summary>
        /// <param name="query">The request effort class query.</param>
        /// <returns>The same <see cref="TimesheetSettingQuery"/>, updated to include the "RequestEffortClass" sub-query.</returns>
        public TimesheetSettingQuery SelectRequestEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("requestEffortClass", query, false);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a workflow task.
        /// </summary>
        /// <param name="query">The task effort class query.</param>
        /// <returns>The same <see cref="TimesheetSettingQuery"/>, updated to include the "TaskEffortClass" sub-query.</returns>
        public TimesheetSettingQuery SelectTaskEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("taskEffortClass", query, false);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a time allocation.
        /// </summary>
        /// <param name="query">The time allocation effort class query.</param>
        /// <returns>The same <see cref="TimesheetSettingQuery"/>, updated to include the "TimeAllocationEffortClass" sub-query.</returns>
        public TimesheetSettingQuery SelectTimeAllocationEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("timeAllocationEffortClass", query, false);
        }
    }
}
