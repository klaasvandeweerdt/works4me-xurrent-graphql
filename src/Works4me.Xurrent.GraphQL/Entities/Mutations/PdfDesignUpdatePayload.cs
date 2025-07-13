using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/pdfdesignupdatepayload/">PdfDesignUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class PdfDesignUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("pdfDesign", IsDefaultQueryProperty = true)]
        public PdfDesign? PdfDesign { get; internal set; }
    }
}
