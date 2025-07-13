namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing service instance.
    /// </summary>
    internal sealed class ServiceInstanceUpdateMutation : Mutation<ServiceInstanceUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInstanceUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service instance mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceInstanceUpdateMutation(ServiceInstanceUpdateInput data, ServiceInstanceQuery query)
            : base("serviceInstanceUpdate", "ServiceInstanceUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "serviceInstance")))
        {
        }
    }
}
