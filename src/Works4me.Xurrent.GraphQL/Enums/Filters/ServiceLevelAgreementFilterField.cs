using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which ServiceLevelAgreement records are returned.
    /// </summary>
    public enum ServiceLevelAgreementFilterField
    {
        /// <summary>
        /// Filter on Account.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// Filter on Coverage.
        /// </summary>
        [XurrentEnum("coverage")]
        Coverage,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Filter on Customer.
        /// </summary>
        [XurrentEnum("customer")]
        Customer,

        /// <summary>
        /// Filter on Customer account.
        /// </summary>
        [XurrentEnum("customerAccount")]
        CustomerAccount,

        /// <summary>
        /// Filter on Customer representative.
        /// </summary>
        [XurrentEnum("customerRep")]
        CustomerRep,

        /// <summary>
        /// Expiry date in supplied range.
        /// </summary>
        [XurrentEnum("expiryDate")]
        ExpiryDate,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Notice date in supplied range.
        /// </summary>
        [XurrentEnum("noticeDate")]
        NoticeDate,

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
        /// Filter on Service level manager.
        /// </summary>
        [XurrentEnum("serviceLevelManager")]
        ServiceLevelManager,

        /// <summary>
        /// Filter on Service offering.
        /// </summary>
        [XurrentEnum("serviceOffering")]
        ServiceOffering,

        /// <summary>
        /// Filter on Service owner.
        /// </summary>
        [XurrentEnum("serviceOwner")]
        ServiceOwner,

        /// <summary>
        /// Filter on Service provider.
        /// </summary>
        [XurrentEnum("serviceProvider")]
        ServiceProvider,

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
        /// Start date in supplied range.
        /// </summary>
        [XurrentEnum("startDate")]
        StartDate,

        /// <summary>
        /// Filter on Status.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Filter on Support domain.
        /// </summary>
        [XurrentEnum("supportDomain")]
        SupportDomain,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
