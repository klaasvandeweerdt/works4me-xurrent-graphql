namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing custom collection element.
    /// </summary>
    internal sealed class CustomCollectionElementUpdateMutation : Mutation<CustomCollectionElementUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollectionElementUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal CustomCollectionElementUpdateMutation(CustomCollectionElementUpdateInput data, CustomCollectionElementQuery query)
            : base("customCollectionElementUpdate", "CustomCollectionElementUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "customCollectionElement")))
        {
        }
    }
}
