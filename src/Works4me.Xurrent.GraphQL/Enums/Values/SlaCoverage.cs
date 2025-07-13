using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The sla coverage values.
    /// </summary>
    public enum SlaCoverage
    {
        /// <summary>
        /// People using c is of the service instance.
        /// </summary>
        [XurrentEnum("cis_of_service_instance")]
        CisOfServiceInstance,

        /// <summary>
        /// People of the following coverage group s.
        /// </summary>
        [XurrentEnum("coverage_groups")]
        CoverageGroups,

        /// <summary>
        /// All people of customer account.
        /// </summary>
        [XurrentEnum("customer_account")]
        CustomerAccount,

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
        /// People of an organization and site from the following.
        /// </summary>
        [XurrentEnum("organizations_and_sites")]
        OrganizationsAndSites,

        /// <summary>
        /// People selected below.
        /// </summary>
        [XurrentEnum("people")]
        People,

        /// <summary>
        /// Members of support teams of the following service instances.
        /// </summary>
        [XurrentEnum("service_instances")]
        ServiceInstances,

        /// <summary>
        /// People of the following site s.
        /// </summary>
        [XurrentEnum("sites")]
        Sites,

        /// <summary>
        /// Members of the following skill pool s.
        /// </summary>
        [XurrentEnum("skill_pools")]
        SkillPools
    }
}
