namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing organization.
    /// </summary>
    internal sealed class OrganizationUpdateMutation : Mutation<OrganizationUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal OrganizationUpdateMutation(OrganizationUpdateInput data, OrganizationQuery query)
            : base("organizationUpdate", "OrganizationUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "organization")))
        {
        }
    }
}
