using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Contract records are returned.
    /// </summary>
    public enum ContractFilterField
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
        /// Filter on Category.
        /// </summary>
        [XurrentEnum("category")]
        Category,

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
        /// Filter on Supplier.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
