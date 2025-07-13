namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new custom collection element.
    /// </summary>
    internal sealed class CustomCollectionElementCreateMutation : Mutation<CustomCollectionElementCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollectionElementCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the custom collection element mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal CustomCollectionElementCreateMutation(CustomCollectionElementCreateInput data, CustomCollectionElementQuery query)
            : base("customCollectionElementCreate", "CustomCollectionElementCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "customCollectionElement")))
        {
        }
    }
}
