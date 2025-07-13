namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing translation.
    /// </summary>
    internal sealed class TranslationUpdateMutation : Mutation<TranslationUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TranslationUpdateMutation(TranslationUpdateInput data, TranslationQuery query)
            : base("translationUpdate", "TranslationUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "translation")))
        {
        }
    }
}
