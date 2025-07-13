using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Contract">Contract</see> fields.
    /// </summary>
    public enum ContractField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The category field.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The custom fields field.
        /// </summary>
        [XurrentEnum("customFields")]
        CustomFields,

        /// <summary>
        /// The customer field.
        /// </summary>
        [XurrentEnum("customer")]
        Customer,

        /// <summary>
        /// The customer account field.
        /// </summary>
        [XurrentEnum("customerAccount")]
        CustomerAccount,

        /// <summary>
        /// The customer representative field.
        /// </summary>
        [XurrentEnum("customerRepresentative")]
        CustomerRepresentative,

        /// <summary>
        /// The expiry date field.
        /// </summary>
        [XurrentEnum("expiryDate")]
        ExpiryDate,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The notice date field.
        /// </summary>
        [XurrentEnum("noticeDate")]
        NoticeDate,

        /// <summary>
        /// The remarks field.
        /// </summary>
        [XurrentEnum("remarks")]
        Remarks,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The start date field.
        /// </summary>
        [XurrentEnum("startDate")]
        StartDate,

        /// <summary>
        /// The status field.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// The supplier field.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// The supplier contact field.
        /// </summary>
        [XurrentEnum("supplierContact")]
        SupplierContact,

        /// <summary>
        /// The time zone field.
        /// </summary>
        [XurrentEnum("timeZone")]
        TimeZone,

        /// <summary>
        /// The ui extension field.
        /// </summary>
        [XurrentEnum("uiExtension")]
        UiExtension,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
