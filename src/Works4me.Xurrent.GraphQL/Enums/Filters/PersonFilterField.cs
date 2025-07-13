using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Person records are returned.
    /// </summary>
    public enum PersonFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Filter on Authentication ID.
        /// </summary>
        [XurrentEnum("authenticationID")]
        AuthenticationID,

        /// <summary>
        /// Include only if Billable matches supplied value.
        /// </summary>
        [XurrentEnum("billable")]
        Billable,

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
        /// Include only if Disabled matches supplied value.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Filter on Employee ID.
        /// </summary>
        [XurrentEnum("employeeID")]
        EmployeeID,

        /// <summary>
        /// Include only if Guest matches supplied value.
        /// </summary>
        [XurrentEnum("guest")]
        Guest,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Job title.
        /// </summary>
        [XurrentEnum("jobTitle")]
        JobTitle,

        /// <summary>
        /// Filter on Location.
        /// </summary>
        [XurrentEnum("location")]
        Location,

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
        /// Filter on Organization.
        /// </summary>
        [XurrentEnum("organization")]
        Organization,

        /// <summary>
        /// Filter on Primary Email.
        /// </summary>
        [XurrentEnum("primaryEmail")]
        PrimaryEmail,

        /// <summary>
        /// Filter on Role.
        /// </summary>
        [XurrentEnum("role")]
        Role,

        /// <summary>
        /// Filter on Site.
        /// </summary>
        [XurrentEnum("site")]
        Site,

        /// <summary>
        /// Filter on Skill pool.
        /// </summary>
        [XurrentEnum("skillPool")]
        SkillPool,

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
        /// Filter on Support ID.
        /// </summary>
        [XurrentEnum("supportID")]
        SupportID,

        /// <summary>
        /// Filter on Team.
        /// </summary>
        [XurrentEnum("team")]
        Team,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Include only if VIP matches supplied value.
        /// </summary>
        [XurrentEnum("vip")]
        Vip
    }
}
