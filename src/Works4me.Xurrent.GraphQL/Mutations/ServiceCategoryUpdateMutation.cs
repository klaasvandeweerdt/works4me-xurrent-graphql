namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing service category.
    /// </summary>
    internal sealed class ServiceCategoryUpdateMutation : Mutation<ServiceCategoryUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCategoryUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service category mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceCategoryUpdateMutation(ServiceCategoryUpdateInput data, ServiceCategoryQuery query)
            : base("serviceCategoryUpdate", "ServiceCategoryUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "serviceCategory")))
        {
        }
    }
}
