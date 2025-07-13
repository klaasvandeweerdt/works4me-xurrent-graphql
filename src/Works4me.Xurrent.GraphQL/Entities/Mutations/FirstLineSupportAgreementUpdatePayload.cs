using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/firstlinesupportagreementupdatepayload/">FirstLineSupportAgreementUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class FirstLineSupportAgreementUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("firstLineSupportAgreement", IsDefaultQueryProperty = true)]
        public FirstLineSupportAgreement? FirstLineSupportAgreement { get; internal set; }
    }
}
