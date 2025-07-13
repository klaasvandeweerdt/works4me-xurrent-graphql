namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new app offering.
    /// </summary>
    internal sealed class AppOfferingCreateMutation : Mutation<AppOfferingCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AppOfferingCreateMutation(AppOfferingCreateInput data, AppOfferingQuery query)
            : base("appOfferingCreate", "AppOfferingCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "appOffering")))
        {
        }
    }
}
