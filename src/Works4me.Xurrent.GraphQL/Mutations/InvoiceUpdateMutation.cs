namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing invoice.
    /// </summary>
    internal sealed class InvoiceUpdateMutation : Mutation<InvoiceUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the invoice mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal InvoiceUpdateMutation(InvoiceUpdateInput data, InvoiceQuery query)
            : base("invoiceUpdate", "InvoiceUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "invoice")))
        {
        }
    }
}
