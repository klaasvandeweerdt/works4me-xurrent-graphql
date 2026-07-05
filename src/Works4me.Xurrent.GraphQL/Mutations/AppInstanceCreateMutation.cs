namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new app instance.
    /// </summary>
    internal sealed class AppInstanceCreateMutation : Mutation<AppInstanceCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInstanceCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the app instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AppInstanceCreateMutation(AppInstanceCreateInput data, AppInstanceQuery? query)
            : base("appInstanceCreate", "AppInstanceCreateInput!", data, query is null ? new AppInstanceCreatePayloadQuery() : new AppInstanceCreatePayloadQuery().Select(UpdateQuery(query, "appInstance")))
        {
        }
    }
}
