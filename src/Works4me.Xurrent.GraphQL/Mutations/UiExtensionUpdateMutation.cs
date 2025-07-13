namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing UI extension.
    /// </summary>
    internal sealed class UiExtensionUpdateMutation : Mutation<UiExtensionUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UiExtensionUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal UiExtensionUpdateMutation(UiExtensionUpdateInput data, UiExtensionQuery query)
            : base("uiExtensionUpdate", "UiExtensionUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "uiExtension")))
        {
        }
    }
}
