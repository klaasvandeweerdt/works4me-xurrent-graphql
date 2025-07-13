namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new broadcast.
    /// </summary>
    internal sealed class BroadcastCreateMutation : Mutation<BroadcastCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the broadcast mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal BroadcastCreateMutation(BroadcastCreateInput data, BroadcastQuery query)
            : base("broadcastCreate", "BroadcastCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "broadcast")))
        {
        }
    }
}
