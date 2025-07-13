namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing reservation offering.
    /// </summary>
    internal sealed class ReservationOfferingUpdateMutation : Mutation<ReservationOfferingUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationOfferingUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the reservation offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ReservationOfferingUpdateMutation(ReservationOfferingUpdateInput data, ReservationOfferingQuery query)
            : base("reservationOfferingUpdate", "ReservationOfferingUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "reservationOffering")))
        {
        }
    }
}
