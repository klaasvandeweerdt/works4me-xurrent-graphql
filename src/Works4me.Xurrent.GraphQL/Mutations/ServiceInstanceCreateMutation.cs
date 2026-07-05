namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new service instance.
    /// </summary>
    internal sealed class ServiceInstanceCreateMutation : Mutation<ServiceInstanceCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInstanceCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceInstanceCreateMutation(ServiceInstanceCreateInput data, ServiceInstanceQuery? query)
            : base("serviceInstanceCreate", "ServiceInstanceCreateInput!", data, query is null ? new ServiceInstanceCreatePayloadQuery() : new ServiceInstanceCreatePayloadQuery().Select(UpdateQuery(query, "serviceInstance")))
        {
        }
    }
}
