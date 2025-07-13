using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields ConfigurationItem can be ordered on.
    /// </summary>
    public enum ConfigurationItemOrderField
    {
        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>Label</c>.
        /// </summary>
        [XurrentEnum("label")]
        Label,

        /// <summary>
        /// Order by <c>LicenseExpiryDate</c>.
        /// </summary>
        [XurrentEnum("licenseExpiryDate")]
        LicenseExpiryDate,

        /// <summary>
        /// Order by <c>Name</c>.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Order by <c>RuleSet</c>.
        /// </summary>
        [XurrentEnum("ruleSet")]
        RuleSet,

        /// <summary>
        /// Order by <c>SiteName</c>.
        /// </summary>
        [XurrentEnum("siteName")]
        SiteName,

        /// <summary>
        /// Order by <c>Software</c>.
        /// </summary>
        [XurrentEnum("software")]
        Software,

        /// <summary>
        /// Order by <c>Status</c>.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Order by <c>SupportTeamName</c>.
        /// </summary>
        [XurrentEnum("supportTeamName")]
        SupportTeamName,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Order by <c>WarrantyExpiryDate</c>.
        /// </summary>
        [XurrentEnum("warrantyExpiryDate")]
        WarrantyExpiryDate
    }
}
