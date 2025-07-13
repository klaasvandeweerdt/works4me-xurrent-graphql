namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new PDF design.
    /// </summary>
    internal sealed class PdfDesignCreateMutation : Mutation<PdfDesignCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfDesignCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal PdfDesignCreateMutation(PdfDesignCreateInput data, PdfDesignQuery query)
            : base("pdfDesignCreate", "PdfDesignCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "pdfDesign")))
        {
        }
    }
}
