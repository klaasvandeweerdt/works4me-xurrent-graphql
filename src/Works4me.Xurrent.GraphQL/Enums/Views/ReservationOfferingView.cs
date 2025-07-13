using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on ReservationOfferings.
    /// </summary>
    public enum ReservationOfferingView
    {
        /// <summary>
        /// Reservation Offerings.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All ReservationOfferings which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
