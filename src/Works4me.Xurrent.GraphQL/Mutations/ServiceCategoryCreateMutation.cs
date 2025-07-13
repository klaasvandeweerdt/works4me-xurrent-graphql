namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new service category.
    /// </summary>
    internal sealed class ServiceCategoryCreateMutation : Mutation<ServiceCategoryCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCategoryCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceCategoryCreateMutation(ServiceCategoryCreateInput data, ServiceCategoryQuery query)
            : base("serviceCategoryCreate", "ServiceCategoryCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "serviceCategory")))
        {
        }
    }
}
