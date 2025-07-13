namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing service level agreement.
    /// </summary>
    internal sealed class ServiceLevelAgreementUpdateMutation : Mutation<ServiceLevelAgreementUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLevelAgreementUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceLevelAgreementUpdateMutation(ServiceLevelAgreementUpdateInput data, ServiceLevelAgreementQuery query)
            : base("serviceLevelAgreementUpdate", "ServiceLevelAgreementUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "serviceLevelAgreement")))
        {
        }
    }
}
