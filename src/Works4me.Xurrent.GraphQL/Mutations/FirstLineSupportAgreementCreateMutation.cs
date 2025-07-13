namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new first line support agreement.
    /// </summary>
    internal sealed class FirstLineSupportAgreementCreateMutation : Mutation<FirstLineSupportAgreementCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstLineSupportAgreementCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the first line support agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal FirstLineSupportAgreementCreateMutation(FirstLineSupportAgreementCreateInput data, FirstLineSupportAgreementQuery query)
            : base("firstLineSupportAgreementCreate", "FirstLineSupportAgreementCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "firstLineSupportAgreement")))
        {
        }
    }
}
