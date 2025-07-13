namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing custom collection.
    /// </summary>
    internal sealed class CustomCollectionUpdateMutation : Mutation<CustomCollectionUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollectionUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal CustomCollectionUpdateMutation(CustomCollectionUpdateInput data, CustomCollectionQuery query)
            : base("customCollectionUpdate", "CustomCollectionUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "customCollection")))
        {
        }
    }
}
