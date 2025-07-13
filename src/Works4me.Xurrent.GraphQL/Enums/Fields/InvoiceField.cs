using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Invoice">Invoice</see> fields.
    /// </summary>
    public enum InvoiceField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The amortization end field.
        /// </summary>
        [XurrentEnum("amortizationEnd")]
        AmortizationEnd,

        /// <summary>
        /// The amortization start field.
        /// </summary>
        [XurrentEnum("amortizationStart")]
        AmortizationStart,

        /// <summary>
        /// The amortize field.
        /// </summary>
        [XurrentEnum("amortize")]
        Amortize,

        /// <summary>
        /// The amount field.
        /// </summary>
        [XurrentEnum("amount")]
        Amount,

        /// <summary>
        /// The contract field.
        /// </summary>
        [XurrentEnum("contract")]
        Contract,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The currency field.
        /// </summary>
        [XurrentEnum("currency")]
        Currency,

        /// <summary>
        /// The depreciation method field.
        /// </summary>
        [XurrentEnum("depreciationMethod")]
        DepreciationMethod,

        /// <summary>
        /// The depreciation start field.
        /// </summary>
        [XurrentEnum("depreciationStart")]
        DepreciationStart,

        /// <summary>
        /// The description field.
        /// </summary>
        [XurrentEnum("description")]
        Description,

        /// <summary>
        /// The financial id field.
        /// </summary>
        [XurrentEnum("financialID")]
        FinancialID,

        /// <summary>
        /// The flsa field.
        /// </summary>
        [XurrentEnum("flsa")]
        Flsa,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The invoice date field.
        /// </summary>
        [XurrentEnum("invoiceDate")]
        InvoiceDate,

        /// <summary>
        /// The invoice nr field.
        /// </summary>
        [XurrentEnum("invoiceNr")]
        InvoiceNr,

        /// <summary>
        /// The po nr field.
        /// </summary>
        [XurrentEnum("poNr")]
        PoNr,

        /// <summary>
        /// The project field.
        /// </summary>
        [XurrentEnum("project")]
        Project,

        /// <summary>
        /// The quantity field.
        /// </summary>
        [XurrentEnum("quantity")]
        Quantity,

        /// <summary>
        /// The rate field.
        /// </summary>
        [XurrentEnum("rate")]
        Rate,

        /// <summary>
        /// The remarks field.
        /// </summary>
        [XurrentEnum("remarks")]
        Remarks,

        /// <summary>
        /// The salvage value field.
        /// </summary>
        [XurrentEnum("salvageValue")]
        SalvageValue,

        /// <summary>
        /// The salvage value currency field.
        /// </summary>
        [XurrentEnum("salvageValueCurrency")]
        SalvageValueCurrency,

        /// <summary>
        /// The service field.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// The sla field.
        /// </summary>
        [XurrentEnum("sla")]
        Sla,

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
        /// The supplier field.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// The unit price field.
        /// </summary>
        [XurrentEnum("unitPrice")]
        UnitPrice,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The useful life field.
        /// </summary>
        [XurrentEnum("usefulLife")]
        UsefulLife,

        /// <summary>
        /// The workflow field.
        /// </summary>
        [XurrentEnum("workflow")]
        Workflow
    }
}
