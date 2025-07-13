namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing broadcast.
    /// </summary>
    internal sealed class BroadcastUpdateMutation : Mutation<BroadcastUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal BroadcastUpdateMutation(BroadcastUpdateInput data, BroadcastQuery query)
            : base("broadcastUpdate", "BroadcastUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "broadcast")))
        {
        }
    }
}
