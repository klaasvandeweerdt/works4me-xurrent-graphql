using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="CalendarHour"/> query class.
    /// </summary>
    public class CalendarHourQuery : Query<CalendarHour, CalendarHourQuery, DefaultView, CalendarHourField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="CalendarHourQuery"/> instance.
        /// </summary>
        public CalendarHourQuery() : base(string.Empty, true)
        {
        }
    }
}
