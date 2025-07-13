namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new invoice.
    /// </summary>
    internal sealed class InvoiceCreateMutation : Mutation<InvoiceCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal InvoiceCreateMutation(InvoiceCreateInput data, InvoiceQuery query)
            : base("invoiceCreate", "InvoiceCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "invoice")))
        {
        }
    }
}
