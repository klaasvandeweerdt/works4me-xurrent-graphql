using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/invoiceupdatepayload/">InvoiceUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class InvoiceUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("invoice", IsDefaultQueryProperty = true)]
        public Invoice? Invoice { get; internal set; }
    }
}
