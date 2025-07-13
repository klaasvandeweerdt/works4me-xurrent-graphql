using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Calendar"/> query class.
    /// </summary>
    public class CalendarQuery : Query<Calendar, CalendarQuery, DefaultView, CalendarField, CalendarFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="CalendarQuery"/> instance.
        /// </summary>
        public CalendarQuery() : base("calendars", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="CalendarQuery"/>, updated to include the "Account" sub-query.</returns>
        public CalendarQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Calendar hours of the calendar.
        /// </summary>
        /// <param name="query">The calendar hours query.</param>
        /// <returns>The same <see cref="CalendarQuery"/>, updated to include the "CalendarHours" sub-query.</returns>
        public CalendarQuery SelectCalendarHours(CalendarHourQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("calendarHours", query, true);
        }

        /// <summary>
        /// Holidays of the calendar.
        /// </summary>
        /// <param name="query">The holidays query.</param>
        /// <returns>The same <see cref="CalendarQuery"/>, updated to include the "Holidays" sub-query.</returns>
        public CalendarQuery SelectHolidays(HolidayQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("holidays", query, true);
        }
    }
}
