using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/reservationcreatepayload/">ReservationCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ReservationCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("reservation", IsDefaultQueryProperty = true)]
        public Reservation? Reservation { get; internal set; }
    }
}
