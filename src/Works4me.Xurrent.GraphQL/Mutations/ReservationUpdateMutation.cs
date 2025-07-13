namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing reservation.
    /// </summary>
    internal sealed class ReservationUpdateMutation : Mutation<ReservationUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ReservationUpdateMutation(ReservationUpdateInput data, ReservationQuery query)
            : base("reservationUpdate", "ReservationUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "reservation")))
        {
        }
    }
}
