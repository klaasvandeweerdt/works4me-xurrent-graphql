using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="EffortClass"/> query class.
    /// </summary>
    public class EffortClassQuery : Query<EffortClass, EffortClassQuery, DefaultView, EffortClassField, EffortClassFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="EffortClassQuery"/> instance.
        /// </summary>
        public EffortClassQuery() : base("effortClasses", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="EffortClassQuery"/>, updated to include the "Account" sub-query.</returns>
        public EffortClassQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Service offerings of this effort class.
        /// </summary>
        /// <param name="query">The service offerings query.</param>
        /// <returns>The same <see cref="EffortClassQuery"/>, updated to include the "ServiceOfferings" sub-query.</returns>
        public EffortClassQuery SelectServiceOfferings(ServiceOfferingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceOfferings", query, true);
        }

        /// <summary>
        /// Skill pools of this effort class.
        /// </summary>
        /// <param name="query">The skill pools query.</param>
        /// <returns>The same <see cref="EffortClassQuery"/>, updated to include the "SkillPools" sub-query.</returns>
        public EffortClassQuery SelectSkillPools(SkillPoolQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("skillPools", query, true);
        }

        /// <summary>
        /// Timesheet settings of this effort class.
        /// </summary>
        /// <param name="query">The timesheet settings query.</param>
        /// <returns>The same <see cref="EffortClassQuery"/>, updated to include the "TimesheetSettings" sub-query.</returns>
        public EffortClassQuery SelectTimesheetSettings(TimesheetSettingQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("timesheetSettings", query, true);
        }
    }
}
