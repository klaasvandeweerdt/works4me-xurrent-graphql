using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Holiday"/> query class.
    /// </summary>
    public class HolidayQuery : Query<Holiday, HolidayQuery, DefaultView, HolidayField, HolidayFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="HolidayQuery"/> instance.
        /// </summary>
        public HolidayQuery() : base("holidays", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="HolidayQuery"/>, updated to include the "Account" sub-query.</returns>
        public HolidayQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Calendars of the holiday.
        /// </summary>
        /// <param name="query">The calendars query.</param>
        /// <returns>The same <see cref="HolidayQuery"/>, updated to include the "Calendars" sub-query.</returns>
        public HolidayQuery SelectCalendars(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("calendars", query, true);
        }
    }
}
