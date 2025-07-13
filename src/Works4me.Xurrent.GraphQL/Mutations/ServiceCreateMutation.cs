namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new service.
    /// </summary>
    internal sealed class ServiceCreateMutation : Mutation<ServiceCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceCreateMutation(ServiceCreateInput data, ServiceQuery query)
            : base("serviceCreate", "ServiceCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "service")))
        {
        }
    }
}
