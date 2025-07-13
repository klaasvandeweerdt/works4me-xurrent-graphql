using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Invoice records are returned.
    /// </summary>
    public enum InvoiceFilterField
    {
        /// <summary>
        /// Amortization end in supplied range.
        /// </summary>
        [XurrentEnum("amortizationEnd")]
        AmortizationEnd,

        /// <summary>
        /// Amortization start in supplied range.
        /// </summary>
        [XurrentEnum("amortizationStart")]
        AmortizationStart,

        /// <summary>
        /// Include only if Amortize matches supplied value.
        /// </summary>
        [XurrentEnum("amortize")]
        Amortize,

        /// <summary>
        /// Filter on Configuration item.
        /// </summary>
        [XurrentEnum("ci")]
        Ci,

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
        /// Depreciation start in supplied range.
        /// </summary>
        [XurrentEnum("depreciationStart")]
        DepreciationStart,

        /// <summary>
        /// Filter on Description.
        /// </summary>
        [XurrentEnum("description")]
        Description,

        /// <summary>
        /// Filter on Financial ID.
        /// </summary>
        [XurrentEnum("financialID")]
        FinancialID,

        /// <summary>
        /// Filter on First line support agreement.
        /// </summary>
        [XurrentEnum("flsa")]
        Flsa,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Invoice date in supplied range.
        /// </summary>
        [XurrentEnum("invoiceDate")]
        InvoiceDate,

        /// <summary>
        /// Filter on Invoice number.
        /// </summary>
        [XurrentEnum("invoiceNr")]
        InvoiceNr,

        /// <summary>
        /// Filter on Type.
        /// </summary>
        [XurrentEnum("invoiceType")]
        InvoiceType,

        /// <summary>
        /// Filter on PO number.
        /// </summary>
        [XurrentEnum("poNr")]
        PoNr,

        /// <summary>
        /// Filter on Project.
        /// </summary>
        [XurrentEnum("project")]
        Project,

        /// <summary>
        /// Filter on Service.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// Filter on Service level agreement.
        /// </summary>
        [XurrentEnum("sla")]
        Sla,

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
        /// Filter on Supplier.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// Filter on Useful life.
        /// </summary>
        [XurrentEnum("usefulLife")]
        UsefulLife,

        /// <summary>
        /// Filter on Workflow.
        /// </summary>
        [XurrentEnum("workflow")]
        Workflow
    }
}
