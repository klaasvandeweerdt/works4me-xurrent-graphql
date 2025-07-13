using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on OutOfOfficePeriods.
    /// </summary>
    public enum OutOfOfficePeriodView
    {
        /// <summary>
        /// All Out of Office Periods.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All OutOfOfficePeriods which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// My Out of Office Periods.
        /// </summary>
        [XurrentEnum("personal")]
        Personal
    }
}
