using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Recurrence"/> query class.
    /// </summary>
    public class RecurrenceQuery : Query<Recurrence, RecurrenceQuery, DefaultView, RecurrenceField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="RecurrenceQuery"/> instance.
        /// </summary>
        public RecurrenceQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// Select a calendar to skip occurrences of the recurrence during off-hours and holidays.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>The same <see cref="RecurrenceQuery"/>, updated to include the "Calendar" sub-query.</returns>
        public RecurrenceQuery SelectCalendar(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("calendar", query, false);
        }
    }
}
