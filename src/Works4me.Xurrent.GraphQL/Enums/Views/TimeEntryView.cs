using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on TimeEntries.
    /// </summary>
    public enum TimeEntryView
    {
        /// <summary>
        /// Time Entries.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All TimeEntries which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
