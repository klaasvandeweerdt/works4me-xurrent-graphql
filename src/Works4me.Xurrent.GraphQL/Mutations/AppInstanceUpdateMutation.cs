namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing app instance.
    /// </summary>
    internal sealed class AppInstanceUpdateMutation : Mutation<AppInstanceUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInstanceUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AppInstanceUpdateMutation(AppInstanceUpdateInput data, AppInstanceQuery query)
            : base("appInstanceUpdate", "AppInstanceUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "appInstance")))
        {
        }
    }
}
