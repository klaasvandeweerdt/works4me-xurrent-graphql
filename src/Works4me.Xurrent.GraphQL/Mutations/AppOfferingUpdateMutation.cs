namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing app offering.
    /// </summary>
    internal sealed class AppOfferingUpdateMutation : Mutation<AppOfferingUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AppOfferingUpdateMutation(AppOfferingUpdateInput data, AppOfferingQuery query)
            : base("appOfferingUpdate", "AppOfferingUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "appOffering")))
        {
        }
    }
}
