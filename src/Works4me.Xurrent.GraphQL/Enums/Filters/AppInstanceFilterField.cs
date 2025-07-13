using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which AppInstance records are returned.
    /// </summary>
    public enum AppInstanceFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Filter on App offering.
        /// </summary>
        [XurrentEnum("appOffering")]
        AppOffering,

        /// <summary>
        /// Filter on App offering reference.
        /// </summary>
        [XurrentEnum("appOfferingReference")]
        AppOfferingReference,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Filter on Customer account.
        /// </summary>
        [XurrentEnum("customerAccount")]
        CustomerAccount,

        /// <summary>
        /// Filter on Customer representative.
        /// </summary>
        [XurrentEnum("customerRepresentative")]
        CustomerRepresentative,

        /// <summary>
        /// Include only if Disabled matches supplied value.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Include only if Enabled by customer matches supplied value.
        /// </summary>
        [XurrentEnum("enabledByCustomer")]
        EnabledByCustomer,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Service instance.
        /// </summary>
        [XurrentEnum("serviceInstance")]
        ServiceInstance,

        /// <summary>
        /// Include only if Suspended matches supplied value.
        /// </summary>
        [XurrentEnum("suspended")]
        Suspended,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
