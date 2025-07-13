using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields AppInstance can be ordered on.
    /// </summary>
    public enum AppInstanceOrderField
    {
        /// <summary>
        /// Order by <c>AccountName</c>.
        /// </summary>
        [XurrentEnum("accountName")]
        AccountName,

        /// <summary>
        /// Order by <c>AppOfferingReference</c>.
        /// </summary>
        [XurrentEnum("appOfferingReference")]
        AppOfferingReference,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>CustomerAccountName</c>.
        /// </summary>
        [XurrentEnum("customerAccountName")]
        CustomerAccountName,

        /// <summary>
        /// Order by <c>UpdatedAt</c>.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
