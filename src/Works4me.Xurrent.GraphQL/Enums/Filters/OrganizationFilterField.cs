using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Organization records are returned.
    /// </summary>
    public enum OrganizationFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Include only if Business unit matches supplied value.
        /// </summary>
        [XurrentEnum("businessUnit")]
        BusinessUnit,

        /// <summary>
        /// Filter on Business Unit Organization.
        /// </summary>
        [XurrentEnum("businessUnitOrganization")]
        BusinessUnitOrganization,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Include only if Disabled matches supplied value.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Filter on Financial ID.
        /// </summary>
        [XurrentEnum("financialID")]
        FinancialID,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Manager.
        /// </summary>
        [XurrentEnum("manager")]
        Manager,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Filter on Region.
        /// </summary>
        [XurrentEnum("organizationRegion")]
        OrganizationRegion,

        /// <summary>
        /// Filter on Parent organization.
        /// </summary>
        [XurrentEnum("parent")]
        Parent,

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
        /// Filter on Substitute.
        /// </summary>
        [XurrentEnum("substitute")]
        Substitute,

        /// <summary>
        /// Filter on Supported by.
        /// </summary>
        [XurrentEnum("supportedBy")]
        SupportedBy,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
