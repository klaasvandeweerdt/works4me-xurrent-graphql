using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The product category rule set values.
    /// </summary>
    public enum ProductCategoryRuleSet
    {
        /// <summary>
        /// License certificate.
        /// </summary>
        [XurrentEnum("license_certificate")]
        LicenseCertificate,

        /// <summary>
        /// Logical asset with financial data.
        /// </summary>
        [XurrentEnum("logical_asset_with_financial_data")]
        LogicalAssetWithFinancialData,

        /// <summary>
        /// Logical asset without financial data.
        /// </summary>
        [XurrentEnum("logical_asset_without_financial_data")]
        LogicalAssetWithoutFinancialData,

        /// <summary>
        /// Physical asset.
        /// </summary>
        [XurrentEnum("physical_asset")]
        PhysicalAsset,

        /// <summary>
        /// Server.
        /// </summary>
        [XurrentEnum("server")]
        Server,

        /// <summary>
        /// Software.
        /// </summary>
        [XurrentEnum("software")]
        Software,

        /// <summary>
        /// Software distribution package.
        /// </summary>
        [XurrentEnum("software_distribution_package")]
        SoftwareDistributionPackage
    }
}
