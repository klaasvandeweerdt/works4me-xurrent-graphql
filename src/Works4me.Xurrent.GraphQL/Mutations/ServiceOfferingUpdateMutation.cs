namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing service offering.
    /// </summary>
    internal sealed class ServiceOfferingUpdateMutation : Mutation<ServiceOfferingUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOfferingUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceOfferingUpdateMutation(ServiceOfferingUpdateInput data, ServiceOfferingQuery query)
            : base("serviceOfferingUpdate", "ServiceOfferingUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "serviceOffering")))
        {
        }
    }
}
