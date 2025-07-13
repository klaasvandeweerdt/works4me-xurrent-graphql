namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new service offering.
    /// </summary>
    internal sealed class ServiceOfferingCreateMutation : Mutation<ServiceOfferingCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOfferingCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service offering mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceOfferingCreateMutation(ServiceOfferingCreateInput data, ServiceOfferingQuery query)
            : base("serviceOfferingCreate", "ServiceOfferingCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "serviceOffering")))
        {
        }
    }
}
