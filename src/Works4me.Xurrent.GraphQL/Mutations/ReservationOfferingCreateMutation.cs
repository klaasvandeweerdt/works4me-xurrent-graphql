namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new reservation offering.
    /// </summary>
    internal sealed class ReservationOfferingCreateMutation : Mutation<ReservationOfferingCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationOfferingCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ReservationOfferingCreateMutation(ReservationOfferingCreateInput data, ReservationOfferingQuery query)
            : base("reservationOfferingCreate", "ReservationOfferingCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "reservationOffering")))
        {
        }
    }
}
