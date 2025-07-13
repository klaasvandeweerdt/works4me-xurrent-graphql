namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing first line support agreement.
    /// </summary>
    internal sealed class FirstLineSupportAgreementUpdateMutation : Mutation<FirstLineSupportAgreementUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstLineSupportAgreementUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal FirstLineSupportAgreementUpdateMutation(FirstLineSupportAgreementUpdateInput data, FirstLineSupportAgreementQuery query)
            : base("firstLineSupportAgreementUpdate", "FirstLineSupportAgreementUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "firstLineSupportAgreement")))
        {
        }
    }
}
