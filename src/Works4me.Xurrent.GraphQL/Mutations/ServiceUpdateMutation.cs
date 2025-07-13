namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing service.
    /// </summary>
    internal sealed class ServiceUpdateMutation : Mutation<ServiceUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceUpdateMutation(ServiceUpdateInput data, ServiceQuery query)
            : base("serviceUpdate", "ServiceUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "service")))
        {
        }
    }
}
