using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Person can be ordered on.
    /// </summary>
    public enum PersonOrderField
    {
        /// <summary>
        /// Order by <c>AuthenticationID</c>.
        /// </summary>
        [XurrentEnum("authenticationID")]
        AuthenticationID,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Disabled</c>.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Order by <c>EmployeeID</c>.
        /// </summary>
        [XurrentEnum("employeeID")]
        EmployeeID,

        /// <summary>
        /// Order by <c>LifeCycleState</c>.
        /// </summary>
        [XurrentEnum("lifeCycleState")]
        LifeCycleState,

        /// <summary>
        /// Order by <c>Name</c>.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Order by <c>OrganizationName</c>.
        /// </summary>
        [XurrentEnum("organizationName")]
        OrganizationName,

        /// <summary>
        /// Order by <c>SiteName</c>.
        /// </summary>
        [XurrentEnum("siteName")]
        SiteName,

        /// <summary>
        /// Order by <c>SupportID</c>.
        /// </summary>
        [XurrentEnum("supportID")]
        SupportID,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Order by <c>Vip</c>.
        /// </summary>
        [XurrentEnum("vip")]
        Vip
    }
}
