namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing PDF design.
    /// </summary>
    internal sealed class PdfDesignUpdateMutation : Mutation<PdfDesignUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfDesignUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the pdf design mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal PdfDesignUpdateMutation(PdfDesignUpdateInput data, PdfDesignQuery query)
            : base("pdfDesignUpdate", "PdfDesignUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "pdfDesign")))
        {
        }
    }
}
