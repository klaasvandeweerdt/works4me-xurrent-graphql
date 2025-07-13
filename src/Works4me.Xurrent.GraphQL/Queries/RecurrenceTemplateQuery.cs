using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="RecurrenceTemplate"/> query class.
    /// </summary>
    public class RecurrenceTemplateQuery : Query<RecurrenceTemplate, RecurrenceTemplateQuery, DefaultView, RecurrenceTemplateField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="RecurrenceTemplateQuery"/> instance.
        /// </summary>
        public RecurrenceTemplateQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// Select a calendar to skip occurrences of the recurrence during off-hours and holidays.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>The same <see cref="RecurrenceTemplateQuery"/>, updated to include the "Calendar" sub-query.</returns>
        public RecurrenceTemplateQuery SelectCalendar(CalendarQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("calendar", query, false);
        }
    }
}
