using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which ConfigurationItem records are returned.
    /// </summary>
    public enum ConfigurationItemFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Include only if Status matches supplied value.
        /// </summary>
        [XurrentEnum("active")]
        Active,

        /// <summary>
        /// Filter on Alternate name.
        /// </summary>
        [XurrentEnum("alternateName")]
        AlternateName,

        /// <summary>
        /// Filter on Asset ID.
        /// </summary>
        [XurrentEnum("assetID")]
        AssetID,

        /// <summary>
        /// Filter on Contract.
        /// </summary>
        [XurrentEnum("contract")]
        Contract,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// End of support date in supplied range.
        /// </summary>
        [XurrentEnum("endOfSupportDate")]
        EndOfSupportDate,

        /// <summary>
        /// Filter on Financial owner.
        /// </summary>
        [XurrentEnum("financialOwner")]
        FinancialOwner,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// In use since in supplied range.
        /// </summary>
        [XurrentEnum("inUseSince")]
        InUseSince,

        /// <summary>
        /// Filter on Label.
        /// </summary>
        [XurrentEnum("label")]
        Label,

        /// <summary>
        /// Last seen in supplied range.
        /// </summary>
        [XurrentEnum("lastSeenAt")]
        LastSeenAt,

        /// <summary>
        /// License expiry date in supplied range.
        /// </summary>
        [XurrentEnum("licenseExpiryDate")]
        LicenseExpiryDate,

        /// <summary>
        /// Filter on Location.
        /// </summary>
        [XurrentEnum("location")]
        Location,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Filter on Operating system.
        /// </summary>
        [XurrentEnum("operatingSystem")]
        OperatingSystem,

        /// <summary>
        /// Filter on Product.
        /// </summary>
        [XurrentEnum("product")]
        Product,

        /// <summary>
        /// Filter on Product brand.
        /// </summary>
        [XurrentEnum("productBrand")]
        ProductBrand,

        /// <summary>
        /// Filter on Product category.
        /// </summary>
        [XurrentEnum("productCategory")]
        ProductCategory,

        /// <summary>
        /// Filter on Product model.
        /// </summary>
        [XurrentEnum("productModel")]
        ProductModel,

        /// <summary>
        /// Filter on RAM amount.
        /// </summary>
        [XurrentEnum("ramAmount")]
        RamAmount,

        /// <summary>
        /// Filter on Rule set.
        /// </summary>
        [XurrentEnum("ruleSet")]
        RuleSet,

        /// <summary>
        /// Filter on Serial number.
        /// </summary>
        [XurrentEnum("serialNr")]
        SerialNr,

        /// <summary>
        /// Filter on Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// Filter on Service instance.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// Filter on Service owner.
        /// </summary>
        [XurrentEnum("serviceOwner")]
        ServiceOwner,

        /// <summary>
        /// Filter on Site.
        /// </summary>
        [XurrentEnum("site")]
        Site,

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
        /// Filter on Status.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Filter on Supplier.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// Filter on Support account.
        /// </summary>
        [XurrentEnum("supportAccount")]
        SupportAccount,

        /// <summary>
        /// Filter on Support team.
        /// </summary>
        [XurrentEnum("supportTeam")]
        SupportTeam,

        /// <summary>
        /// Filter on System ID.
        /// </summary>
        [XurrentEnum("systemID")]
        SystemID,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Filter on User.
        /// </summary>
        [XurrentEnum("user")]
        User,

        /// <summary>
        /// Filter on User organization.
        /// </summary>
        [XurrentEnum("userOrganization")]
        UserOrganization,

        /// <summary>
        /// Warranty expiry date in supplied range.
        /// </summary>
        [XurrentEnum("warrantyExpiryDate")]
        WarrantyExpiryDate
    }
}
