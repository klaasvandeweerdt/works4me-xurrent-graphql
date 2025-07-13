using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which OutOfOfficePeriod records are returned.
    /// </summary>
    public enum OutOfOfficePeriodFilterField
    {
        /// <summary>
        /// Filter on Business unit.
        /// </summary>
        [XurrentEnum("businessUnitOrganization")]
        BusinessUnitOrganization,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// End in supplied range.
        /// </summary>
        [XurrentEnum("endAt")]
        EndAt,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Organization.
        /// </summary>
        [XurrentEnum("organization")]
        Organization,

        /// <summary>
        /// Filter on Organization region.
        /// </summary>
        [XurrentEnum("organizationRegion")]
        OrganizationRegion,

        /// <summary>
        /// Filter on Person.
        /// </summary>
        [XurrentEnum("person")]
        Person,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Filter on Source ID.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Start in supplied range.
        /// </summary>
        [XurrentEnum("startAt")]
        StartAt,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
