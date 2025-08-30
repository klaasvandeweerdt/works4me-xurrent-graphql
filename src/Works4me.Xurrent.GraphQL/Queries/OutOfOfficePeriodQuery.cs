using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="OutOfOfficePeriod"/> query class.
    /// </summary>
    public class OutOfOfficePeriodQuery : Query<OutOfOfficePeriod, OutOfOfficePeriodQuery, OutOfOfficePeriodView, OutOfOfficePeriodField, OutOfOfficePeriodFilterField, OutOfOfficePeriodOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="OutOfOfficePeriodQuery"/> instance.
        /// </summary>
        public OutOfOfficePeriodQuery() : base("outOfOfficePeriods", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="OutOfOfficePeriodQuery"/>, updated to include the "Account" sub-query.</returns>
        public OutOfOfficePeriodQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The person who is selected as the approval delegate for the out of office period.
        /// </summary>
        /// <param name="query">The approval delegate query.</param>
        /// <returns>The same <see cref="OutOfOfficePeriodQuery"/>, updated to include the "ApprovalDelegate" sub-query.</returns>
        public OutOfOfficePeriodQuery SelectApprovalDelegate(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("approvalDelegate", query, false);
        }

        /// <summary>
        /// The Effort class field is used to generate time entries for the out of office period. This field is applicable if the timesheet settings linked to the person's organization has one or more effort classes.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>The same <see cref="OutOfOfficePeriodQuery"/>, updated to include the "EffortClass" sub-query.</returns>
        public OutOfOfficePeriodQuery SelectEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClass", query, false);
        }

        /// <summary>
        /// The person who is out of office.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>The same <see cref="OutOfOfficePeriodQuery"/>, updated to include the "Person" sub-query.</returns>
        public OutOfOfficePeriodQuery SelectPerson(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("person", query, false);
        }

        /// <summary>
        /// Used to generate time entries for the out of office period. Only the time allocations without service and customer that are linked to the person's organization can be selected. This field is required if at least one time allocation exists that meets those conditions.
        /// </summary>
        /// <param name="query">The time allocation query.</param>
        /// <returns>The same <see cref="OutOfOfficePeriodQuery"/>, updated to include the "TimeAllocation" sub-query.</returns>
        public OutOfOfficePeriodQuery SelectTimeAllocation(TimeAllocationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("timeAllocation", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="OutOfOfficePeriodQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="OutOfOfficePeriodQuery">OutOfOfficePeriodQuery</see>, updated to include the "Search" sub-query.</returns>
        public OutOfOfficePeriodQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
