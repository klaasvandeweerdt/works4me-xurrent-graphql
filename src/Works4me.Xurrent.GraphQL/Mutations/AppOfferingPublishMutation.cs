namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new, published, app offering based on the current state of a draft app offering.
    /// </summary>
    internal sealed class AppOfferingPublishMutation : Mutation<AppOfferingPublishMutationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingPublishMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the app offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal AppOfferingPublishMutation(AppOfferingPublishMutationInput data, AppOfferingQuery query)
            : base("appOfferingPublish", "AppOfferingPublishMutationInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "appOffering")))
        {
        }
    }
}
