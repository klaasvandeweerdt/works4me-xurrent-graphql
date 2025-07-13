namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new UI extension.
    /// </summary>
    internal sealed class UiExtensionCreateMutation : Mutation<UiExtensionCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UiExtensionCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the ui extension mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal UiExtensionCreateMutation(UiExtensionCreateInput data, UiExtensionQuery query)
            : base("uiExtensionCreate", "UiExtensionCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "uiExtension")))
        {
        }
    }
}
