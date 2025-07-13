using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/servicelevelagreementupdatepayload/">ServiceLevelAgreementUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class ServiceLevelAgreementUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("serviceLevelAgreement", IsDefaultQueryProperty = true)]
        public ServiceLevelAgreement? ServiceLevelAgreement { get; internal set; }
    }
}
