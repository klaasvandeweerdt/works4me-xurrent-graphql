using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/invoicecreatepayload/">InvoiceCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class InvoiceCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("invoice", IsDefaultQueryProperty = true)]
        public Invoice? Invoice { get; internal set; }
    }
}
