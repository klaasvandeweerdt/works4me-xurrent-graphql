namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new custom collection.
    /// </summary>
    internal sealed class CustomCollectionCreateMutation : Mutation<CustomCollectionCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollectionCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the custom collection mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal CustomCollectionCreateMutation(CustomCollectionCreateInput data, CustomCollectionQuery query)
            : base("customCollectionCreate", "CustomCollectionCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "customCollection")))
        {
        }
    }
}
