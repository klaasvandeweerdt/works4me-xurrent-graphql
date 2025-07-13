namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new service level agreement.
    /// </summary>
    internal sealed class ServiceLevelAgreementCreateMutation : Mutation<ServiceLevelAgreementCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLevelAgreementCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the service level agreement mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal ServiceLevelAgreementCreateMutation(ServiceLevelAgreementCreateInput data, ServiceLevelAgreementQuery query)
            : base("serviceLevelAgreementCreate", "ServiceLevelAgreementCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "serviceLevelAgreement")))
        {
        }
    }
}
