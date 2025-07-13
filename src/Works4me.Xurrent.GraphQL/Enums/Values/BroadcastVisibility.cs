using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The broadcast visibility values.
    /// </summary>
    public enum BroadcastVisibility
    {
        /// <summary>
        /// Account specialists.
        /// </summary>
        [XurrentEnum("account_specialists")]
        AccountSpecialists,

        /// <summary>
        /// All people registered in the account.
        /// </summary>
        [XurrentEnum("all_of_account")]
        AllOfAccount,

        /// <summary>
        /// People covered for the following service instance s.
        /// </summary>
        [XurrentEnum("covered_for")]
        CoveredFor,

        /// <summary>
        /// People covered for any of our service instances.
        /// </summary>
        [XurrentEnum("covered_for_any")]
        CoveredForAny,

        /// <summary>
        /// Customer representatives of the following service level agreement s.
        /// </summary>
        [XurrentEnum("customer_representatives_of_slas")]
        CustomerRepresentativesOfSlas,

        /// <summary>
        /// Specialists in requests from the following customers.
        /// </summary>
        [XurrentEnum("customers")]
        Customers,

        /// <summary>
        /// Members of the following skill pool s.
        /// </summary>
        [XurrentEnum("members_of_skill_pools")]
        MembersOfSkillPools,

        /// <summary>
        /// Members of the following team s.
        /// </summary>
        [XurrentEnum("members_of_teams")]
        MembersOfTeams,

        /// <summary>
        /// People of the following organization s.
        /// </summary>
        [XurrentEnum("organizations")]
        Organizations,

        /// <summary>
        /// People of the following organization s and their descendants.
        /// </summary>
        [XurrentEnum("organizations_and_descendants")]
        OrganizationsAndDescendants,

        /// <summary>
        /// People of the following site s.
        /// </summary>
        [XurrentEnum("sites")]
        Sites
    }
}
