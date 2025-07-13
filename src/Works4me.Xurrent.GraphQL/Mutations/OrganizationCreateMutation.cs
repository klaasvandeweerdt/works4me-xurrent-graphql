namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new organization.
    /// </summary>
    internal sealed class OrganizationCreateMutation : Mutation<OrganizationCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the organization mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal OrganizationCreateMutation(OrganizationCreateInput data, OrganizationQuery query)
            : base("organizationCreate", "OrganizationCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "organization")))
        {
        }
    }
}
