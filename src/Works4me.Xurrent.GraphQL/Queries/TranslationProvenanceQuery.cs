using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TranslationProvenance"/> query class.
    /// </summary>
    public class TranslationProvenanceQuery : Query<TranslationProvenance, TranslationProvenanceQuery, DefaultView, TranslationProvenanceField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TranslationProvenanceQuery"/> instance.
        /// </summary>
        public TranslationProvenanceQuery() : base(string.Empty, false)
        {
        }
    }
}
