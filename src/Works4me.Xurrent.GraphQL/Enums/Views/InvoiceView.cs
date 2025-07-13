using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Invoices.
    /// </summary>
    public enum InvoiceView
    {
        /// <summary>
        /// Invoices.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All Invoices which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
