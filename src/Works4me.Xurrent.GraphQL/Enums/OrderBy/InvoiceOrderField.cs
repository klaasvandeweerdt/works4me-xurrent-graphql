using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Fields Invoice can be ordered on.
    /// </summary>
    public enum InvoiceOrderField
    {
        /// <summary>
        /// Order by <c>AmortizationEnd</c>.
        /// </summary>
        [XurrentEnum("amortizationEnd")]
        AmortizationEnd,

        /// <summary>
        /// Order by <c>AmortizationStart</c>.
        /// </summary>
        [XurrentEnum("amortizationStart")]
        AmortizationStart,

        /// <summary>
        /// Order by <c>Amount</c>.
        /// </summary>
        [XurrentEnum("amount")]
        Amount,

        /// <summary>
        /// Order by <c>CreatedAt</c>.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Order by <c>InvoiceDate</c>.
        /// </summary>
        [XurrentEnum("invoiceDate")]
        InvoiceDate,

        /// <summary>
        /// Order by <c>InvoiceNr</c>.
        /// </summary>
        [XurrentEnum("invoiceNr")]
        InvoiceNr,

        /// <summary>
        /// Order by <c>ServiceName</c>.
        /// </summary>
        [XurrentEnum("serviceName")]
        ServiceName,

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
