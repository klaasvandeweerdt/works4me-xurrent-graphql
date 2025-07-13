using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Contract can be ordered on.
    /// </summary>
    public enum ContractOrderField
    {
        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>ExpiryDate</c>.
        /// </summary>
        [XurrentEnum("expiryDate")]
        ExpiryDate,

        /// <summary>
        /// Order by <c>Name</c>.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Order by <c>NoticeDate</c>.
        /// </summary>
        [XurrentEnum("noticeDate")]
        NoticeDate,

        /// <summary>
        /// Order by <c>StartDate</c>.
        /// </summary>
        [XurrentEnum("startDate")]
        StartDate,

        /// <summary>
        /// Order by <c>Status</c>.
        /// </summary>
        [XurrentEnum("status")]
        Status,

        /// <summary>
        /// Order by <c>SupplierName</c>.
        /// </summary>
        [XurrentEnum("supplierName")]
        SupplierName,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
