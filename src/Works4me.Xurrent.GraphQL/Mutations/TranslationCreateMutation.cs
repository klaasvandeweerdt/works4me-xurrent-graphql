namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new translation.
    /// </summary>
    internal sealed class TranslationCreateMutation : Mutation<TranslationCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the translation mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal TranslationCreateMutation(TranslationCreateInput data, TranslationQuery query)
            : base("translationCreate", "TranslationCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "translation")))
        {
        }
    }
}
