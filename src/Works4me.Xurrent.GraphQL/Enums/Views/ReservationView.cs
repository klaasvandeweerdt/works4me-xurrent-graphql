using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Reservations.
    /// </summary>
    public enum ReservationView
    {
        /// <summary>
        /// All Reservations.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Reservations which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// My Reservations.
        /// </summary>
        [XurrentEnum("personal")]
        Personal
    }
}
