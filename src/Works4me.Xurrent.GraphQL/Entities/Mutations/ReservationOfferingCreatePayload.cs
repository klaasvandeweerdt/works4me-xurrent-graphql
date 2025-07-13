using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/reservationofferingcreatepayload/">ReservationOfferingCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ReservationOfferingCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("reservationOffering", IsDefaultQueryProperty = true)]
        public ReservationOffering? ReservationOffering { get; internal set; }
    }
}
