using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Period"/> query class.
    /// </summary>
    public class PeriodQuery : Query<Period, PeriodQuery, DefaultView, PeriodField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="PeriodQuery"/> instance.
        /// </summary>
        public PeriodQuery() : base(string.Empty, false)
        {
        }
    }
}
