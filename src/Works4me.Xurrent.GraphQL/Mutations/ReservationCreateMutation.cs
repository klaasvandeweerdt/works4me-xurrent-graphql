namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new reservation.
    /// </summary>
    internal sealed class ReservationCreateMutation : Mutation<ReservationCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the reservation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ReservationCreateMutation(ReservationCreateInput data, ReservationQuery query)
            : base("reservationCreate", "ReservationCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "reservation")))
        {
        }
    }
}
